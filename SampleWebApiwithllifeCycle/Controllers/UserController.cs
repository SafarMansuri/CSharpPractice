using Microsoft.AspNetCore.Mvc;
using SampleWebApiwithllifeCycle.Services;

namespace SampleWebApiwithllifeCycle.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly UserService _userService;

        public UserController(UserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllUsers()
        {
            var users = await _userService.GetallUsers();
            return Ok(users);
        }
    }
}
