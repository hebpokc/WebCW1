using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.LogicServices.Interfaces
{
    public interface IUserService
    {
        Task<User?> GetByIdAsync(int id);
        Task DeleteById(int id);
        Task UpdateAsync(int id, string username, string email, string password);
    }
}
