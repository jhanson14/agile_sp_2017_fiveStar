using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebStore.Data.Configurations;

namespace WebStore.Data
{
	public class WebStoreContext : IdentityDbContext
	{
		public DbSet<WebStore.Models.Products> Products { get; set; }

		public WebStoreContext(DbContextOptions<WebStoreContext> options)
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
