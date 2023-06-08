using Exchange.Core.Entities;
using Exchange.Data.Repositories.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchange.Data.Repositories.UnitOfWorks.Abstractions
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        IRepository<T> GetRepository<T>() where T : class, IEntityBase, new();

        Task<int> SaveAsync();

        int Save();
    }
}
