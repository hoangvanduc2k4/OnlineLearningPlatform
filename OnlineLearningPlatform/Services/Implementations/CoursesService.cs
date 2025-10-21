using AutoMapper;
using Microsoft.EntityFrameworkCore;
using OnlineLearningPlatform.Enums;
using OnlineLearningPlatform.Models.Entities.CoursePart;
using OnlineLearningPlatform.Models.Entities.Others;
using OnlineLearningPlatform.Models.ViewModels;
using OnlineLearningPlatform.Repositories.Interfaces;
using OnlineLearningPlatform.Services.Interfaces;
using X.PagedList;
using X.PagedList.Extensions;

namespace OnlineLearningPlatform.Services
{
    public class CoursesService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;
        private readonly IRatingRepository _ratingRepository;
        private readonly IAdminReviewCourseRepository _adminReviewCourseRepository;
        private readonly IMapper _mapper;
        private readonly ICourseEnrollmentRepository _courseEnrollmentRepository;
        public CoursesService(ICourseRepository courseRepository, IRatingRepository ratingRepository, IMapper mapper, IAdminReviewCourseRepository adminReviewCourseRepository, ICourseEnrollmentRepository courseEnrollmentRepository)
        {
            _courseRepository = courseRepository;
            _ratingRepository = ratingRepository;
            _mapper = mapper;
            _adminReviewCourseRepository = adminReviewCourseRepository;
            _courseEnrollmentRepository = courseEnrollmentRepository;
        }

