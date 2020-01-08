// ------------------------------------------------------------
// Copyright (c) James Eastham.
// ------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Entities
{
    /// <summary>
    /// A factory for creating loans.
    /// </summary>
    public static class LoanFactory
    {
        /// <summary>
        /// Create a new loan object.
        /// </summary>
        /// <param name="type">The type of loan to create.</param>
        /// <param name="principal">The initial principal of the loan.</param>
        /// <param name="rate">The annual interest rate percentage of the loan.</param>
        /// <param name="period">The period over which the loan was take.</param>
        /// <returns>A <see cref="Loan"/>/.</returns>
        public static Loan CreateLoan(string type, decimal principal, decimal rate, decimal period)
        {
            var loan = type switch
            {
                "basic" => new BasicLoan(principal, rate, period),
                _ => throw new ArgumentException("Invalid loan type", nameof(type))
            };

            return loan;
        }
    }
}
