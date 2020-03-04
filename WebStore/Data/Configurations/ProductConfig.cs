using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebStore.Models;


namespace WebStore.Data.Configurations
{
	public class ProductConfig : IEntityTypeConfiguration<Products>
	{
		public void Configure(EntityTypeBuilder<Products> builder)
		{
			// maps the file name property to column file path in database (change the names later)
			// not sure if needed yet
			builder.Property(p => p.FilePath).HasColumnName("FilePath");
		}
	}
}
