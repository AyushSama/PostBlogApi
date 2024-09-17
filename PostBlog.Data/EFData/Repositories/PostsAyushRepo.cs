using PostBlog.Core;
using PostBlog.Data.EFData.Interfaces;

namespace PostBlog.Data.EFData.Repositories
{
    public class PostsAyushRepo : IPostsAyushRepo
    {   
        public InboxContext _dbContext {  get; }
        public PostsAyushRepo(InboxContext dbContext) {
            _dbContext = dbContext;
        }
    }
}
