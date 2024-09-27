using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Moodle_with_MongoDB.Service;
using Moodle_with_MongoDB.WebModel;

namespace Moodle_with_MongoDB.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var users = _userService.GetAll();
            return Ok(users);
        }

        [HttpPost]
        public IActionResult Create(CreateUserRequest request)
        {
            _userService.Create(request);
            return Ok();

        }
    }
}
