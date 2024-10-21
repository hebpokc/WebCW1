using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DataRepositories.Interfaces
{
    public interface IReservationRepository
    {
        Task CreateAsync(Reservation reservation);
        Task<Reservation?> GetByIdAsync(int id);
        Task UpdateAsync(Reservation reservation);
        Task DeleteAsync(int id);
    }
}
