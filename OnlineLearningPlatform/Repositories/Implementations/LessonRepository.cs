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
        public async Task<Lesson?> GetLessonWithCourseAsync(long lessonId, string mentorId)
        {
            return await _dbSet
                .Include(l => l.Module)
                    .ThenInclude(m => m.Course)
                .FirstOrDefaultAsync(l => l.LessonId == lessonId && l.Module.Course.Creator == mentorId);
        }
    }
}
