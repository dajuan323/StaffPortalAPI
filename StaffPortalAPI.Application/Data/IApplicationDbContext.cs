using Microsoft.EntityFrameworkCore;
using StaffPortalAPI.Domain.Models.Customers;
using StaffPortalAPI.Domain.Models.Orders;
using StaffPortalAPI.Domain.Models.Products;
using StaffPortalAPI.Domain.Models.Users;

namespace StaffPortalAPI.Application.Data;

public interface IApplicationDbContext
{
    public DbSet<TestCustomer> TestCustomers { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<TestUser> Users { get; set; }
}