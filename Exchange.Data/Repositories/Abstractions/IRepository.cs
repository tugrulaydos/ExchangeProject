using Exchange.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchange.Data.Repositories.Abstractions
{
    public interface IRepository<T> where T : class, IEntityBase, new() 
    {
    }
}
