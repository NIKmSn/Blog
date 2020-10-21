using Blog.Model;

namespace Data.Abstract
{
    public interface IStoryRepository: IEntityBaseRepository<Story>
    {
        bool IsOwner(string storyId, string userId);
        bool IsInvited(string storyId, string userId);
    }
}