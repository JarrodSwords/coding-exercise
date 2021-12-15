using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class Context : DbContext
    {
        #region Creation

        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        #endregion

        #region Public Interface

        public DbSet<Employee> Employees { get; set; }

        #endregion
    }
}
