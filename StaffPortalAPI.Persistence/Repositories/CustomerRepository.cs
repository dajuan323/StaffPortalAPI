using Microsoft.EntityFrameworkCore;
using StaffPortalAPI.Domain.Models.Customers;
using StaffPortalAPI.Persistence.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffPortalAPI.Persistence.Repositories;

internal sealed class CustomerRepository : ICustomerRepository
{
    private readonly ApplicationDbContext _context;

    public CustomerRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public Task<TestCustomer?> GetByIdAsync(TestCustomerId id)
    {
        return _context.TestCustomers
            .SingleOrDefaultAsync(c => c.Id == id);
    }

    public async Task<bool> IsEmailUniqueAsync(string email)
    {
        var emailValue = email ?? string.Empty;
        var existingEmails = await _context.TestCustomers
            .Select(c => c.Email.Value)
            .Where(existingEmail => existingEmail == emailValue)
            .ToListAsync();

        // Check if any matching emails were found
        return !existingEmails.Any();
    }

    public void Add(TestCustomer customer)
    {
        _context.Add(customer);
    }
}
