using PostBlog.Core;
using PostBlog.Data.EFData.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
