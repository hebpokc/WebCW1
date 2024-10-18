using DataAccess.Models;
using DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    internal class UserService(IUserRepository userRepository) : IUserService
    {
        public async Task DeleteById(int id)
        {
            await userRepository.DeleteById(id);
        }

        public async Task<string> GetByIdAsync(int id)
        {
            var user = await userRepository.GetByIdAsync(id);
            if (user is null)
            {
                throw new Exception("User not founded");
            }

            return user.UserName;
        }

        public async Task UpdateAsync(int id, string username, string email, string password)
        {
            var user = new User
            {
                Id = id.ToString(),
                UserName = username,
                Email = email,
                PasswordHash = password
            };

            await userRepository.UpdateAsync(user);
        }
    }
}
