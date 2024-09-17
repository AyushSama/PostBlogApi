using PostBlog.Core;
using PostBlog.Data.EFData.Interfaces;

namespace PostBlog.Data.EFData.Repositories
{
    public class UsersAyushRepo : IUsersAyushRepo
    {
        public InboxContext _dbContext { get; }

        public UsersAyushRepo(InboxContext dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
