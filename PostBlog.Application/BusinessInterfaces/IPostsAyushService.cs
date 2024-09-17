using PostBlog.Core.DBEntities;

namespace PostBlog.Application.BusinessInterfaces
{
    public interface IPostsAyushService
    {
        public List<PostsAyush> GetAll();
    }
}
