using PostBlog.Core.DBEntities;

namespace PostBlog.Application.BusinessInterfaces
{
    public interface IPostsAyushService
    {
        public List<PostsAyush> GetAll();

        public List<PostsAyush> GetPostOfIndividual(int userId);

        public void InsertPost(PostsAyush post);

        public void UpdatePost(PostsAyush post);

        public void DeletePost(PostsAyush post);
    }
}
