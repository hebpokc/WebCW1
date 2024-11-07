using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Group = DataAccess.Models.Group;

namespace BusinessLogic.LogicServices.Interfaces
{
    public interface IGroupService
    {
        Task CreateAsync(string name, string game, DateTime createdDate);
        Task<Group?> GetByIdAsync(int id);
        Task UpdateAsync(int id, string name, string game, DateTime createdDate);
        Task DeleteByIdAsync(int id);
    }
}
