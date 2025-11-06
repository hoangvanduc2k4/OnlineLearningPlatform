using OnlineLearningPlatform.Data;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OnlineLearningPlatform.Data;
using OnlineLearningPlatform.Models.Entities.CoursePart;
using OnlineLearningPlatform.Repositories.Interfaces;

namespace OnlineLearningPlatform.Repositories.Implementations
{
    public class LessonRepository : BaseRepository<Lesson>, ILessonRepository
    {

        public LessonRepository(OnlineLearningDBContext context) : base(context) { }

        public async Task<Lesson?> GetLessonByIdAsync(long lessonId)
        {
            return await _dbSet.FirstOrDefaultAsync(l => l.LessonId == lessonId);
        }

        public async Task<IEnumerable<Lesson>> GetLessonsByModuleIdAsync(long moduleId)
        {
            return await _dbSet.Where(l => l.ModuleId == moduleId).ToListAsync();
        }
    }
}