        public async Task<IPagedList<CourseViewModel>> GetCoursesPagedAsync(
                    int pageNumber, int pageSize,
                    string? searchTerm = null,
                    List<string>? categories = null,
                    List<long>? levelIds = null,
                    string? priceRange = null,
                    string? studyTimeRange = null,
                    string? sortBy = null)
        {
            var query = _courseRepository.GetCoursesQuery();

            query = query.Where(c => c.Status == CourseStatus.Approved);

            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                var lower = searchTerm.Trim().ToLower();
                query = query.Where(c =>
                    (!string.IsNullOrEmpty(c.CourseName) && c.CourseName.ToLower().Contains(lower)) ||
                    (!string.IsNullOrEmpty(c.Description) && c.Description.ToLower().Contains(lower))
                );
            }

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
                default:
                    query = query.OrderByDescending(c => c.PublishedAt ?? c.CreatedAt).ThenByDescending(c => c.CourseId);
                    break;
            }

            var filteredCourses = await query.ToListAsync();

            IEnumerable<Course> finalFilteredList = filteredCourses;

            if (!string.IsNullOrEmpty(studyTimeRange))
            {
                Func<Course, bool> studyFilter = c =>
                {
                    if (string.IsNullOrWhiteSpace(c.StudyTime)) return false;

                    // Cố gắng parse số giờ từ chuỗi
                    var digits = new string(c.StudyTime.Where(ch => char.IsDigit(ch) || ch == '.').ToArray());
                    if (!decimal.TryParse(digits, out var hours)) return false;

                    switch (studyTimeRange)
                    {
                        case "under5": return hours < 5m;
                        case "5to20": return hours >= 5m && hours <= 20m;
                        case "20plus": return hours > 20m;
                        default: return true;
                    }
                };
                finalFilteredList = finalFilteredList.Where(studyFilter);
            }

            // Xử lý sắp xếp theo thời gian học (durationAsc) trong memory
            if (sortBy == "durationAsc")
            {
                finalFilteredList = finalFilteredList.OrderBy(c =>
                {
                    var digits = new string((c.StudyTime ?? "").Where(char.IsDigit).ToArray());
                    decimal.TryParse(digits, out var duration);
                    return duration;
                });
            }

            var pagedEntities = finalFilteredList.ToPagedList(pageNumber, pageSize);

            var vmList = pagedEntities.Select(c => _mapper.Map<CourseViewModel>(c)).ToList();

            var vmPaged = new StaticPagedList<CourseViewModel>(vmList, pagedEntities.GetMetaData());

            return vmPaged;
        }


        public async Task<List<CourseViewModel>> GetTopNewestCoursesAsync(int count = 3)
        {
            var query = _courseRepository.GetCoursesQuery();

            var newestCourses = await query
                .Where(c => c.Status == CourseStatus.Approved)
                .OrderByDescending(c => c.PublishedAt ?? c.CreatedAt)
                .Take(count)
                .ToListAsync();

            var vmList = newestCourses
                            .Select(c => _mapper.Map<CourseViewModel>(c))
                            .ToList();

            return vmList;
        }


        public async Task<CourseDetailsViewModel?> GetCourseDetailsAsync(long id)
        {
            var courseEntity = await _courseRepository.GetByIdWithDetailsAsync(id);
            if (courseEntity == null) return null;

            var ratings = await _ratingRepository.GetRatingsByCourseIdAsync(id);
            var vm = _mapper.Map<CourseDetailsViewModel>(courseEntity);

            vm.TotalQuizCount = courseEntity.Modules.Sum(m => m.Quizzes.Count);

            if (ratings != null && ratings.Any())
            {
                vm.FeedbackCount = ratings.Count;
                vm.AverageRating = ratings.Average(r => r.Rating);
                vm.Ratings = _mapper.Map<List<RatingViewModel>>(ratings);
            }
            else
            {
                vm.FeedbackCount = 0;
                vm.AverageRating = 0;
                vm.Ratings = new List<RatingViewModel>();
            }

            return vm;
        }

        public async Task<Course?> GetCourseByIdAsync(long courseId)
        {
            return await _courseRepository.GetByIdAsync(courseId);
        }

        public async Task<IEnumerable<Course>> GetCoursesForMentorAsync(string mentorId)
        {
            return await _courseRepository.GetAllByMentorIdAsync(mentorId);
        }

        public async Task<Course?> GetCourseByIdAndMentorAsync(long courseId, string mentorId)
        {
            return await _courseRepository.GetByIdAndMentorIdAsync(courseId, mentorId);
        }

        public async Task<Course?> GetCourseForEditAsync(long courseId, string mentorId)
        {
            return await _courseRepository.GetCourseForEditAsync(courseId, mentorId);
        }
        public async Task<Course> CreateCourseAsync(Course course, string mentorId, List<long> categoryIds, string? coverImageUrl)
        {
            course.Creator = mentorId;
            course.CreatedAt = DateTime.Now;
            course.Status = CourseStatus.Draft;

            if (!string.IsNullOrEmpty(coverImageUrl))
            {
                course.CourseImageUrls.Add(new CourseImageUrl { Url = coverImageUrl });
            }

            foreach (var categoryId in categoryIds)
            {
                course.CourseCategories.Add(new CourseCategory { CategoryId = categoryId });
            }

            await _courseRepository.AddAsync(course);
            return course;
        }
        public async Task<bool> DeleteCourseAsync(long courseId, string mentorId)
        {
            var courseToDelete = await _courseRepository.GetByIdAndMentorIdAsync(courseId, mentorId);
            if (courseToDelete == null)
            {
                return false;
            }

            courseToDelete.DeletedAt = DateTime.Now;
            courseToDelete.Status = CourseStatus.Deleted;
            await _courseRepository.UpdateAsync(courseToDelete);
            //  await _courseRepository.Delete(courseToDelete)

            return true;
        }

        public async Task<bool> UpdateCourseAsync(Course courseToUpdate, List<long> categoryIds, string? newCoverImageUrl, CourseStatus newStatus, string? mentorId)
        {
            var existingCourse = await _courseRepository.GetCourseForEditAsync(courseToUpdate.CourseId, mentorId);
            if (existingCourse == null) return false;

            existingCourse.CourseName = courseToUpdate.CourseName;
            existingCourse.Description = courseToUpdate.Description;
            existingCourse.StudyTime = courseToUpdate.StudyTime;
            existingCourse.Price = courseToUpdate.Price;
            existingCourse.Discount = courseToUpdate.Discount;
            existingCourse.LevelId = courseToUpdate.LevelId;
            existingCourse.UpdatedAt = DateTime.Now;

            existingCourse.Status = newStatus;

            if (!string.IsNullOrEmpty(newCoverImageUrl))
            {
                existingCourse.CourseImageUrls.Clear();
                existingCourse.CourseImageUrls.Add(new CourseImageUrl { Url = newCoverImageUrl });
            }

            existingCourse.CourseCategories.Clear();
            foreach (var categoryId in categoryIds)
            {
                existingCourse.CourseCategories.Add(new CourseCategory { CategoryId = categoryId });
            }

            await _courseRepository.UpdateAsync(existingCourse);
            return true;
        }

        public async Task ReviewCourseAsync(long courseId, string adminId, ReviewStatus reviewStatus, string? notes)
        {
            var course = await _courseRepository.GetByIdAsync(courseId);
            if (course == null || course.Status != CourseStatus.Pending)
            {
                return;
            }

            var review = new AdminReviewCourse
            {
                CourseId = courseId,
                AdminId = adminId,
                Status = reviewStatus,
                ReviewNotes = notes,
                ReviewedAt = DateTime.UtcNow
            };
            await _adminReviewCourseRepository.AddAsync(review);

            if (reviewStatus == ReviewStatus.Approved)
            {
                course.Status = CourseStatus.Approved;
                course.Acceptor = adminId;
                course.PublishedAt = DateTime.UtcNow;
            }
            else // Rejected
            {
                course.Status = CourseStatus.Rejected;
                course.Acceptor = adminId;
            }

            await _courseRepository.UpdateAsync(course);
        }

        public async Task<IPagedList<Course>> GetCoursesByStatusPagedAsync(CourseStatus status, int pageNumber, int pageSize)
        {
            return await _courseRepository.GetCoursesByStatusPagedAsync(status, pageNumber, pageSize);
        }

        public async Task<Course?> GetCourseForReviewAsync(long courseId)
        {
            return await _courseRepository.GetCourseForReviewAsync(courseId);
        }

        public async Task<int> GetStudentCountsByMentorIdsAsync(string mentorId)
        {
            return await _courseRepository.GetCourseCountsByMentorIdsAsync(mentorId);
        }


    }
}
