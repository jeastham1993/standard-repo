// ------------------------------------------------------------
// Copyright (c) James Eastham.
// ------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;
using CleanArchitecture.Entities.Exceptions;

namespace CleanArchitecture.Core.Entities
{
    /// <summary>
    /// Encapsulates all code for managing loans.
    /// </summary>
    public abstract class Loan
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Loan"/> class.
        /// </summary>
        /// <param name="principal">The principal valie of the loan.</param>
        /// <param name="rate">The annual interest rate percentage.</param>
        /// <param name="period">The term of the loan.</param>
        internal Loan(decimal principal, decimal rate, decimal period)
        {
            this.Principal = principal;
            this.Rate = rate;
            this.Period = period;
            this.Balance = principal;
        }

        /// <summary>
        /// Gets the standard late fee to be charged.
        /// </summary>
        public virtual decimal LateFee
        {
            get
            {
                return 125M;
            }
        }

        /// <summary>
        /// Gets the initial principal of the loan.
        /// </summary>
        public decimal Principal { get; private set; }

        /// <summary>
        /// Gets the interest rate of the loan.
        /// </summary>
        public decimal Rate { get; private set; }

        /// <summary>
        /// Gets the period the loan will be repayed over.
        /// </summary>
        public decimal Period { get; private set; }

        /// <summary>
        /// Gets the current balance of the loan.
        /// </summary>
        public decimal Balance { get; private set; }

        /// <summary>
        /// Make a payment against the loan.
        /// </summary>
        /// <param name="paymentAmount">The value of the payment made.</param>
        public virtual void MakePayment(decimal paymentAmount)
        {
            var newCalculatedBalance = this.Balance - paymentAmount;

            if (newCalculatedBalance < 0)
            {
                throw new LoanOverpaymentException($"A payment of {paymentAmount} would take the current loan balance below 0");
            }

            this.Balance = this.Balance - paymentAmount;
        }

        /// <summary>
        /// Apply the interest for the elapsed period.
        /// </summary>
        /// <returns>The total accrued interest value.</returns>
        public virtual decimal ApplyInterest()
        {
            this.Balance = this.Principal * (1 + (this.Rate / 100));

            return this.Balance - this.Principal;
        }

        /// <summary>
        /// Charge a late payment fee to this loan.
        /// </summary>
        /// <returns>The new balance after the late fee has been added.</returns>
        public virtual decimal ChargeLateFee()
        {
            this.Balance = this.Balance + this.LateFee;

            return this.Balance;
        }
    }
}
