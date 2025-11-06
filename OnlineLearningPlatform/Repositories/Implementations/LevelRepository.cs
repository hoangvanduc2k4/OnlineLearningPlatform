using Microsoft.EntityFrameworkCore;
using OnlineLearningPlatform.Data;
using OnlineLearningPlatform.Models.Entities.CoursePart;
using OnlineLearningPlatform.Repositories.Interfaces;

namespace OnlineLearningPlatform.Repositories.Implementations
{
    public class LevelRepository : BaseRepository<Level>, ILevelRepository
    {
        public LevelRepository(OnlineLearningDBContext context) : base(context)
        {
        }
        public async Task<IEnumerable<Level>> GetAllActiveAsync()
        {
            return await _context.Levels.Where(l => !l.IsDeleted).ToListAsync();
        }


        public async Task<Level?> GetLevelByNameAsync(string levelName)
        {
            if (string.IsNullOrWhiteSpace(levelName))
                return null;

            return await _context.Levels.AsNoTracking()
                .Where(l => l.LevelName.ToLower().Contains(levelName.ToLower()))
                .FirstOrDefaultAsync();
        }

    }

}
