using Exchange.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Exchange.Data.Repositories.Abstractions
{
    public interface IRepository<T> where T : class, IEntityBase, new()//T, new'lenebilir ve IEntityBase'den türeyen bir sınıf olmak zorunda.
    {
        Task AddAsync(T entity);
        Task<List<T>> GetAllAsync(Expression<Func<T,bool>> predicate=null, params Expression<Func<T, object>>[] includeProperties); //Entity Listesi
        Task<T> GetAsync(Expression<Func<T,bool>> predicate=null, params Expression<Func<T, object>>[] includeProperties);  //Tek bir Entity Döndürecek,

        Task<T> GetByGuidAsync(Guid id); //Entity'e ID değeri ile erişmek istediğimizde
        Task<T> UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task<bool> AnyAsync(Expression<Func<T, bool>> predicate); //İlgili sorguda herhangi bir değer var mı

        Task<int> CountAsync(Expression<Func<T, bool>> predicate=null); //ilgili sorguyu sağlayan kaç adet değer var.   

    }
}
