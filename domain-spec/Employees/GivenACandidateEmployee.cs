using System;
using Domain;
using FluentAssertions;
using Xunit;

namespace DomainSpec.Employees
{
    public class GivenACandidateEmployee
    {
        #region Core

        private readonly Employee _sut;

        public GivenACandidateEmployee()
        {
            _sut = new Employee(
                "1600 Pennsylvania Ave.",
                DateTime.Today,
                "Jenny",
                "15558675309"
            );
        }

        #endregion

        #region Test Methods

        [Fact]
        public void ThenAddressIsSet()
        {
            _sut.Address.Should().NotBeEmpty();
        }

        [Fact]
        public void WhenCreatingEmployee_EmployeeIsCreated()
        {
            _sut.Should().NotBeNull();
        }

        #endregion
    }
}
