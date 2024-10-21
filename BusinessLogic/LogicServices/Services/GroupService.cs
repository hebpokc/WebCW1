using BusinessLogic.LogicServices.Interfaces;
using DataAccess.DataRepositories.Interfaces;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.LogicServices.Services
{
    internal class GroupService(IGroupRepository groupRepository) : IGroupService
    {
        public async Task CreateAsync(string userId, string name, string game, DateTime joindate)
        {
            var group = new Group
            {
                UserId = userId,
                Name = name,
                Game = game,
                JoinDate = joindate,
            };

            await groupRepository.CreateAsync(group);
        }

        public async Task DeleteAsync(int id)
        {
            await groupRepository.DeleteAsync(id);
        }

        public async Task<Group?> GetByIdAsync(int id)
        {
            return await groupRepository.GetByIdAsync(id);
        }

        public async Task UpdateAsync(string userId, string name, string game, DateTime joindate)
        {
            var group = new Group
            {
                UserId = userId,
                Name = name,
                Game = game,
                JoinDate = joindate,
            };

            await groupRepository.UpdateAsync(group);
        }
    }
}
