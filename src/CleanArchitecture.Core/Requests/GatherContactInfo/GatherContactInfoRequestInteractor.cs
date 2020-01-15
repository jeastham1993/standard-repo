// ------------------------------------------------------------
// Copyright (c) James Eastham.
// ------------------------------------------------------------

using System;
using System.Threading.Tasks;
using CleanArchitecture.Core.Entities;
using CleanArchitecture.Core.Services;

namespace CleanArchitecture.Core.Requests
{
    /// <summary>
    /// Handles a <see cref="GatherContactInfoRequest"/>.
    /// </summary>
    public class GatherContactInfoRequestInteractor
        : IRequestHandler<GatherContactInfoRequest, GatherContactInfoResponse>
    {
        private readonly ICreditScoreService _creditScoreService;
        private readonly ICustomerDatabase _customerDatabase;

        /// <summary>
        /// Initializes a new instance of the <see cref="GatherContactInfoRequestInteractor"/> class.
        /// </summary>
        /// <param name="creditScoreService">A <see cref="ICreditScoreService"/>.</param>
        /// <param name="customerDatabase">A <see cref="ICustomerDatabase"/>.</param>
        public GatherContactInfoRequestInteractor(ICreditScoreService creditScoreService, ICustomerDatabase customerDatabase)
        {
            this._creditScoreService = creditScoreService;
            this._customerDatabase = customerDatabase;
        }

        /// <summary>
        /// Handle the given <see cref="GatherContactInfoRequest"/>.
        /// </summary>
        /// <param name="request">A <see cref="GatherContactInfoRequest"/>.</param>
        /// <returns>A <see cref="GatherContactInfoResponse"/>.</returns>
        public GatherContactInfoResponse Handle(GatherContactInfoRequest request)
        {
            if (request is null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            var response = new GatherContactInfoResponse(
                request.Name,
                request.Address,
                request.DateOfBirth,
                request.NationalInsuranceNumber);

            if (string.IsNullOrEmpty(request.Name))
            {
                response.AddError("Name cannot be empty");
            }

            if (string.IsNullOrEmpty(request.Address))
            {
                response.AddError("Address cannot be empty");
            }

            if (string.IsNullOrEmpty(request.NationalInsuranceNumber))
            {
                response.AddError("National Insurance number cannot be empty.");
            }

            var customerRecord = new Customer(request.Name, request.Address, request.DateOfBirth, request.NationalInsuranceNumber);

            if (customerRecord.Age < 18)
            {
                response.AddError("A customer must be over the age of 18");
            }

            if (response.HasError == false)
            {
                response.CreditScore = this._creditScoreService.GetCreditScore(request.NationalInsuranceNumber);

                if (response.CreditScore > 500)
                {
                    this._customerDatabase.Store(customerRecord);
                }
                else
                {
                    response.AddError("Credit score is too low, sorry!");
                }
            }

            return response;
        }
    }
}
