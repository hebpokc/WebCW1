using BusinessLogic.LogicServices.Interfaces;
using DataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;

namespace WebCW1.Contollers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ComputerController : ControllerBase
    {
        private readonly IComputerService _computerService;

        public ComputerController(IComputerService computerService)
        {
            _computerService = computerService;
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create(string title, string gpu, string cpu, int ram, double price)
        {
            await _computerService.CreateAsync(title, gpu, cpu, ram, price);
            return Ok( new { message = "Computer successfuly created" });
        }

        [HttpDelete("delete/byId")]
        public async Task<IActionResult> DeleteById(int id)
        {
            await _computerService.DeleteByIdAsync(id);
            return Ok(new { message = "Computer successfuly deleted" });
        }

        [HttpGet("get/byId")]
        public async Task<IActionResult> GetById(int id)
        {
            var computer = await _computerService.GetByIdAsync(id);
            if (computer == null)
            {
                return NotFound();
            }

            return Ok(computer);
        }

        [HttpGet("get/allComputers")]
        public async Task<ActionResult<IEnumerable<Computer>>> GetComputers()
        {
            return Ok(await _computerService.GetAllComputersAsync());
        }

        [HttpPut("update/byId")]
        public async Task<IActionResult> UpdateById(int id, string title, string gpu, string cpu, int ram, double price)
        {
            await _computerService.UpdateAsync(id, title, gpu, cpu, ram, price);
            return Ok(new { message = "Computer successfuly updated"});
        }
    }
}
