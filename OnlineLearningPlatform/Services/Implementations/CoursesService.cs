using AutoMapper;
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
    }
}
