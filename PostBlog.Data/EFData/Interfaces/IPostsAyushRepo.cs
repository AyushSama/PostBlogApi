using DataHelper.EFData.Common.Interfaces;
using PostBlog.Core;
using PostBlog.Core.DBEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostBlog.Data.EFData.Interfaces
{
    public interface IPostsAyushRepo : IGenericBaseRepo< PostsAyush, InboxContext>
    {
    }
}
