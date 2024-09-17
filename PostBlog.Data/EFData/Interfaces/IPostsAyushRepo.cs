using DataHelper.EFData.Common.Interfaces;
using PostBlog.Core;
using PostBlog.Core.DBEntities;

namespace PostBlog.Data.EFData.Interfaces
{
    public interface IPostsAyushRepo : IGenericBaseRepo< PostsAyush, InboxContext>
    {
    }
}
