using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DataRepositories.Interface
{
    public interface IUserRepository
    {
        Task<User?> GetByIdAsync(string id);
        Task UpdateAsync(User user);
        Task DeleteById(string id);
    }
}
