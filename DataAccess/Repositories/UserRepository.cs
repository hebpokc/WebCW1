using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    internal class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;
        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(User user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
        }

        public Task DeleteById(User user)
        {
            throw new NotImplementedException();
        }

        public Task GetByIdAsync(User user)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(User user)
        {
            throw new NotImplementedException();
        }
    }
}
