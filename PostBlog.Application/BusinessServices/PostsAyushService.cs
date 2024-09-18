using DataHelper.HelperClasses;
using PostBlog.Application.BusinessInterfaces;
using PostBlog.Core.DBEntities;
using PostBlog.Data.EFData.Interfaces;
using System.Reflection;

namespace PostBlog.Application.BusinessServices
{
    public class PostsAyushService : IPostsAyushService
    {
        private readonly IPostsAyushRepo _postsAyushRepo;
        public PostsAyushService(IPostsAyushRepo postsAyushRepo)
        {
            _postsAyushRepo = postsAyushRepo;
        }

        public void DeletePost(PostsAyush post)
        {
            _postsAyushRepo.Delete(post);
        }

        public List<PostsAyush> GetAll()
        {
            var result = _postsAyushRepo.ListAll();
            return result;
        }

        public List<PostsAyush> GetPostOfIndividual(int userId)
        {
            BaseSpecification<PostsAyush> spec = new BaseSpecification<PostsAyush>()
            {
                Criteria = a => a.createdBy == userId,
            };
            var result = _postsAyushRepo.List(spec);
            return result;
        }

        public void InsertPost(PostsAyush post)
        {
            _postsAyushRepo.Add(post);
        }

        public void UpdatePost(PostsAyush post)
        {
            string[] props = {};
            _postsAyushRepo.Update(post,props);   
        }
    }
}
