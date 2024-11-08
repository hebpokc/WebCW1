using DataAccess.DataRepositories.Interface;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DataRepositories.Repositories
{
    internal class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;
        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddUserToGroupAsync(string id, int groupId)
        {
            var user = await _context.Users
                .FirstOrDefaultAsync(u => u.Id == id);
            var group = await _context.Groups
                .FirstOrDefaultAsync(g => g.Id == groupId);

            if (user != null || group != null)
            {
                user.GroupId = groupId;
            }

            await _context.SaveChangesAsync();
        }

        public async Task DeleteByIdAsync(string id)
        {
            await _context.Users
                .Where(u => u.Id == id)
                .ExecuteDeleteAsync();
            await _context.SaveChangesAsync();
        }

        public async Task<User?> GetByIdAsync(string id)
        {
            return await _context.Users
                .FirstOrDefaultAsync(u => u.Id == id);
        }

        public async Task<string> GetIdByUsernameAsync(string username)
        {
            var user = await _context.Users
                .FirstOrDefaultAsync(u => u.UserName == username);

            return user?.Id ?? string.Empty;
        }

        public async Task RemoveUserFromGroupAsync(string id, int groupId)
        {
            var userToRemove = await _context.Users
                .FirstOrDefaultAsync(u => u.Id == id);
            var groupToRemoveFrom = await _context.Groups
                .FirstOrDefaultAsync(g => g.Id == groupId);

            if (userToRemove != null || groupToRemoveFrom != null)
            {
                userToRemove.GroupId = null;
            }

            await _context.SaveChangesAsync();
        }
    }
}
