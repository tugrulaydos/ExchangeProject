using Exchange.Core.Entities;
using Exchange.Data.Repositories.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchange.Data.Repositories.Concretes
{
    public class Repository<T>:IRepository<T> where T:class,IEntityBase,new ()
    {

    }
}
