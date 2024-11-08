using BusinessLogic.LogicServices.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WebCW1.Contollers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserGroupController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserGroupController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("addUserToGroup")]
        public async Task<IActionResult> AddUserToGroup(string id, int groupId)
        {
            await _userService.AddUserToGroupAsync(id, groupId);
            return Ok(new { message = "User successfuly added to group" });
        }

        [HttpDelete("deleteUserFromGroup")]
        public async Task<IActionResult> RemoveUserFromGroup(string id, int groupId)
        {
            await _userService.RemoveUserFromGroupAsync(id, groupId);
            return Ok(new { message = "User successfuly removed from group" });
        }
    }
}
