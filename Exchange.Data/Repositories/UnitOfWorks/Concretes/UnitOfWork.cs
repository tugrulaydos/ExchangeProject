using Exchange.Data.Repositories.Abstractions;
using Exchange.Data.Repositories.UnitOfWorks.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchange.Data.Repositories.UnitOfWorks.Concretes
{
    public class UnitOfWork : IUnitOfWork
    {
        public ValueTask DisposeAsync()
        {
            throw new NotImplementedException();
        }

        public int Save()
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveAsync()
        {
            throw new NotImplementedException();
        }

        IRepository<T> IUnitOfWork.GetRepository<T>()
        {
            throw new NotImplementedException();
        }
    }
}
