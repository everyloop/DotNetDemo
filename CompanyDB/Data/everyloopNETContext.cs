using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace CompanyDB
{
    public partial class everyloopNETContext : DbContext
    {
        public everyloopNETContext()
        {
        }

        public everyloopNETContext(DbContextOptions<everyloopNETContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=everyloopNET;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("customers", "company");

                entity.Property(e => e.Id).HasMaxLength(10);

                entity.Property(e => e.Address).HasMaxLength(100);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ContactName).HasMaxLength(50);

                entity.Property(e => e.ContactTitle).HasMaxLength(50);

                entity.Property(e => e.Country).HasMaxLength(50);

                entity.Property(e => e.Fax).HasMaxLength(50);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.PostalCode).HasMaxLength(20);

                entity.Property(e => e.Region).HasMaxLength(50);
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("orders", "company");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CustomerId).HasMaxLength(10);

                entity.Property(e => e.OrderDate).HasMaxLength(10);

                entity.Property(e => e.RequiredDate).HasMaxLength(10);

                entity.Property(e => e.ShipAddress).HasMaxLength(100);

                entity.Property(e => e.ShipCity).HasMaxLength(50);

                entity.Property(e => e.ShipCountry).HasMaxLength(50);

                entity.Property(e => e.ShipName).HasMaxLength(100);

                entity.Property(e => e.ShipPostalCode).HasMaxLength(20);

                entity.Property(e => e.ShipRegion).HasMaxLength(50);

                entity.Property(e => e.ShippedDate).HasMaxLength(10);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_Orders_Customers");
            });

            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.ToTable("order_details", "company");

                entity.Property(e => e.Id).HasMaxLength(10);

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_OrderDetails_Orders");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_OrderDetails_Products");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("products", "company");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ProductName).HasMaxLength(100);

                entity.Property(e => e.QuantityPerUnit).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
