using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostBlog.Core.ModelEntities
{
    public class PostModel
    {
        public string title { get; set; }
        public string description { get; set; }
        public int likes { get; set; }
        public int createdBy { get; set; }
    }
}
