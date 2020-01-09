// ------------------------------------------------------------
// Copyright (c) James Eastham.
// ------------------------------------------------------------

using System;

namespace CleanArchitecture.Core.Requests
{
    /// <summary>
    /// Gather required data for a new loan.
    /// </summary>
    public class GatherContactInfoRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GatherContactInfoRequest"/> class.
        /// </summary>
        /// <param name="name">The applicants name.</param>
        /// <param name="address">The applicants address.</param>
        /// <param name="dateOfBirth">The applicants date of birth.</param>
        /// <param name="nationalInsuranceNumber">The applicants NI number.</param>
        public GatherContactInfoRequest(string name, string address, DateTime dateOfBirth, string nationalInsuranceNumber)
        {
            this.Name = name;
            this.Address = address;
            this.DateOfBirth = dateOfBirth;
            this.NationalInsuranceNumber = nationalInsuranceNumber;
        }

        /// <summary>
        /// Gets the name.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Gets the address.
        /// </summary>
        public string Address { get; private set; }

        /// <summary>
        /// Gets the date of birth.
        /// </summary>
        public DateTime DateOfBirth { get; private set; }

        /// <summary>
        /// Gets the National Insurance number.
        /// </summary>
        public string NationalInsuranceNumber { get; private set; }
    }
}
