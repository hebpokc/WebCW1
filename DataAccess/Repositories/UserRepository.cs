using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
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

        public async Task DeleteById(int id)
        {
            await _context.Users
                .Where(u => u.Id == id.ToString())
                .ExecuteDeleteAsync();
            await _context.SaveChangesAsync();
        }

        public async Task<User?> GetByIdAsync(int id)
        {
            return await _context.Users
                .FirstOrDefaultAsync(u => u.Id == id.ToString());
        }

        public async Task UpdateAsync(User user)
        {
            await _context.Users
                .Where(u => u.Id == user.Id)
                .ExecuteUpdateAsync(u => u
                .SetProperty(x => x.UserName, user.UserName)
                .SetProperty(x => x.Email, user.Email)
                .SetProperty(x => x.PasswordHash, user.PasswordHash));
        }
    }
}
