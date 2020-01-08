// ------------------------------------------------------------
// Copyright (c) James Eastham.
// ------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace CleanArchitecture.UseCases
{
    /// <summary>
    /// Response from a successul gather of ContractInfo.
    /// </summary>
    public class GatherContactInfoResponse
    {
        private List<string> _errors;

        /// <summary>
        /// Initializes a new instance of the <see cref="GatherContactInfoResponse"/> class.
        /// </summary>
        internal GatherContactInfoResponse()
        {
            this._errors = new List<string>(0);
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
        public int CreditScore { get; set; }

        /// <summary>
        /// Gets any error messages.
        /// </summary>
        public IReadOnlyCollection<string> Errors => this._errors;

        internal void AddError(string errorMessage)
        {
            if (this._errors == null)
            {
                this._errors = new List<string>(1);
            }

            this._errors.Add(errorMessage);
        }
    }
}
