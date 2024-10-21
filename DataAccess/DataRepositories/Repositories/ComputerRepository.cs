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
    internal class ComputerRepository : IComputerRepository
    {
        private readonly ApplicationDbContext _context;
        public ComputerRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task CreateAsync(Computer computer)
        {
            await _context.Computers.AddAsync(computer);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            await _context.Computers
                .Where(c => c.Id == id)
                .ExecuteDeleteAsync();

            await _context.SaveChangesAsync();
        }

        public async Task<Computer?> GetByIdAsync(int id)
        {
            return await _context.Computers.FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task UpdateAsync(Computer computer)
        {
            await _context.Computers
                .Where(c => c.Id == computer.Id)
                .ExecuteUpdateAsync(x => x
                .SetProperty(x => x.Title, computer.Title)
                .SetProperty(x => x.RAM, computer.RAM)
                .SetProperty(x => x.GPU, computer.GPU)
                .SetProperty(x => x.CPU, computer.CPU)
                .SetProperty(x => x.Price, computer.Price));
        }
    }
}
