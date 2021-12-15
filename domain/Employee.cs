using System;

namespace Domain
{
    public class Employee : Aggregate
    {
        #region Creation

        public Employee(
            string address,
            DateTime employmentDate,
            string name,
            string telephone
        )
        {
            Address = address;
            EmploymentDate = employmentDate;
            Name = name;
            Telephone = telephone;
        }

        #endregion

        #region Public Interface

        public string Address { get; set; }
        public DateTime EmploymentDate { get; set; }
        public string Name { get; set; }
        public string Telephone { get; set; }

        #endregion
    }
}
