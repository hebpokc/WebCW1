using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DataRepositories.Interface
{
    public interface IComputerRepository
    {
        Task CreateAsync(Computer computer);
        Task<Computer?> GetByIdAsync(int id);
        Task UpdateAsync(Computer computer);
        Task DeleteAsync(int id);
    }
}
