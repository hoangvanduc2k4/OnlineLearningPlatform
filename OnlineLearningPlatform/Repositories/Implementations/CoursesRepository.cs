using System.Text.RegularExpressions;
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
        private readonly OnlineLearningDBContext _context;
        public CoursesRepository(OnlineLearningDBContext context) : base(context)
        {
            _context = context;
        }
        public async Task<IPagedList<Course>> GetCoursesPagedAsync(
            int pageNumber, int pageSize,
            string? searchTerm = null,
            CourseStatus? status = null,
            List<string>? categories = null,
            List<long>? levelIds = null,
            string? priceRange = null,
            string? studyTimeRange = null,
            string? sortBy = null)
        {
            var query = _context.Set<Course>().AsQueryable();

            if (status.HasValue)
                query = query.Where(c => c.Status == status.Value);

            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                var lower = searchTerm.Trim().ToLower();
                query = query.Where(c =>
                    (!string.IsNullOrEmpty(c.CourseName) && c.CourseName.ToLower().Contains(lower)) ||
                    (!string.IsNullOrEmpty(c.Description) && c.Description.ToLower().Contains(lower))
                );
            }

            query = query
                .Include(c => c.CourseImageUrls)
                .Include(c => c.CourseCategories).ThenInclude(cc => cc.Category)
                .Include(c => c.Level)
                .Include(c => c.CreatorUser);

            if (categories != null && categories.Any() && !categories.Contains("All"))
            {
                var cats = categories.Select(x => x.Trim()).ToList();
                query = query.Where(c => c.CourseCategories.Any(cc => cats.Contains(cc.Category.CategoryName)));
            }

            if (levelIds != null && levelIds.Any())
            {
                query = query.Where(c => c.LevelId.HasValue && levelIds.Contains(c.LevelId.Value));
            }

            if (!string.IsNullOrEmpty(priceRange))
            {
                switch (priceRange)
                {
                    case "under50":
                        query = query.Where(c => c.Price < 50m);
                        break;
                    case "50to200":
                        query = query.Where(c => c.Price >= 50m && c.Price <= 200m);
                        break;
                    case "200to500":
                        query = query.Where(c => c.Price > 200m && c.Price <= 500m);
                        break;
                    case "500plus":
                        query = query.Where(c => c.Price > 500m);
                        break;
                    default:
                        break;
                }
            }

            switch (sortBy)
            {
                case "newest":
                    query = query.OrderByDescending(c => c.PublishedAt ?? c.CreatedAt);
                    break;
                case "priceAsc":
                    query = query.OrderBy(c => c.Price);
                    break;
                case "priceDesc":
                    query = query.OrderByDescending(c => c.Price);
                    break;
                case "durationAsc":
                    query = query.OrderBy(c => c.StudyTime);
                    break;
                default:
                    query = query.OrderByDescending(c => c.PublishedAt ?? c.CreatedAt).ThenByDescending(c => c.CourseId);
                    break;
            }


            if (!string.IsNullOrEmpty(studyTimeRange))
            {
                var list = await query.ToListAsync();
                Func<Course, bool> studyFilter = c =>
                {
                    if (string.IsNullOrWhiteSpace(c.StudyTime)) return false;
                    if (!decimal.TryParse(c.StudyTime, out var hours))
                    {
                        var digits = new string(c.StudyTime.Where(ch => char.IsDigit(ch) || ch == '.').ToArray());
                        if (!decimal.TryParse(digits, out hours)) return false;
                    }

                    switch (studyTimeRange)
                    {
                        case "under5": return hours < 5m;
                        case "5to20": return hours >= 5m && hours <= 20m;
                        case "20plus": return hours > 20m;
                        default: return true;
                    }
                };

                var filtered = list.Where(studyFilter).AsQueryable();
                var paged = filtered.ToPagedList(pageNumber, pageSize);
                return paged;
            }
            else
            {
                var paged = query.ToPagedList(pageNumber, pageSize);
                return paged;
            }
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
    }
}
