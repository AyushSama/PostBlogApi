using Microsoft.AspNetCore.Mvc;
using PostBlog.Application.BusinessInterfaces;
using PostBlog.Core.DBEntities;
using PostBlog.Core.ModelEntities;

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

        [HttpPost("post")]
        public ActionResult<string> Post([FromBody] PostModel insertPost )
        {   
            PostsAyush post = new PostsAyush();
            post.title = insertPost.title;
            post.description = insertPost.description;
            post.likes = insertPost.likes;
            post.createdBy = insertPost.createdBy;
            post.postId = 0;
            _postsAyushService.InsertPost(post);
            return Ok("Post Submitted!!");
        }

        [HttpPost("updatepost")]
        public ActionResult<string> UpdatePost([FromBody] PostsAyush updatePost)
        {
            PostsAyush post = new PostsAyush();
            post.title = updatePost.title;
            post.description = updatePost.description;
            post.likes = updatePost.likes;
            post.createdBy = updatePost.createdBy;
            post.postId = updatePost.postId;
            _postsAyushService.UpdatePost(post);
            return Ok("Post Updated!!");
        }


        [HttpPost("deletepost")]
        public ActionResult<string> DeletePost([FromBody] PostsAyush deletePost)
        {
            PostsAyush post = new PostsAyush();
            post.title = deletePost.title;
            post.description = deletePost.description;
            post.likes = deletePost.likes;
            post.createdBy = deletePost.createdBy;
            post.postId = deletePost.postId;
            _postsAyushService.DeletePost(post);
            return Ok("Post Deleted!!");
        }
    }
}
