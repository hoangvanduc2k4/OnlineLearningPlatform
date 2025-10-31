using OnlineLearningPlatform.Models.Entities.CoursePart;

namespace OnlineLearningPlatform.Repositories.Interfaces
{
    public interface IWishlistRepository
    {
        Task<WishList?> GetAsync(string userId, long courseId);
        Task<List<WishList>> GetByUserIdAsync(string userId);
        Task AddAsync(WishList wishlistItem);
        Task RemoveAsync(WishList wishlistItem);
        Task<bool> ExistsAsync(string userId, long courseId);
    }
}
