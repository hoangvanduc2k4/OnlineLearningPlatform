using Microsoft.EntityFrameworkCore;
using OnlineLearningPlatform.Data;
using OnlineLearningPlatform.Models.Entities.CoursePart;
using OnlineLearningPlatform.Repositories.Implementations;
using OnlineLearningPlatform.Repositories.Interfaces;
using X.PagedList;

namespace OnlineLearningPlatform.Repositories
{
    public class CoursesRepository : BaseRepository<Course>, ICourseRepository
    {
        private readonly OnlineLearningDBContext _context;
        public CoursesRepository(OnlineLearningDBContext context) : base(context)
        {
            _context = context;
        }

        public IQueryable<Course> GetAllCoursesQueryable()
        {
            return _context.Set<Course>()
                .Include(c => c.CourseImageUrls)
                .Include(c => c.CourseCategories).ThenInclude(cc => cc.Category)
                .Include(c => c.Level)
                .Include(c => c.CreatorUser)
                .AsQueryable();
        }

        public async Task<Course?> GetByIdWithDetailsAsync(long id)
        {
            return await _context.Set<Course>()
                .Include(c => c.CourseImageUrls)
                .Include(c => c.CourseCategories).ThenInclude(cc => cc.Category)
                .Include(c => c.Modules)
                .ThenInclude(m => m.Lessons)
                .Include(c => c.Modules)
                .ThenInclude(m => m.Quizzes)
                .Include(c => c.Level)
                .Include(c => c.CreatorUser)
                .FirstOrDefaultAsync(c => c.CourseId == id);
        }

        public async Task<IEnumerable<Course>> GetAllByMentorIdAsync(string mentorId)
        {
            return await _dbSet
                .Where(c => c.MentorId == mentorId && c.Status != Enums.CourseStatus.Deleted)
                .Include(c => c.Level)
                .ToListAsync();
        }

        public async Task<Course?> GetByIdAndMentorIdAsync(long courseId, string mentorId)
        {
            return await _dbSet
                .FirstOrDefaultAsync(c => c.CourseId == courseId && c.MentorId == mentorId && c.Status != Enums.CourseStatus.Deleted);
        }

        public async Task<Course?> GetCourseForEditAsync(long courseId, string mentorId)
        {
            return await _context.Courses
                .Include(c => c.CourseCategories)
                .Include(c => c.CourseImageUrls)
                .Include(c => c.Level)
                .FirstOrDefaultAsync(c => c.CourseId == courseId && c.MentorId == mentorId);
        }
    }
}