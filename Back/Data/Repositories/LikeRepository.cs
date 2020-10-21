using Blog.Model;
using Data.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Data.Repositories
{
    public class LikeRepository : EntityBaseRepository<Like>, ILikeRepository
    {
        public LikeRepository(BlogContext context) : base(context) {}
    }
}