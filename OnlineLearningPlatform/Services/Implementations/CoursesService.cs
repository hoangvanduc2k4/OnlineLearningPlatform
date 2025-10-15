using AutoMapper;
using OnlineLearningPlatform.Enums;
using OnlineLearningPlatform.Models.Entities.CoursePart;
using OnlineLearningPlatform.Models.ViewModels;
using OnlineLearningPlatform.Repositories.Interfaces;
using OnlineLearningPlatform.Services.Interfaces;
using X.PagedList;

namespace OnlineLearningPlatform.Services
{
    public class CoursesService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;
        private readonly IRatingRepository _ratingRepository; // Thêm repository này
        private readonly IMapper _mapper;

        public CoursesService(ICourseRepository courseRepository, IRatingRepository ratingRepository, IMapper mapper)
        {
            _courseRepository = courseRepository;
            _ratingRepository = ratingRepository;
            _mapper = mapper;
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

            var pagedEntities = await _courseRepository.GetCoursesPagedAsync(
              pageNumber,
              pageSize,
              searchTerm,
              status: null,
              categories: categories,
              levelIds: levelIds,
              priceRange: priceRange,
              studyTimeRange: studyTimeRange,
              sortBy: sortBy
            );
            var vmList = pagedEntities.Select(c => _mapper.Map<CourseViewModel>(c)).ToList();
            var vmPaged = new StaticPagedList<CourseViewModel>(vmList, pagedEntities.PageNumber, pagedEntities.PageSize, pagedEntities.TotalItemCount);
            return vmPaged;
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
            course.MentorId = mentorId;
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
    }
}
