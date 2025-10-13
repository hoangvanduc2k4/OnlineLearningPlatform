using Microsoft.EntityFrameworkCore;
using OnlineLearningPlatform.Data;
using OnlineLearningPlatform.Models.Entities.CoursePart;
using OnlineLearningPlatform.Models.Entities.Others;
using OnlineLearningPlatform.Repositories.Interfaces;

namespace OnlineLearningPlatform.Repositories
{
    public class CourseRepository : BaseRepository<Course>, ICourseRepository
    {
        public CourseRepository(OnlineLearningDBContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Course>> GetAllByMentorIdAsync(string mentorId)
        {
            return await _dbSet
                             .Where(c => c.MentorId == mentorId && c.DeletedAt == null && c.Status == Enums.CourseStatus.Approved)
                             .Include(c => c.Level)
                             .ToListAsync();
        }

        public async Task<Course?> GetByIdAndMentorIdAsync(long courseId, string mentorId)
        {
            return await _dbSet
                             .FirstOrDefaultAsync(c => c.CourseId == courseId && c.MentorId == mentorId && c.DeletedAt == null);
        }
    }
}
