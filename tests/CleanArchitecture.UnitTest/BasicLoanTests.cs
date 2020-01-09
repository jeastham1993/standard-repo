// ------------------------------------------------------------
// Copyright (c) James Eastham.
// ------------------------------------------------------------

using System;
using CleanArchitecture.Core.Entities;
using CleanArchitecture.Entities;
using CleanArchitecture.Entities.Exceptions;
using FluentAssertions;
using Moq;
using Xunit;

namespace CleanArchitecture.UnitTest
{
    public class BasicLoanTests
    {
        [Fact]
        public void CanCreateBasicLoan()
        {
            var basicLoan = LoanFactory.CreateLoan("basic", 10000, 8.65M, 24);

            basicLoan.GetType().Name.Should().Be("BasicLoan");
        }

        [Fact]
        public void CreateInvalidLoanType_ShouldThrowException()
        {
            Assert.Throws<ArgumentException>(() => LoanFactory.CreateLoan("aiofnqweiufwiubfweif", 10000, 8.65M, 24));
        }

        [Fact]
        public void CanCalculateInterest_ShouldIncreaseBalanceByRate()
        {
            var basicLoan = LoanFactory.CreateLoan("basic", 10000, 10M, 24);

            var interestAccrued = basicLoan.ApplyInterest();

            interestAccrued.Should().Be(1000);
            basicLoan.Balance.Should().Be(11000);
        }

        [Fact]
        public void MakePayment_ShouldDecreaseBalanceByPaymentAmount()
        {
            var basicLoan = LoanFactory.CreateLoan("basic", 10000, 10M, 24);

            basicLoan.MakePayment(2500);

            basicLoan.Balance.Should().Be(7500);
        }

        [Fact]
        public void MakePaymentGreaterThanBalance_ShouldThrowException()
        {
            var basicLoan = LoanFactory.CreateLoan("basic", 100, 10M, 24);

            Assert.Throws<LoanOverpaymentException>(() => basicLoan.MakePayment(30000));
        }

        [Fact]
        public void ChargeLateFee_ShouldIncreaseBalance()
        {
            var basicLoan = LoanFactory.CreateLoan("basic", 100, 10M, 24);

            basicLoan.ChargeLateFee();

            basicLoan.Balance.Should().Be(225);
        }
    }
}
