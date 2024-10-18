using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public interface IUserService
    {
        Task<string> GetByIdAsync(int id);
        Task DeleteById(int id);
        Task UpdateAsync(int id, string username, string email, string password);
    }
}
