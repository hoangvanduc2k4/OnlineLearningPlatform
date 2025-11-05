using Microsoft.EntityFrameworkCore;
using OnlineLearningPlatform.Data;
using OnlineLearningPlatform.Models.Entities.CoursePart;
using OnlineLearningPlatform.Models.Entities.Others;
using OnlineLearningPlatform.Repositories.Interfaces;

namespace OnlineLearningPlatform.Repositories.Implementations
{
    public class WishlistRepository : IWishlistRepository
    {
        private readonly OnlineLearningDBContext _context;

        public WishlistRepository(OnlineLearningDBContext context)
        {
            _context = context;
        }

        public async Task<WishList?> GetAsync(string userId, long courseId)
        {
            return await _context.WishLists.FirstOrDefaultAsync(w => w.UserId == userId && w.CourseId == courseId);
        }

        public async Task<List<WishList>> GetByUserIdAsync(string userId)
        {
            return await _context.WishLists
                .Where(w => w.UserId == userId)
                .Include(w => w.Course)
                    .ThenInclude(c => c.CreatorUser)
                .Include(w => w.Course)
                    .ThenInclude(c => c.CourseImageUrls)
                .ToListAsync();
        }
        public async Task AddAsync(WishList wishlistItem)
        {
            await _context.WishLists.AddAsync(wishlistItem);
            await _context.SaveChangesAsync();
        }

        public async Task RemoveAsync(WishList wishlistItem)
        {
            _context.WishLists.Remove(wishlistItem);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> ExistsAsync(string userId, long courseId)
        {
            return await _context.WishLists
                .AnyAsync(w => w.UserId == userId && w.CourseId == courseId);
        }
    }
}