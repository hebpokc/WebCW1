using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DataRepositories.Interface
{
    public interface IAdminRepository
    {
        Task CreateAsync(Admin admin);
        Task<Admin?> GetByIdAsync(int id);
        Task UpdateAsync(Admin admin);
        Task DeleteAsync(int id);
    }
}
