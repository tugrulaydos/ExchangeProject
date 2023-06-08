using Exchange.Entity.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchange.Data.Context
{
    public class ExchangeDbContext:IdentityDbContext<AppUser, AppRole, Guid, AppUserClaim, AppUserRole, AppUserLogin, AppRoleClaim, AppUserToken>
    {
        public ExchangeDbContext()
        {

        }

        public ExchangeDbContext(DbContextOptions<ExchangeDbContext> options) : base(options)
        {

        }



        public DbSet<UserSetting> UserSettings { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<DailyClosed> dailyCloseds { get; set; }
        public DbSet<EmailTransaction> EmailTransactions { get; set; }


    }
}
