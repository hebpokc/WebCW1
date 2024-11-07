using DataAccess.DataRepositories.Interfaces;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DataRepositories.Repositories
{
    internal class ReservationRepository : IReservationRepository
    {
        private readonly ApplicationDbContext _context;
        public ReservationRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(Reservation reservation)
        {
            await _context.Reservations.AddAsync(reservation);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteByIdAsync(int id)
        {
            await _context.Reservations
                .Where(r => r.Id == id)
                .ExecuteDeleteAsync();

            await _context.SaveChangesAsync();
        }

        public async Task<Reservation?> GetByIdAsync(int id)
        {
            return await _context.Reservations.FirstOrDefaultAsync(r => r.Id == id);
        }

        public async Task UpdateAsync(Reservation reservation)
        {
            await _context.Reservations
                .Where(r => r.Id == reservation.Id)
                .ExecuteUpdateAsync(x => x
                .SetProperty(x => x.ComputerId, reservation.ComputerId)
                .SetProperty(x => x.UserId, reservation.UserId)
                .SetProperty(x => x.Start, reservation.Start)
                .SetProperty(x => x.End, reservation.End)
                .SetProperty(x => x.Status, reservation.Status));
        }
    }
}
