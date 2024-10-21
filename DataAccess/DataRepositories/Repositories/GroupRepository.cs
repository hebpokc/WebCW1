using DataAccess.DataRepositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using DataAccess.Models;
using Group = DataAccess.Models.Group;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.DataRepositories.Repositories
{
    internal class GroupRepository : IGroupRepository
    {
        private readonly ApplicationDbContext _context;
        public GroupRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task CreateAsync(Group group)
        {
            await _context.Groups.AddAsync(group);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            await _context.Groups
                .Where(g => g.Id == id)
                .ExecuteDeleteAsync();

            await _context.SaveChangesAsync();
        }

        public async Task<Group?> GetByIdAsync(int id)
        {
            return await _context.Groups.FirstOrDefaultAsync(g => g.Id == id);
        }

        public async Task UpdateAsync(Group group)
        {
            await _context.Groups
                .Where(g => g.Id == group.Id)
                .ExecuteUpdateAsync(x => x
                .SetProperty(x => x.UserId, group.UserId)
                .SetProperty(x => x.Name, group.Name)
                .SetProperty(x => x.Game, group.Game)
                .SetProperty(x => x.JoinDate, group.JoinDate));
        }
    }
}
