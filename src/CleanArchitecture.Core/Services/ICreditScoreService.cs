// ------------------------------------------------------------
// Copyright (c) James Eastham.
// ------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Core.Services
{
    /// <summary>
    /// An interface used for getting credit scores.
    /// </summary>
    public interface ICreditScoreService
    {
        /// <summary>
        /// Retrieve the credit score for a given National Insurance number.
        /// </summary>
        /// <param name="nationalInsuranceNumber">A National Insurance number.</param>
        /// <returns>The <see cref="decimal"/> credit score rating.</returns>
        decimal GetCreditScore(string nationalInsuranceNumber);
    }
}
