using System;
using System.Collections.Generic;

namespace Domain.Staff
{
    public interface IEmployeeRepository
    {
        Guid Create(Employee employee);
        void Delete(Guid id);
        IEnumerable<Employee> Fetch();
        void Update(Employee employee);
    }
}
