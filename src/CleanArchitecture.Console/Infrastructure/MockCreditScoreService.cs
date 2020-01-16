// ------------------------------------------------------------
// Copyright (c) James Eastham.
// ------------------------------------------------------------

using System;
using System.Threading.Tasks;
using CleanArchitecture.Core.Services;

namespace CleanArchitecture.ConsoleApp
{
    /// <summary>
    /// Encapsulates all logic for running credit checks.
    /// </summary>
    public class MockCreditScoreService
        : ICreditScoreService
    {
        /// <inheritdoc/>
        public decimal GetCreditScore(string nationalInsuranceNumber)
        {
            Random random = new Random(DateTime.Now.Second);
            decimal randomNumber = random.Next(0, 1000);

            return randomNumber;
        }
    }
}
