using Exchange.Data.Context;
using Exchange.Data.Repositories.Abstractions;
using Exchange.Data.Repositories.Concretes;
using Exchange.Data.Repositories.UnitOfWorks.Abstractions;
using Exchange.Data.Repositories.UnitOfWorks.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Exchange.Data.Extensions
{
    public static class DataLayerExtension
    {
        public static IServiceCollection LoadDataLayerExtension(this IServiceCollection services, IConfiguration config) 
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>)); //Repositroy DI

            services.AddDbContext<ExchangeDbContext>(a => a.UseSqlServer(config.GetConnectionString("DefaultConnection")));

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;

        }
    }
}   
