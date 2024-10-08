﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PostBlog.Core.DBEntities
{
    public class PostsAyush
    {
        [Key]
        public int postId { get; set; }
        public string title { get; set;}
        public string description { get; set;}
        public int likes { get; set;}

        [ForeignKey("UsersAyush")]
        public int createdBy { get; set; }

    }
}
