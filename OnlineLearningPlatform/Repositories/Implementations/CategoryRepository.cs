using Microsoft.EntityFrameworkCore;
using OnlineLearningPlatform.Data;
using OnlineLearningPlatform.Models.Entities.CoursePart;
using OnlineLearningPlatform.Repositories.Interfaces;

namespace OnlineLearningPlatform.Repositories.Implementations
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(OnlineLearningDBContext context) : base(context)
        {

        }
        public async Task<IEnumerable<Category>> GetAllActiveAsync()
        {
            return await _context.Categories.Where(c => !c.IsDeleted).ToListAsync();
        }

        public async Task<Category?> GetCategoryByNameAsync(string categoryName)
        {
            if (string.IsNullOrWhiteSpace(categoryName))
                return null;

            return await _context.Categories.AsNoTracking()
                .FirstOrDefaultAsync(c => c.CategoryName.ToLower() == categoryName.ToLower());
        }
    }

}
