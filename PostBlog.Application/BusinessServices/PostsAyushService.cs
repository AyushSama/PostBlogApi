using DataHelper.HelperClasses;
using PostBlog.Application.BusinessInterfaces;
using PostBlog.Core.DBEntities;
using PostBlog.Data.EFData.Interfaces;

namespace PostBlog.Application.BusinessServices
{
    public class PostsAyushService : IPostsAyushService
    {
        private readonly IPostsAyushRepo _postsAyushRepo;
        public PostsAyushService(IPostsAyushRepo postsAyushRepo)
        {
            _postsAyushRepo = postsAyushRepo;
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
    }
}
