using Exchange.Data.Context;
using Exchange.Data.Repositories.Abstractions;
using Exchange.Data.Repositories.Concretes;
using Exchange.Data.Repositories.UnitOfWorks.Abstractions;
using Exchange.Data.Repositories.UnitOfWorks.Concretes;
using Exchange.Service.Services.Abstractions;
using Exchange.Service.Services.Concretes;
using Microsoft.EntityFrameworkCore;
using System.Configuration;


namespace Exchange.Web
{
   
    
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //DI'lar Daha Sonra Extension Method ��erisinde Yaz�lacak.
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
            builder.Services.AddDbContext<ExchangeDbContext>(options => options.UseSqlServer(connectionString));
            // Add services to the container.
            builder.Services.AddControllersWithViews(); 
            builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>)); //Repositroy DI
            //builder.Services.AddScoped<IUserService, UserService>();
            builder.Services.AddScoped<ICurrencyService, CurrencyService>();
           




            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}