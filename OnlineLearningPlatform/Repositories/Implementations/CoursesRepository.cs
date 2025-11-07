using Microsoft.EntityFrameworkCore;
using OnlineLearningPlatform.Data;
using OnlineLearningPlatform.Enums;
using OnlineLearningPlatform.Models.Entities.CoursePart;
using OnlineLearningPlatform.Repositories.Implementations;
using OnlineLearningPlatform.Repositories.Interfaces;
using X.PagedList;
using X.PagedList.Extensions;

namespace OnlineLearningPlatform.Repositories
{
    public class CoursesRepository : BaseRepository<Course>, ICourseRepository
    {
        private new readonly OnlineLearningDBContext _context;
        public CoursesRepository(OnlineLearningDBContext context) : base(context)
        {
            _context = context;
        }

        public IQueryable<Course> GetCoursesQuery()
        {
            return _context.Set<Course>()
                .AsNoTracking()
                .Include(c => c.CourseImageUrls)
                .Include(c => c.CourseCategories).ThenInclude(cc => cc.Category)
                .Include(c => c.Level)
                .Include(c => c.CreatorUser);
        }

        public async Task<Course?> GetByIdWithDetailsAsync(long id)
        {
            return await _context.Set<Course>()
                .Include(c => c.CourseImageUrls)
                .Include(c => c.CourseCategories).ThenInclude(cc => cc.Category)
                .Include(c => c.Modules).ThenInclude(m => m.Lessons)
                .Include(c => c.Modules).ThenInclude(m => m.Quizzes)
                .Include(c => c.Level)
                .Include(c => c.CreatorUser)
                .FirstOrDefaultAsync(c => c.CourseId == id);
        }

        public async Task<IEnumerable<Course>> GetAllByMentorIdAsync(string mentorId)
        {
            return await _dbSet
                .Where(c => c.Creator == mentorId && c.Status != CourseStatus.Deleted)
                .Include(c => c.Level)
                .ToListAsync();
        }

        public async Task<Course?> GetByIdAndMentorIdAsync(long courseId, string mentorId)
        {
            return await _dbSet
                .FirstOrDefaultAsync(c => c.CourseId == courseId && c.Creator == mentorId && c.Status != CourseStatus.Deleted);
        }

        public async Task<Course?> GetCourseForEditAsync(long courseId, string mentorId)
        {
            return await _context.Courses
                .Include(c => c.CourseCategories)
                .Include(c => c.CourseImageUrls)
                .Include(c => c.Level)
                .FirstOrDefaultAsync(c => c.CourseId == courseId && c.Creator == mentorId);
        }

        public async Task<Course?> GetCourseForReviewAsync(long courseId)
        {
            return await _context.Courses
                .Include(c => c.CourseCategories).ThenInclude(cc => cc.Category)
                .Include(c => c.CourseImageUrls)
                .Include(c => c.Level)
                .Include(c => c.CreatorUser)
                .FirstOrDefaultAsync(c => c.CourseId == courseId);
        }

        public async Task<IPagedList<Course>> GetCoursesByStatusPagedAsync(CourseStatus status, int pageNumber, int pageSize)
        {
            var query = _context.Courses
                                .Include(c => c.CreatorUser)
                                .Where(c => c.Status == status)
                                .OrderByDescending(c => c.UpdatedAt ?? c.CreatedAt);

            var allMatchingCourses = await query.ToListAsync();

            return allMatchingCourses.ToPagedList(pageNumber, pageSize);
        }

        public async Task<int> GetCourseCountsByMentorIdsAsync(string mentorId)
        {
            return await _context.Courses
                .AsNoTracking()
                .CountAsync(c => c.Creator == mentorId && c.Status == CourseStatus.Approved);
        }

        public async Task<Dictionary<string, int>> GetCourseStatusCountsAsync()
        {
            return await _context.Courses
                .GroupBy(c => c.Status)
                .ToDictionaryAsync(g => g.Key.ToString(), g => g.Count());
        }

        public async Task<Course?> GetByIdWithDetailsToLearnAsync(long id)
        {
            return await _context.Set<Course>()
             .Include(c => c.CourseImageUrls)
             .Include(c => c.CourseCategories).ThenInclude(cc => cc.Category)
             .Include(c => c.Modules.Where(m=>m.Status == CommonStatus.Showed))
                 .ThenInclude(m => m.Lessons.Where(l => l.Status == CommonStatus.Showed))
             .Include(c => c.Modules.Where(m => m.Status == CommonStatus.Showed))
                 .ThenInclude(m => m.Quizzes.Where(q => q.Status == QuizStatus.Active))
             .Include(c => c.Level)
             .Include(c => c.CreatorUser)
             .FirstOrDefaultAsync(c => c.CourseId == id);
        }

    }
}