using Exchange.Data.Context;
using Exchange.Data.Repositories.Abstractions;
using Exchange.Data.Repositories.Concretes;
using Exchange.Data.Repositories.UnitOfWorks.Abstractions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchange.Data.Repositories.UnitOfWorks.Concretes
{
    //Unit of Work, bir işlem sırasında gerçekleştirilen veritabanı
    //işlemlerini gruplandırır ve bu işlemlerin birlikte tamamlanmasını sağlar.
    
    //Unit of Work(iş birimi), veritabanı işlemlerinin mantıksal bir birimi olarak kullanılan bir tasarım desenidir.
    //Unit of Work tasarım deseni, bir işlem sırasında gerçekleştirilen veritabanı işlemlerini gruplandırır ve bu işlemlerin
    //birlikte tamamlanmasını sağlar.

    //Unit of Work tasarım deseni genellikle bir veritabanı bağlantısı ile ilişkilendirilir ve veritabanı
    //işlemlerinin toplu olarak yönetilmesini sağlar. 

    public class UnitOfWork : IUnitOfWork
    {
        private readonly ExchangeDbContext _dbContext;
        public UnitOfWork(ExchangeDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async ValueTask DisposeAsync()
        {
            await _dbContext.DisposeAsync();
        }
        public int Save()
        {
            return _dbContext.SaveChanges();
        }
        public async Task<int> SaveAsync()
        {
            return await _dbContext.SaveChangesAsync();
        }
        IRepository<T> IUnitOfWork.GetRepository<T>()
        {
            return new Repository<T>(_dbContext);            
        }
    }
}
