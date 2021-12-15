using System;
using System.Collections.Generic;
using Domain.Staff;

namespace Infrastructure
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly Context _context;

        #region Creation

        public EmployeeRepository(Context context)
        {
            _context = context;
        }

        #endregion

        #region IEmployeeRepository Implementation

        public Guid Create(Domain.Staff.Employee employee)
        {
            _context.Employees.Add(employee);
            return employee.Id;
        }

        public void Delete(Guid id)
        {
            var employee = _context.Employees.Find(id);
            _context.Employees.Remove(employee);
        }

        public IEnumerable<Domain.Staff.Employee> Fetch() => throw new NotImplementedException();

        public void Update(Domain.Staff.Employee employee)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
