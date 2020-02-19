using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebStore.Models;

namespace WebStore.Data
{
    public class AccountContext : DbContext
    {
        public AccountContext (DbContextOptions<AccountContext> options)
            : base(options)
        {
        }

        public DbSet<WebStore.Models.AccountModel> AccountModel { get; set; }
    }
}
