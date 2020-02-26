using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebStore.Models;

namespace WebStore.Data
{
    public class WebStoreContext : IdentityDbContext
    {
        public WebStoreContext (DbContextOptions<WebStoreContext> options)
            : base(options)
        {
        }

        public DbSet<WebStore.Models.Products> Products { get; set; }
    }
}
