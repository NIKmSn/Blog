using System.Collections.Generic;
using Blog.Model;

namespace Data.Abstract
{
    public interface IShareRepository : IEntityBaseRepository<Share>
    {
        List<Story> StoriesSharedToUser(string userId);
    }
}