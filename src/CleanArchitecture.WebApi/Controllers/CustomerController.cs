// ------------------------------------------------------------
// Copyright (c) James Eastham.
// ------------------------------------------------------------

using System;
using System.Threading.Tasks;
using CleanArchitecture.Core.Entities;
using CleanArchitecture.Core.Requests;
using CleanArchitecture.Core.Services;
using CleanArchitecture.WebApi.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CleanArchitecture.WebApi.Controllers
{
    /// <summary>
    /// Encapsulates all endpoints for managing customers.
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly ILogger<CustomerController> _logger;
        private readonly ICreditScoreService _creditScoreService;
        private readonly ICustomerDatabase _customerDatabase;

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerController"/> class.
        /// </summary>
        /// <param name="logger">A <see cref="ILogger"/>.</param>
        /// <param name="creditScoreService">A <see cref="ICreditScoreService"/>.</param>
        /// <param name="customerDatabase">A <see cref="ICustomerDatabase"/>.</param>
        public CustomerController(
            ILogger<CustomerController> logger,
            ICreditScoreService creditScoreService,
            ICustomerDatabase customerDatabase)
        {
            this._logger = logger;
            this._creditScoreService = creditScoreService;
            this._customerDatabase = customerDatabase;
        }

        /// <summary>
        /// Gather contact info for a given new customer. If the data is eligible, a new customer record will be created.
        /// </summary>
        /// <param name="getContactInfo">A <see cref="GetContactInfoDTO"/>.</param>
        /// <returns>A <see cref="GatherContactInfoResponse"/>.</returns>
        [HttpPost]
        public GatherContactInfoResponse GatherContactInfo([FromBody] GetContactInfoDTO getContactInfo)
        {
            if (getContactInfo is null)
            {
                throw new ArgumentNullException(nameof(getContactInfo));
            }

            var request = new GatherContactInfoRequest(
                getContactInfo.Name,
                getContactInfo.Address,
                getContactInfo.DateOfBirth,
                getContactInfo.NationalInsuranceNumber);

            var requestHandler = new GatherContactInfoInteractor(
                this._creditScoreService,
                this._customerDatabase);

            return requestHandler.Handle(request);
        }
    }
}
