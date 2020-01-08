// ------------------------------------------------------------
// Copyright (c) James Eastham.
// ------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Entities
{
    /// <summary>
    /// A basic loan implementation.
    /// </summary>
    internal class BasicLoan : Loan
    {
        public BasicLoan(decimal principal, decimal rate, decimal term)
            : base(principal, rate, term)
        {
        }
    }
}
