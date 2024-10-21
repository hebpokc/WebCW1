using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.LogicServices.Interfaces
{
    public interface IReservationService
    {
        Task CreateAsync(int computerId, string userId, DateTime start, DateTime end, string status);
        Task<Reservation?> GetByIdAsync(int id);
        Task UpdateAsync(int computerId, string userId, DateTime start, DateTime end, string status);
        Task DeleteAsync(int id);
    }
}
