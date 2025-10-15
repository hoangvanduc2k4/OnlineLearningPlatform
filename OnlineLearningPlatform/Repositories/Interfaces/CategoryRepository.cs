using Microsoft.EntityFrameworkCore;
using OnlineLearningPlatform.Data;
using OnlineLearningPlatform.Models.Entities.CoursePart;

namespace OnlineLearningPlatform.Repositories.Interfaces
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
    }

}
