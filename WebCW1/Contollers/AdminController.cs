using BusinessLogic.LogicServices.Interfaces;
using DataAccess.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebCW1.Contollers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AdminController : ControllerBase
    {
        private readonly IAdminService _adminService;

        public AdminController(IAdminService adminService)
        {
            _adminService = adminService;
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create(string userId)
        {
            await _adminService.CreateAsync(userId);
            return Ok(new { message = "Admin successfuly created" });
        }

        [HttpDelete("delete/byId")]
        public async Task<IActionResult> DeleteById(int id)
        {
            await _adminService.DeleteAsync(id);
            return Ok(new { message = "Admin successfuly deleted" });
        }

        [HttpGet("get/byId")]
        public async Task<IActionResult> GetById(int id)
        {
            var admin = await _adminService.GetByIdAsync(id);
            if (admin == null)
            {
                return NotFound();
            }

            return Ok(admin);
        }

        [HttpPut("update/byId")]
        public async Task<IActionResult> UpdateById(int id, string userId)
        {
            await _adminService.UpdateAsync(id, userId);
            return Ok(new { message = "Admin successfuly updated"});
        }
    }
}
