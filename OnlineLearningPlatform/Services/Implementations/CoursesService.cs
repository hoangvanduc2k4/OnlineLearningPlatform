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
           string? sortBy = null,
           string? userId = null)
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

            if (levelIds != null && levelIds.Any() && !levelIds.Contains(0))
            {
                query = query.Where(c => c.LevelId.HasValue && levelIds.Contains(c.LevelId.Value));
            }

            if (!string.IsNullOrEmpty(priceRange))
            {
                switch (priceRange)
                {
                    case "under50":
                        query = query.Where(c => (c.Price - (c.Discount ?? 0m)) < 50m);
                        break;
                    case "50to200":
                        query = query.Where(c => (c.Price - (c.Discount ?? 0m)) >= 50m && (c.Price - (c.Discount ?? 0m)) <= 200m);
                        break;
                    case "200to500":
                        query = query.Where(c => (c.Price - (c.Discount ?? 0m)) > 200m && (c.Price - (c.Discount ?? 0m)) <= 500m);
                        break;
                    case "500plus":
                        query = query.Where(c => (c.Price - (c.Discount ?? 0m)) > 500m);
                        break;
                }
            }

            var lightweightCourses = await query.Select(c => new
            {
                c.CourseId,
                c.StudyTime,
                c.PublishedAt,
                c.CreatedAt,
                EffectivePrice = c.Price - (c.Discount ?? 0m)
            }).ToListAsync();

            Func<string?, decimal> parseStudyTime = (studyTimeString) =>
            {
                if (string.IsNullOrWhiteSpace(studyTimeString)) return decimal.MaxValue;
                var digits = new string(studyTimeString.Where(ch => char.IsDigit(ch) || ch == '.').ToArray());
                return decimal.TryParse(digits, out var duration) ? duration : decimal.MaxValue;
            };


            var processedList = lightweightCourses.AsEnumerable();

            if (!string.IsNullOrEmpty(studyTimeRange))
            {
                processedList = processedList.Where(c =>
                {
                    var hours = parseStudyTime(c.StudyTime);
                    if (hours == decimal.MaxValue) return false;
                    return studyTimeRange switch
                    {
                        "under5" => hours < 5m,
                        "5to20" => hours >= 5m && hours <= 20m,
                        "20plus" => hours > 20m,
                        _ => true
                    };
                });
            }

            switch (sortBy)
            {
                case "newest":
                    processedList = processedList.OrderByDescending(c => c.PublishedAt)
                                                 .ThenByDescending(c => c.CourseId);
                    break;
                case "priceAsc":
                    processedList = processedList.OrderBy(c => c.EffectivePrice)
                                                 .ThenBy(c => c.CourseId);
                    break;
                case "priceDesc":
                    processedList = processedList.OrderByDescending(c => c.EffectivePrice)
                                                 .ThenByDescending(c => c.CourseId);
                    break;
                case "durationAsc":
                    processedList = processedList.OrderBy(c => parseStudyTime(c.StudyTime))
                                                 .ThenBy(c => c.CourseId);
                    break;
                case "durationDesc":
                    processedList = processedList.OrderByDescending(c => parseStudyTime(c.StudyTime))
                                                 .ThenByDescending(c => c.CourseId);
                    break;
                default:
                    processedList = processedList.OrderByDescending(c => c.PublishedAt ?? c.CreatedAt)
                                                 .ThenByDescending(c => c.CourseId);
                    break;
            }

            var totalItemCount = processedList.Count();
            var pagedCourseIds = processedList
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .Select(c => c.CourseId)
                .ToList();


            if (!pagedCourseIds.Any())
            {
                return new StaticPagedList<CourseViewModel>(new List<CourseViewModel>(), pageNumber, pageSize, totalItemCount);
            }

            var finalCourses = await _courseRepository.GetCoursesQuery()
                                        .Where(c => pagedCourseIds.Contains(c.CourseId))
                                        .ToListAsync();

            var orderedFinalCourses = finalCourses
                .OrderBy(c => pagedCourseIds.IndexOf(c.CourseId))
                .ToList();

            var vmList = new List<CourseViewModel>();

            foreach (var course in orderedFinalCourses)
            {
                var vm = _mapper.Map<CourseViewModel>(course);

                if (!string.IsNullOrEmpty(userId))
                {
                    vm.IsEnrolled = await _courseEnrollmentRepository.CheckUserPurchaseCourseAsync(userId, course.CourseId);
                }


                vmList.Add(vm);
            }

            return new StaticPagedList<CourseViewModel>(vmList, pageNumber, pageSize, totalItemCount);
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


        public async Task<CourseDetailsViewModel?> GetCourseDetailsAsync(long id, string? userId)
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

            vm.IsEnrolled = false;
            if (!string.IsNullOrEmpty(userId))
            {
                vm.IsEnrolled = await _courseEnrollmentRepository.CheckUserPurchaseCourseAsync(userId, id);
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

        public async Task<IPagedList<Course>> GetCoursesByStatusPagedAsync(
            CourseStatus status,
            int pageNumber,
            int pageSize,
            string? searchTerm,
            string? sortBy)
        {
            IEnumerable<Course> courses = await _courseRepository.GetAllWithCreatorByStatusAsync(status);

            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                var lower = searchTerm.Trim().ToLower();
                courses = courses.Where(c =>
                    (c.CourseName != null && c.CourseName.ToLower().Contains(lower)) ||
                    (c.CreatorUser?.FullName != null && c.CreatorUser.FullName.ToLower().Contains(lower))
                );
            }

            switch (sortBy)
            {
                case "name_asc":
                    courses = courses.OrderBy(c => c.CourseName);
                    break;
                case "name_desc":
                    courses = courses.OrderByDescending(c => c.CourseName);
                    break;
                case "mentor_asc":
                    courses = courses.OrderBy(c => c.CreatorUser?.FullName);
                    break;
                case "mentor_desc":
                    courses = courses.OrderByDescending(c => c.CreatorUser?.FullName);
                    break;
                case "date_asc":
                    courses = courses.OrderBy(c => c.UpdatedAt);
                    break;
                case "date_desc":
                    courses = courses.OrderByDescending(c => c.UpdatedAt);
                    break;
                default:
                    courses = courses.OrderByDescending(c => c.UpdatedAt ?? c.CreatedAt);
                    break;
            }

            IPagedList<Course> pagedResult = courses.ToPagedList(pageNumber, pageSize);
            return pagedResult;
        }

        public async Task<Course?> GetCourseForReviewAsync(long courseId)
        {
            return await _courseRepository.GetCourseForReviewAsync(courseId);
        }

        public async Task<int> GetStudentCountsByMentorIdsAsync(string mentorId)
        {
            return await _courseRepository.GetCourseCountsByMentorIdsAsync(mentorId);
        }

        public async Task<CourseHierarchyViewModel?> GetCourseForHierarchyAsync(long courseId)
        {
            var courseEntity = await _courseRepository.GetCourseForHierarchyAsync(courseId);
            if (courseEntity == null) return null;

            var vm = _mapper.Map<CourseHierarchyViewModel>(courseEntity);

            return vm;
        }

        public async Task<IPagedList<Course>> GetCoursesPagedByMentorAsync(
        string mentorId,
        int pageNumber,
        int pageSize,
        string? searchTerm,
        string? sortBy,
        CourseStatus? status)
        {
            IEnumerable<Course> courses = await _courseRepository.GetAllByMentorIdAsync(mentorId);
            if (status != null)
            {
                courses = courses.Where(c => c.Status == status.Value);
            }
            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                var lower = searchTerm.Trim().ToLower();
                courses = courses.Where(c => c.CourseName.ToLower().Contains(lower));
            }

            switch (sortBy)
            {
                case "name_desc":
                    courses = courses.OrderByDescending(c => c.CourseName);
                    break;
                case "date_asc":
                    courses = courses.OrderBy(c => c.CreatedAt);
                    break;
                case "date_desc":
                    courses = courses.OrderByDescending(c => c.CreatedAt);
                    break;
                case "price_asc":
                    courses = courses.OrderBy(c => c.Price);
                    break;
                case "price_desc":
                    courses = courses.OrderByDescending(c => c.Price);
                    break;
                default:
                    courses = courses.OrderBy(c => c.CourseName);
                    break;
            }

            IPagedList<Course> pagedResult = courses.ToPagedList(pageNumber, pageSize);
            return pagedResult;
        }
        public async Task<CourseDetailsViewModel> GetCourseDetailsToLearnAsync(int id, string? userId)
        {
            var courseEntity = await _courseRepository.GetByIdWithDetailsToLearnAsync(id);
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

            vm.IsEnrolled = false;
            if (!string.IsNullOrEmpty(userId))
            {
                vm.IsEnrolled = await _courseEnrollmentRepository.CheckUserPurchaseCourseAsync(userId, id);
            }

            return vm;
        }
    }
}
