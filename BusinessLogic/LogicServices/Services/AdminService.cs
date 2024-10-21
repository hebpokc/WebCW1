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
    internal class AdminService(IAdminRepository adminRepository) : IAdminService
    {
        public async Task CreateAsync(string userId)
        {
            var admin = new Admin
            {
                UserId = userId
            };

            await adminRepository.CreateAsync(admin);
        }

        public async Task DeleteAsync(int id)
        {
            await adminRepository.DeleteAsync(id);
        }

        public async Task<Admin?> GetByIdAsync(int id)
        {
            var admin = await adminRepository.GetByIdAsync(id);

            return admin;
        }

        public async Task UpdateAsync(string userId)
        {
            var admin = new Admin
            {
                UserId = userId
            };

            await adminRepository.UpdateAsync(admin);
        }
    }
}
