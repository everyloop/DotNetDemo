using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

#nullable disable

namespace CompanyDB
{
    public class CustomerEntityTypeConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("customers", "company");

            builder.Property(e => e.Id).HasMaxLength(10);

            builder.Property(e => e.Address).HasMaxLength(100);

            builder.Property(e => e.City).HasMaxLength(50);

            builder.Property(e => e.CompanyName)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(e => e.ContactName).HasMaxLength(50);

            builder.Property(e => e.ContactTitle).HasMaxLength(50);

            builder.Property(e => e.Country).HasMaxLength(50);

            builder.Property(e => e.Fax).HasMaxLength(50);

            builder.Property(e => e.Phone).HasMaxLength(50);

            builder.Property(e => e.PostalCode).HasMaxLength(20);

            builder.Property(e => e.Region).HasMaxLength(50);
        }
    }
}
