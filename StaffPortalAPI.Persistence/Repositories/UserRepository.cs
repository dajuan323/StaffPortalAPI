using Microsoft.EntityFrameworkCore;
using StaffPortalAPI.Domain.Models.Users;
using StaffPortalAPI.Persistence.Data;


namespace StaffPortalAPI.Persistence.Repositories
{
    internal sealed class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }


        public async Task<bool> IsEmailUniqueAsync(string email)
        {
            return !await _context.Users.AnyAsync(u => u.Email.Value == email);
        }

        public void Add(TestUser user)
        {
            _context.Add(user);
        }

    }
}
