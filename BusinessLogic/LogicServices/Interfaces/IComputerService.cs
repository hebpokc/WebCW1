using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.LogicServices.Interfaces
{
    
    public interface IComputerService
    {
        Task CreateAsync(string title, string gpu, string cpu, int ram, double price);
        Task<Computer?> GetByIdAsync(int id);
        Task UpdateAsync(int id, string title, string gpu, string cpu, int ram, double price);
        Task DeleteAsync(int id);
    }
}
