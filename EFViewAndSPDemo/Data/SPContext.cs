using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace EFViewAndSPDemo
{
    public class SPContext : DbContext
    {
        private string ConnectionString;

        public SPContext()
        {
            ConnectionString = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build()
            .GetConnectionString("Default");
        }

        public DbSet<Person> People { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Random> Randoms { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().ToTable("People").HasKey(person => person.Id);
            modelBuilder.Entity<Person>().Property(p => p.Id).UseIdentityColumn();

            modelBuilder.Entity<Person>().HasData(
                new Person() { Id = 1, FirstName = "Fredrik", LastName = "Johansson", Age = 39 },
                new Person() { Id = 2, FirstName = "Per", LastName = "Andersson", Age = 29 },
                new Person() { Id = 3, FirstName = "Anna", LastName = "Hansson", Age = 19 }
            );

            modelBuilder.Entity<User>().ToView("Users").HasNoKey();

            modelBuilder.Entity<Random>().ToSqlQuery("exec random 10").HasNoKey();
        }
    }
}


