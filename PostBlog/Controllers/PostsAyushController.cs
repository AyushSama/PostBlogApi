using Microsoft.AspNetCore.Mvc;
using PostBlog.Application.BusinessInterfaces;
using PostBlog.Core.DBEntities;

namespace PostBlog.Controllers
{
    [ApiController] // Add this to specify that it's an API controller
    [Route("api/[controller]")] // Route convention for API controllers
    public class PostsAyushController : Controller
    {
        private readonly IPostsAyushService _postsAyushService;

        public PostsAyushController(IPostsAyushService postsAyushService)
        {
            _postsAyushService = postsAyushService;
        }

        [HttpGet("list")]
        public ActionResult<List<PostsAyush>> GetList()
        {
            var result = _postsAyushService.GetAll();
            return Ok(result);
        }

        [HttpGet("getposts")]
        public ActionResult<List<PostsAyush>> GetPostOfIndividual(int userId)
        {
            var result = _postsAyushService.GetPostOfIndividual(userId);
            return Ok(result);
        }
    }
}
