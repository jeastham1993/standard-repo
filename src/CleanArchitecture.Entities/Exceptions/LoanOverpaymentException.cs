// ------------------------------------------------------------
// Copyright (c) James Eastham.
// ------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Entities.Exceptions
{
    /// <summary>
    /// Exception throw when a loan is overpaid.
    /// </summary>
    public class LoanOverpaymentException
        : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LoanOverpaymentException"/> class.
        /// </summary>
        /// <param name="message">The message to initialize the exception with.</param>
        public LoanOverpaymentException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LoanOverpaymentException"/> class.
        /// </summary>
        /// <param name="message">The message to initialize the exception with.</param>
        /// <param name="innerException">An inner <see cref="Exception"/>.</param>
        public LoanOverpaymentException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LoanOverpaymentException"/> class.
        /// </summary>
        public LoanOverpaymentException()
        {
        }
    }
}
