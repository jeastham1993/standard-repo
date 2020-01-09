// ------------------------------------------------------------
// Copyright (c) James Eastham.
// ------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace CleanArchitecture.Core.Requests
{
    /// <summary>
    /// Response from a successul gather of ContractInfo.
    /// </summary>
    public class GatherContactInfoResponse
        : BaseResponse
    {
        internal GatherContactInfoResponse(string name, string address, DateTime dateOfBirth, string nationalInsuranceNumber)
            : base()
        {
            this.Name = name;
            this.Address = address;
            this.DateOfBirth = dateOfBirth;
            this.NationalInsuranceNumber = nationalInsuranceNumber;
        }

        /// <summary>
        /// Gets or sets the applicants name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the applicants address.
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Gets or sets the applicants date of birth.
        /// </summary>
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// Gets or sets the applicants national insurance number.
        /// </summary>
        public string NationalInsuranceNumber { get; set; }

        /// <summary>
        /// Gets or sets the applicants credit score.
        /// </summary>
        public decimal CreditScore { get; set; }
    }
}
