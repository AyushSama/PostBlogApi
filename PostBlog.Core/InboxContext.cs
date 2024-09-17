using Microsoft.EntityFrameworkCore;
using PostBlog.Core.DBEntities;

namespace PostBlog.Core
{
    public class InboxContext(DbContextOptions<InboxContext> options) : DbContext(options)
    {
        public DbSet<UsersAyush> UsersAyush { get; set; }

        public DbSet<PostsAyush> PostsAyush { get; set; }
    }
}
