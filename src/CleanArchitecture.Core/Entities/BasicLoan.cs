// ------------------------------------------------------------
// Copyright (c) James Eastham.
// ------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Core.Entities
{
    /// <summary>
    /// A basic loan implementation.
    /// </summary>
    public class BasicLoan : Loan
    {
        internal BasicLoan(decimal principal, decimal rate, decimal term)
            : base(principal, rate, term)
        {
        }
    }
}
