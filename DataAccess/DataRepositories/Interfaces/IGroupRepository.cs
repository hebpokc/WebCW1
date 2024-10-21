using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DataAccess.DataRepositories.Interfaces
{
    public interface IGroupRepository
    {
        Task CreateAsync(Group group);
        Task<Group?> GetByIdAsync(int id);
        Task UpdateAsync(Group group);
        Task DeleteAsync(int id);
    }
}
