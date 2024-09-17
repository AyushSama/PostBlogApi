using Microsoft.EntityFrameworkCore;

namespace PostBlog.Core
{
    public class InboxContext(DbContextOptions<InboxContext> options) : DbContext(options)
    {

    }
}
