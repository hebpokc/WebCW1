using BusinessLogic.LogicServices.Interfaces;
using DataAccess.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace WebCW1.Contollers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly UserManager<User> _userManager;
        private readonly IConfiguration _configuration;

        public UserController(IUserService userService, UserManager<User> userManager, IConfiguration configuration)
        {
            _userService = userService;
            _userManager = userManager;
            _configuration = configuration;
        }

        [HttpGet("get/byId")]
        public async Task<IActionResult> GetById(string id)
        {
            var user = await _userService.GetByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        [HttpGet("get/usernameById")]
        public async Task<IActionResult> GetIdByUsername(string username)
        {
            var id = await _userService.GetIdByUsernameAsync(username);

            return Ok(id);
        }

        [HttpDelete("delete/byId")]
        public async Task<IActionResult> DeleteById(string id)
        {
            await _userService.DeleteByIdAsync(id);
            return Ok(new { message = "User successfuly deleted"});
        }

        [HttpPut("update/byId")]
        public async Task<IActionResult> UpdateById(string id ,string username, string email, string password)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            user.UserName = username;
            user.Email = email;

            if (!string.IsNullOrWhiteSpace(password))
            {
                var removePasswordResult = await _userManager.RemovePasswordAsync(user);
                if (!removePasswordResult.Succeeded)
                {
                    BadRequest("Failed to remove existing password");
                }

                var addPasswordResult = await _userManager.AddPasswordAsync(user, password);
                if (!addPasswordResult.Succeeded)
                {
                    BadRequest("Failed to add new password");
                }
            }

            var updateResult = await _userManager.UpdateAsync(user);
            if (!updateResult.Succeeded)
            {
                BadRequest("Failed to update user");
            }

            return Ok(user);
        }
    }
}
