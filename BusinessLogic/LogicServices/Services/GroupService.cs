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
        public async Task CreateAsync(string name, string game, DateTime createdDate)
        {
            var group = new Group
            {
                Name = name,
                Game = game,
                CreatedDate = createdDate,
            };

            await groupRepository.CreateAsync(group);
        }

        public async Task DeleteByIdAsync(int id)
        {
            await groupRepository.DeleteByIdAsync(id);
        }

        public async Task<Group?> GetByIdAsync(int id)
        {
            return await groupRepository.GetByIdAsync(id);
        }

        public async Task UpdateAsync(int id, string name, string game, DateTime createdDate)
        {
            var group = new Group
            {
                Id = id,
                Name = name,
                Game = game,
                CreatedDate = createdDate,
            };

            await groupRepository.UpdateAsync(group);
        }
    }
}
