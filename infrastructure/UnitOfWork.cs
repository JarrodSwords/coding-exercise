using Domain;
using Domain.Staff;

namespace Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly Context _context;
        private IEmployeeRepository _employees;

        #region Creation

        public UnitOfWork(Context context)
        {
            _context = context;
        }

        #endregion

        #region IUnitOfWork Implementation

        public IEmployeeRepository Employees => _employees ??= new EmployeeRepository(_context);

        public void Commit()
        {
            _context.SaveChanges();
        }

        #endregion
    }
}
