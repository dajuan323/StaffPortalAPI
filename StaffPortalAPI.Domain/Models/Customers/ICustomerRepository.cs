using StaffPortalAPI.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffPortalAPI.Domain.Models.Customers;

public interface ICustomerRepository
{
    Task<TestCustomer?> GetByIdAsync(TestCustomerId id);

    Task<bool> IsEmailUniqueAsync(string email);
    void Add(TestCustomer customer);
}
