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
    internal class AdminRepository : IAdminRepository
    {
        private readonly ApplicationDbContext _context;
        public AdminRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task CreateAsync(Admin admin)
        {
            await _context.Admins.AddAsync(admin);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            await _context.Admins
                .Where(a => a.Id == id)
                .ExecuteDeleteAsync();
            await _context.SaveChangesAsync();
        }

        public async Task<Admin?> GetByIdAsync(int id)
        {
            return await _context.Admins.FirstOrDefaultAsync(a => a.Id == id);
        }

        public async Task UpdateAsync(Admin admin)
        {
            await _context.Admins
                .Where(a => a.Id == admin.Id)
                .ExecuteUpdateAsync(a => a
                .SetProperty(x => x.UserId, admin.UserId));
        }
    }
}
