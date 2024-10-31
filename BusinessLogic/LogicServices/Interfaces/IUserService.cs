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
        Task<User?> GetByIdAsync(string id);
        Task DeleteById(string id);
        Task UpdateAsync(string username, string email, string password);
    }
}
