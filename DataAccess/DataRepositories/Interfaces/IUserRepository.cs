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
        Task DeleteByIdAsync(string id);
        Task<string> GetIdByUsernameAsync(string username);
        Task AddUserToGroupAsync(string id, int groupId);
        Task RemoveUserFromGroupAsync(string id, int groupId);
        Task<IEnumerable<User>> GetAllUsersAsync();
    }
}
