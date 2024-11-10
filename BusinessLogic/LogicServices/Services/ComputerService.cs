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
    internal class ComputerService(IComputerRepository computerRepository) : IComputerService
    {
        public async Task CreateAsync(string title, string gpu, string cpu, int ram, double price)
        {
            var computer = new Computer
            {
                Title = title,
                GPU = gpu,
                CPU = cpu,
                RAM = ram,
                Price = price
            };

            await computerRepository.CreateAsync(computer);
        }

        public async Task DeleteByIdAsync(int id)
        {
            await computerRepository.DeleteByIdAsync(id);
        }

        public async Task<IEnumerable<Computer>> GetAllComputersAsync()
        {
           return await computerRepository.GetAllComputersAsync();
        }

        public async Task<Computer?> GetByIdAsync(int id)
        {
            var computer = await computerRepository.GetByIdAsync(id);

            return computer;
        }

        public async Task UpdateAsync(int id, string title, string gpu, string cpu, int ram, double price)
        {
            var computer = new Computer
            {
                Id = id,
                Title = title,
                GPU = gpu,
                CPU = cpu,
                RAM = ram,
                Price = price
            };

            await computerRepository.UpdateAsync(computer);
        }
    }
}
