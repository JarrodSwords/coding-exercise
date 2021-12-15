using System;
using Domain.Staff;

namespace Domain
{
    public abstract class Entity
    {
        #region Creation

        protected Entity(Guid id = default)
        {
            Id = id == default ? Guid.NewGuid() : id;
        }

        #endregion

        #region Public Interface

        public Guid Id { get; set; }

        #endregion
    }

    public interface IUnitOfWork
    {
        IEmployeeRepository Employees { get; }
        void Commit();
    }
}
