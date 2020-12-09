using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

#nullable disable

namespace CompanyDB
{
    public class ProductEntityTypeConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("products", "company");

            builder.Property(e => e.Id).ValueGeneratedNever();

            builder.Property(e => e.ProductName).HasMaxLength(100);

            builder.Property(e => e.QuantityPerUnit).HasMaxLength(50);

            // builder.Property(e => e.Id).UseIdentityColumn();

            /*
            builder.HasData(
                new Product() { Id = 1, ProductName = "Chai" },
                new Product() { Id = 2, ProductName = "Chang" },
                new Product() { Id = 3, ProductName = "Aniseed Syrup" },
                new Product() { Id = 4, ProductName = "Chef Anton's Cajun Seasoning" },
                new Product() { Id = 5, ProductName = "Chef Anton's Gumbo Mix" }
            );
            */
        }
    }
}
