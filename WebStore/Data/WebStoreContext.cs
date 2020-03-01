using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using WebStore.Models;
using Microsoft.Extensions.Configuration;
using WebStore.Data.Configurations;

namespace WebStore.Data
{
    public class WebStoreContext : IdentityDbContext
    {
        public DbSet<WebStore.Models.Products> Products { get; set; }

        public WebStoreContext (DbContextOptions<WebStoreContext> options)
            : base(options)
        {
            

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new ProductConfig()).Seed();
        }

    }
}
