// ------------------------------------------------------------
// Copyright (c) James Eastham.
// ------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArchitecture.WebApi.ViewModels
{
    /// <summary>
    /// Data Transfer Object for getting contact info.
    /// </summary>
    public class GetContactInfoDTO
    {
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
    }
}
