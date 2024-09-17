using System.ComponentModel.DataAnnotations;

namespace PostBlog.Core.DBEntities
{
    public class UsersAyush
    {
        [Key]
        public int userId { get; set; } 
        public string userName { get; set; }
        public string password { get; set; }
    }
}
