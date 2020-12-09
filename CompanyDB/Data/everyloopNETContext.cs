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
            optionsBuilder.UseSqlServer("Server=localhost;Database=EveryloopNET;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new CustomerEntityTypeConfiguration().Configure(modelBuilder.Entity<Customer>());
            new OrderEntityTypeConfiguration().Configure(modelBuilder.Entity<Order>());
            new OrderDetailEntityTypeConfiguration().Configure(modelBuilder.Entity<OrderDetail>());
            new ProductEntityTypeConfiguration().Configure(modelBuilder.Entity<Product>());

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
