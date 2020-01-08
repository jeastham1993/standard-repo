// ------------------------------------------------------------
// Copyright (c) James Eastham.
// ------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CleanArchitecture.UseCases;
using FluentAssertions;
using Xunit;

namespace CleanArchitecture.UnitTest
{
    public class GatherContractInfoRequestTests
    {
        private const string Name = "James";
        private const string Address = "My address, my town, my street, AA1 7AA";
        private const string NationalInsuranceNumber = "1236789 C";
        private readonly DateTime dateOfBirth = new DateTime(1907, 01, 01);

        [Fact]
        public void CanCreate()
        {
            var gatherContractInfoRequest = new GatherContactInfoRequest(Name, Address, this.dateOfBirth, NationalInsuranceNumber);

            gatherContractInfoRequest.Should().NotBeNull();
        }

        [Fact]
        public void CanExecute_ShouldComplete()
        {
            var gatherContractInfoRequest = new GatherContactInfoRequest(Name, Address, this.dateOfBirth, NationalInsuranceNumber);

            var gatherContractInfoResponse = gatherContractInfoRequest.Execute();

            gatherContractInfoResponse.Should().NotBeNull();
            gatherContractInfoResponse.Errors.Count().Should().Be(0);
        }

        [Fact]
        public void CanExecute_ShouldReturnErrorOnInvalidName()
        {
            var gatherContractInfoRequest = new GatherContactInfoRequest(string.Empty, Address, this.dateOfBirth, NationalInsuranceNumber);

            var gatherContractInfoResponse = gatherContractInfoRequest.Execute();

            gatherContractInfoResponse.Errors.Count().Should().Be(1);
        }
    }
}
