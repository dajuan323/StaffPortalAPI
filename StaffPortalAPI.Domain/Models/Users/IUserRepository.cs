using StaffPortalAPI.Domain.Models.Customers;
using StaffPortalAPI.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffPortalAPI.Domain.Models.Users;

public interface IUserRepository
{
    //Task<TestUser?> GetByEmailAsync(Email email, CancellationToken cancellationToken = default);

    Task<bool> IsEmailUniqueAsync(string email);
    void Add(TestUser user);
}
