// ------------------------------------------------------------
// Copyright (c) James Eastham.
// ------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;
using CleanArchitecture.Entities;
using FluentAssertions;
using Xunit;

namespace CleanArchitecture.UnitTest
{
    public class CustomerTests
    {
        private const string Name = "James";
        private const string Address = "My address, my town, my street, AA1 7AA";
        private const string NationalInsuranceNumber = "1236789 C";
        private readonly DateTime dateOfBirth = new DateTime(1907, 01, 01);

        [Fact]
        public void NewCustomer_ShouldAutoPopulateCustomerId()
        {
            var customer = new Customer(Name, Address, this.dateOfBirth, NationalInsuranceNumber);

            customer.CustomerId.Should().NotBeNullOrEmpty();
            Assert.True(Guid.TryParse(customer.CustomerId, out _));
        }

        [Fact]
        public void NewCustomer_ShouldPopulateName()
        {
            var customer = new Customer(Name, Address, this.dateOfBirth, NationalInsuranceNumber);

            customer.Name.Should().Be(Name);
        }

        [Fact]
        public void NewCustomer_ShouldPopulateAddress()
        {
            var customer = new Customer(Name, Address, this.dateOfBirth, NationalInsuranceNumber);

            customer.Address.Should().Be(Address);
        }

        [Fact]
        public void NewCustomer_ShouldShouldPopulateDateOfBirth()
        {
            var customer = new Customer(Name, Address, this.dateOfBirth, NationalInsuranceNumber);

            customer.DateOfBirth.Should().Be(this.dateOfBirth);
        }

        [Fact]
        public void NewCustomer_ShouldShouldPopulateNiNumber()
        {
            var customer = new Customer(Name, Address, this.dateOfBirth, NationalInsuranceNumber);

            customer.NationalInsuranceNumber.Should().Be(NationalInsuranceNumber);
        }
    }
}
