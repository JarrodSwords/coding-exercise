using System;

namespace Infrastructure
{
    public class Employee : Entity
    {
        #region Creation

        public Employee(Domain.Staff.Employee employee)
        {
            Address = employee.Address;
            Name = employee.Name;
            Telephone = employee.Telephone;
            EmploymentDate = employee.EmploymentDate;
        }

        #endregion

        #region Public Interface

        public string Address { get; set; }
        public DateTime EmploymentDate { get; set; }
        public string Name { get; set; }
        public string Telephone { get; set; }

        #endregion

        #region Static Interface

        public static implicit operator Employee(Domain.Staff.Employee source) => new(source);

        public static implicit operator Domain.Staff.Employee(Employee source) =>
            new(
                source.Address,
                source.EmploymentDate,
                source.Name,
                source.Telephone
            );

        #endregion
    }
}
