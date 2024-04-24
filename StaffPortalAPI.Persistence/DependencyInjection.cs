using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StaffPortalAPI.Application.Abstractions.Messaging;
using StaffPortalAPI.Application.Data;
using StaffPortalAPI.Application.Products;
using StaffPortalAPI.Domain.Models.Customers;
using StaffPortalAPI.Domain.Models.Orders;
using StaffPortalAPI.Domain.Models.Products;
using StaffPortalAPI.Domain.Models.Users;
using StaffPortalAPI.Persistence.Data;
using StaffPortalAPI.Persistence.Repositories;
using StaffPortalAPI.Persistence.TestData;
using StaffPortalAPI.SharedKernel;


namespace StaffPortalAPI.Persistence;

public static class DependencyInjection
{
    public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
    {
        var assembly = typeof(DependencyInjection).Assembly;

        services.AddDbContext<ApplicationDbContext>(op => op.UseSqlServer(configuration.GetConnectionString("default")));

        services
            .AddTransient<IUserRepository, UserRepository>()
            .AddTransient<IOrderRepository, OrderRepository>()
            .AddTransient<ICustomerRepository, CustomerRepository>()
            .AddTransient<IProductRepository, ProductRepository>()
            .AddTransient<IUnitOfWork, UnitOfWork>();


        services.AddScoped<IApplicationDbContext>(sp =>
            sp.GetRequiredService<ApplicationDbContext>());
        


        return services;
    }


}




