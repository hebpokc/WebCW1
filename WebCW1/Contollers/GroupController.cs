using BusinessLogic.LogicServices.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WebCW1.Contollers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GroupController : ControllerBase
    {
        private readonly IGroupService _groupService;

        public GroupController(IGroupService groupService)
        {
            _groupService = groupService;
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create(string name, string game, DateTime createdDate)
        {
            await _groupService.CreateAsync(name, game, createdDate);
            return Ok(new { message = "Group successfuly created" });
        }

        [HttpDelete("delete/byId")]
        public async Task<IActionResult> DeleteById(int id)
        {
            await _groupService.DeleteByIdAsync(id);
            return Ok(new { message = "Group seccessfuly deleted" });
        }

        [HttpGet("get/byId")]
        public async Task<IActionResult> GetById(int id)
        {
            var group = await _groupService.GetByIdAsync(id);
            if (group == null)
            {
                return NotFound();
            }

            return Ok(group);
        }

        [HttpPut("update/byId")]
        public async Task<IActionResult> UpdateById(int id, string name, string game, DateTime joinDate)
        {
            await _groupService.UpdateAsync(id, name, game, joinDate);
            return Ok(new { message = "Group successfuly updated" });
        }
    }
}
