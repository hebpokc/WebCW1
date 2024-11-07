using BusinessLogic.LogicServices.Interfaces;
using DataAccess.DataRepositories.Interface;
using DataAccess.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.LogicServices.Services
{
    internal class UserService(IUserRepository userRepository) : IUserService
    {

        public async Task DeleteByIdAsync(string id)
        {
            await userRepository.DeleteByIdAsync(id);
        }

        public async Task<User?> GetByIdAsync(string id)
        {
            var user = await userRepository.GetByIdAsync(id);

            return user;
        }

        public async Task<string> GetIdByUsernameAsync(string username)
        {
            var id = await userRepository.GetIdByUsernameAsync(username);

            return id;
        }
    }
}
