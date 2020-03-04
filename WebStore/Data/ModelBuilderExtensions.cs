using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Data;
using WebStore.Models;

namespace WebStore.Data
{

    // Seeds data for product table
    public static class ModelBuilderExtensions
    {
        public static ModelBuilder Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Products>().HasData(
                new Products
                {
                    Id = 1,
                    Name = "basic Monitor",
                    Description = "Suited for light gaming and office use.",
                    Price = 50,
                    Genre = "test",
                    FilePath = "/images/basicMonitor.jpg"
                },
                new Products
                {
                    Id = 2,
                    Name = "basic Monitor",
                    Description = "Suited for light gaming and office use.",
                    Price = 50,
                    Genre = "test",
                    FilePath = "/images/basicMonitor.jpg"
                }

        );
            return modelBuilder;
        }
    }
}
