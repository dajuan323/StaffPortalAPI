using StaffPortalAPI.Domain.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace StaffPortalAPI.Persistence.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    public DbSet<Customer> Customers { get; set; }

    public DbSet<User> Users { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {




        modelBuilder.Entity<Customer>().HasData(
                new Customer
                {
                    Id = Guid.NewGuid(),
                    LastName = "Jones",
                    FirstName = "Alex",
                    Email = "ja@cust.com",
                    IsActive = true,
                }, new Customer
                {
                    Id = Guid.NewGuid(),
                    LastName = "Brooks",
                    FirstName = "Porscha",
                    Email = "pb@cust.com",
                    IsActive = true,
                }, new Customer
                {
                    Id = Guid.NewGuid(),
                    LastName = "Wilson",
                    FirstName = "Jason",
                    Email = "jw@cust.com",
                    IsActive = true,
                }, new Customer
                {
                    Id = Guid.NewGuid(),
                    LastName = "Tanner",
                    FirstName = "Amy",
                    Email = "at@cust.com",
                    IsActive = true,
                }, new Customer
                {
                    Id = Guid.NewGuid(),
                    LastName = "Heathcliff",
                    FirstName = "Gerald",
                    Email = "gh@cust.com",
                    IsActive = true,
                }, new Customer
                {
                    Id = Guid.NewGuid(),
                    LastName = "Elizando",
                    FirstName = "Roberto",
                    Email = "re@cust.com",
                    IsActive = true,
                }, new Customer
                {
                    Id = Guid.NewGuid(),
                    LastName = "Voorhees",
                    FirstName = "Jason",
                    Email = "jv@cust.com",
                    IsActive = true,
                }, new Customer
                {
                    Id = Guid.NewGuid(),
                    LastName = "Kruger",
                    FirstName = "Frederick",
                    Email = "fk@cust.com",
                    IsActive = true,
                }, new Customer
                {
                    Id = Guid.NewGuid(),
                    LastName = "Meyers",
                    FirstName = "Mike",
                    Email = "mm@cust.com",
                    IsActive = true,
                }, new Customer
                {
                    Id = Guid.NewGuid(),
                    LastName = "Smith",
                    FirstName = "Will",
                    Email = "ws@cust.com",
                    IsActive = true,
                }, new Customer
                {
                    Id = Guid.NewGuid(),
                    LastName = "Iverson",
                    FirstName = "Allen",
                    Email = "ai@cust.com",
                    IsActive = true,
                }
            );
    }


}