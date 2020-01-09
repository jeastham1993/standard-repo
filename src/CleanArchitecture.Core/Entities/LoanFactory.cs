// ------------------------------------------------------------
// Copyright (c) James Eastham.
// ------------------------------------------------------------

using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("CleanArchitecture.UnitTest")]

namespace CleanArchitecture.Core.Entities
{
    /// <summary>
    /// A factory for creating loans.
    /// </summary>
    internal static class LoanFactory
    {
        /// <summary>
        /// Create a new loan object.
        /// </summary>
        /// <param name="type">The type of loan to create.</param>
        /// <param name="principal">The initial principal of the loan.</param>
        /// <param name="rate">The annual interest rate percentage of the loan.</param>
        /// <param name="period">The period over which the loan was take.</param>
        /// <returns>A <see cref="Loan"/>/.</returns>
        internal static Loan CreateLoan(string type, decimal principal, decimal rate, decimal period)
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
