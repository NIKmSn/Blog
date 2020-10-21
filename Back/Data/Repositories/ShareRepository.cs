using System.Collections.Generic;
using System.Linq;
using Blog.Model;
using Data.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Data.Repositories
{
    public class ShareRepository : EntityBaseRepository<Share>, IShareRepository
    {
      public ShareRepository(BlogContext context) : base(context) {}

      public List<Story> StoriesSharedToUser(string userId)
      {
          return _context.Set<Share>()
              .Include(s => s.Story.Owner)
              .Where(s => s.UserId == userId)
              .Select(s => s.Story)
              .ToList();
        }
  }
}