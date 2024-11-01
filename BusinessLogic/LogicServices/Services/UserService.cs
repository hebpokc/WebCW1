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

        public async Task DeleteAsync(string id)
        {
            await userRepository.DeleteById(id);
        }

        public async Task<User?> GetByIdAsync(string id)
        {
            var user = await userRepository.GetByIdAsync(id);

            return user;
        }
    }
}
