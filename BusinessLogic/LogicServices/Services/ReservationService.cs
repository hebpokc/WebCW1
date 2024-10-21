using BusinessLogic.LogicServices.Interfaces;
using DataAccess.DataRepositories.Interfaces;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.LogicServices.Services
{
    internal class ReservationService(IReservationRepository reservationRepository) : IReservationService
    {
        public async Task CreateAsync(int computerId, string userId, DateTime start, DateTime end, string status)
        {
            var reservation = new Reservation
            {
                ComputerId = computerId,
                UserId = userId,
                Start = start,
                End = end,
                Status = status
            };

            await reservationRepository.CreateAsync(reservation);
        }

        public async Task DeleteAsync(int id)
        {
            await reservationRepository.DeleteAsync(id);
        }

        public Task<Reservation?> GetByIdAsync(int id)
        {
            return reservationRepository.GetByIdAsync(id);
        }

        public async Task UpdateAsync(int computerId, string userId, DateTime start, DateTime end, string status)
        {
            var reservation = new Reservation
            {
                ComputerId = computerId,
                UserId = userId,
                Start = start,
                End = end,
                Status = status
            };

            await reservationRepository.UpdateAsync(reservation);
        }
    }
}
