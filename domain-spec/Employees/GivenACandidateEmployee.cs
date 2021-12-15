using System;
using Domain;
using Xunit;

namespace DomainSpec.Employees
{
    public class GivenACandidateEmployee
    {
        #region Test Methods

        [Fact]
        public void WhenCreatingEmployee_EmployeeIsCreated()
        {
            var employee = new Employee(
                "1600 Pennsylvania Ave.",
                DateTime.Today,
                "Jenny",
                "15558675309"
            );

            employee.Should().NotBeNull();
        }

        #endregion
    }
}
