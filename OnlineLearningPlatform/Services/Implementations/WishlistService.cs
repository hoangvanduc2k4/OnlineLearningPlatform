using OnlineLearningPlatform.Models.Entities.CoursePart;
using OnlineLearningPlatform.Models.Entities.Others;
using OnlineLearningPlatform.Repositories.Interfaces;
using OnlineLearningPlatform.Services.Interfaces;

namespace OnlineLearningPlatform.Services.Implementations
{
    public class WishlistService : IWishlistService
    {
        private readonly IWishlistRepository _wishlistRepository;

        public WishlistService(IWishlistRepository wishlistRepository)
        {
            _wishlistRepository = wishlistRepository;
        }

        public async Task<bool> IsInWishlistAsync(string userId, long courseId)
        {
            return await _wishlistRepository.ExistsAsync(userId, courseId);
        }

        public async Task<bool> ToggleWishlistItemAsync(string userId, long courseId)
        {
            var existingItem = await _wishlistRepository.GetAsync(userId, courseId);

            if (existingItem != null)
            {
                await _wishlistRepository.RemoveAsync(existingItem);
                return false;
            }
            else
            {
                var newItem = new WishList { UserId = userId, CourseId = courseId };
                await _wishlistRepository.AddAsync(newItem);
                return true;
            }
        }
    }
}