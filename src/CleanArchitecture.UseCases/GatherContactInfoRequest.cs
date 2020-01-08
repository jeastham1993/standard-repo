// ------------------------------------------------------------
// Copyright (c) James Eastham.
// ------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;
using CleanArchitecture.Entities;

namespace CleanArchitecture.UseCases
{
    /// <summary>
    /// Gather required data for a new loan.
    /// </summary>
    public class GatherContactInfoRequest
    {
        private string _name;
        private string _address;
        private DateTime _dateOfBirth;
        private string _niNumber;

        /// <summary>
        /// Initializes a new instance of the <see cref="GatherContactInfoRequest"/> class.
        /// </summary>
        /// <param name="name">The applicants name.</param>
        /// <param name="address">The applicants address.</param>
        /// <param name="dateOfBirth">The applicants date of birth.</param>
        /// <param name="nationalInsuranceNumber">The applicants NI number.</param>
        public GatherContactInfoRequest(string name, string address, DateTime dateOfBirth, string nationalInsuranceNumber)
        {
            this._name = name;
            this._address = address;
            this._dateOfBirth = dateOfBirth;
            this._niNumber = nationalInsuranceNumber;
        }

        /// <summary>
        /// Execute a GatherContractInfoRequest.
        /// </summary>
        /// <returns>A <see cref="GatherContactInfoResponse"/>.</returns>
        public GatherContactInfoResponse Execute()
        {
            var response = new GatherContactInfoResponse();

            if (string.IsNullOrEmpty(this._name))
            {
                response.AddError("Name cannot be empty");
            }

            return response;
        }
    }
}
