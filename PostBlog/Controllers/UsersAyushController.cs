using Microsoft.AspNetCore.Mvc;
using PostBlog.Application.BusinessInterfaces;
using PostBlog.Core.DBEntities;
using PostBlog.Core.ModelEntities;

namespace PostBlog.Controllers
{
    [ApiController] // Add this to specify that it's an API controller
    [Route("api/[controller]")] // Route convention for API controllers
    public class UsersAyushController : Controller // Derive from ControllerBase
    {
        private readonly IUsersAyushService _usersAyushService;

        public UsersAyushController(IUsersAyushService usersAyushService)
        {
            _usersAyushService = usersAyushService;
        }

        [HttpGet("list")]
        public ActionResult<List<UsersAyush>> GetList() // Use ActionResult for proper HTTP responses
        {
            var list = _usersAyushService.GetAll();
            return Ok(list); // Return 200 OK with the list
        }


        [HttpGet("getuser")]
        public ActionResult<UsersAyush> GetUser(string username,string password)
        {
            var result = _usersAyushService.GetSingle(username, password);
            return Ok(result);
        }

        [HttpPost("adduser")]
        public ActionResult<string> AddUser([FromBody] UserModel addUser)
        {
            UsersAyush user = new UsersAyush()
            {
                userId = 0,
                userName = addUser.userName,
                password = addUser.password
            };
            _usersAyushService.InsertUser(user);
            return Ok("User Added Successfullyy!!");
        }
    }
}
