using Microsoft.EntityFrameworkCore;
using StaffPortalAPI.Domain.Models.Customers;
using StaffPortalAPI.Domain.Models.Orders;
using StaffPortalAPI.Domain.Models.Products;
using StaffPortalAPI.Domain.Models.Users;
using StaffPortalAPI.Application.Data;
using StaffPortalAPI.Persistence.Repositories;

namespace StaffPortalAPI.Persistence.Data;

public class ApplicationDbContext : DbContext, IApplicationDbContext

{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);


        //modelBuilder.Entity<Product>().HasData(SeedData.GetProducts());
    }

    public DbSet<TestCustomer> TestCustomers { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<TestUser> Users { get; set; }
}
