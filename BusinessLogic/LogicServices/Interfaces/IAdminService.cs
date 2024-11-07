using DataAccess.Models;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.LogicServices.Interfaces
{
    public interface IAdminService
    {
        Task CreateAsync(string userId);
        Task<Admin?> GetByIdAsync(int id);
        Task UpdateAsync(int id, string userId);
        Task DeleteByIdAsync(int id);
    }
}
