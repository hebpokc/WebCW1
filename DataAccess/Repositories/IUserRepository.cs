using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public interface IUserRepository
    {
        Task CreateAsync(User user);
        Task GetByIdAsync(User user);
        Task UpdateAsync(User user);
        Task DeleteById (User user);
    }
}
