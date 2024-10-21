using BusinessLogic.LogicServices.Interfaces;
using DataAccess.DataRepositories.Interface;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.LogicServices.Services
{
    internal class UserService(IUserRepository userRepository) : IUserService
    {
        public async Task DeleteById(int id)
        {
            await userRepository.DeleteById(id);
        }

        public async Task<User?> GetByIdAsync(int id)
        {
            var user = await userRepository.GetByIdAsync(id);

            return user;
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
