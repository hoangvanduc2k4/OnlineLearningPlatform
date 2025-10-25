using OnlineLearningPlatform.Models.Entities.UserPart;
using OnlineLearningPlatform.Models.ViewModels;
using OnlineLearningPlatform.Repositories.Interfaces;
using OnlineLearningPlatform.Services.Interfaces;
using X.PagedList;
using X.PagedList.Extensions;

namespace OnlineLearningPlatform.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly ICourseService _courseService;
        private readonly ICourseEnrollmentService _enrollmentService;
        public UserService(IUserRepository userRepository, ICourseEnrollmentService courseEnrollmentService, ICourseService courseService)
        {
            _userRepository = userRepository;
            _enrollmentService = courseEnrollmentService;
            _courseService = courseService;
        }

        public async Task<User> AddUserAsync(User user)
        {
            return await _userRepository.AddAsync(user);
        }

        public async Task<bool> ChangeAvatarAsync(long userId, IFormFile avatarFile)
        {
            var user = await _userRepository.GetByIdAsync(userId);
            if (user == null || avatarFile == null) return false;

            // Implement avatar upload logic here (e.g., save file, update AvatarUrl)
            // Example: user.AvatarUrl = await SaveAvatarAsync(avatarFile);
            // For now, just return false as placeholder
            return false;
        }

        public async Task<bool> DeleteUserAsync(string userId)
        {
            if (userId == null) return false;
            var user = await _userRepository.GetByIdAsync(userId);
            if (user == null) return false;
            user.IsDeleted = true;
            await _userRepository.UpdateAsync(user);
            return true;
        }

        public async Task<IEnumerable<User>> GetActiveUsersAsync(string? searchTerm)
        {
            return await _userRepository.GetActiveUsersAsync(searchTerm);
        }

        public async Task<IEnumerable<User>> GetAllActiveMentorAsync(string? searchTerm)
        {
            return await _userRepository.GetAllActiveMentorAsync(searchTerm);
        }

        public async Task<IEnumerable<User>> GetAllUsersAsync()
        {
            return await _userRepository.GetAllAsync();
        }

        public async Task<IEnumerable<User>> GetAllUsersAsync(string? searchTerm)
        {
            return await _userRepository.GetAllUsersAsync(searchTerm);
        }

        public async Task<User?> GetByEmailAndPasswordAsync(string email, string password)
        {
            return await _userRepository.GetByEmailAndPasswordAsync(email, password);
        }

        public async Task<IEnumerable<User>> GetDeletedUsersAsync(string? searchTerm)
        {
            return await _userRepository.GetDeletedUsersAsync(searchTerm);
        }

        public async Task<IEnumerable<User>> GetInactiveUsersAsync(string? searchTerm)
        {
            return await _userRepository.GetInactiveUsersAsync(searchTerm);
        }

        public async Task<IPagedList<InstructorViewModel>> GetPaginatedMentorsAsync(string searchString, int page, int pageSize, string? sortBy = null, string? orderBy = "desc")
        {
            var allMentorsList = await GetAllActiveMentorAsync(searchString);

            var viewModels = new List<InstructorViewModel>();

            foreach (var user in allMentorsList)
            {
                int courseCount = await _courseService.GetStudentCountsByMentorIdsAsync(user.Id);
                int studentCount = await _enrollmentService.GetStudentCountByMentorIdAsync(user.Id);

                viewModels.Add(new InstructorViewModel
                {
                    Id = user.Id,
                    FullName = user.FullName ?? "Unnamed mentor",
                    ImageUrl = user.AvatarUrl ?? "~/uploads/avatars/avatar.png",
                    CourseCount = courseCount,
                    StudentCount = studentCount,
                });
            }

            var sortedViewModels = viewModels.AsQueryable();
            bool isAscending = orderBy?.ToLower() == "asc";

            switch (sortBy?.ToLower())
            {
                case "students":
                    sortedViewModels = isAscending
                        ? sortedViewModels.OrderBy(vm => vm.StudentCount)
                        : sortedViewModels.OrderByDescending(vm => vm.StudentCount);
                    break;
                case "name":
                    sortedViewModels = isAscending
                       ? sortedViewModels.OrderBy(vm => vm.FullName)
                       : sortedViewModels.OrderByDescending(vm => vm.FullName);
                    break;
                default:
                    break;
            }

            var pagedViewModel = sortedViewModels.ToPagedList(page, pageSize);

            return pagedViewModel;
        }

        public async Task<User?> GetUserByEmailAsync(string email)
        {
            return await _userRepository.GetByEmailAsync(email);
        }

        public async Task<User?> GetUserByIdAsync(string id)
        {
            return await _userRepository.GetByIdAsync(id);
        }

        public async Task<string> GetUserHeaderAsync(string userId)
        {
            var user = await GetUserByIdAsync(userId);
            return user?.FullName ?? string.Empty;
        }

        public async Task<string> GetUserNameByIdAsync(string userId)
        {
            var user = await GetUserByIdAsync(userId);
            return user?.FullName ?? string.Empty;
        }

        public async Task UpdateUserAsync(User user)
        {
            await _userRepository.UpdateAsync(user);
        }


        public async Task<List<InstructorViewModel>> GetTopMentorsByStudentCountAsync(int count)
        {
            var topMentorUsers = await _userRepository.GetTopMentorsByStudentCountFromDbAsync(count);

            var viewModels = new List<InstructorViewModel>();
            foreach (var user in topMentorUsers)
            {
                int courseCount = await _courseService.GetStudentCountsByMentorIdsAsync(user.Id);
                int studentCount = await _enrollmentService.GetStudentCountByMentorIdAsync(user.Id);// Assuming you keep injecting this

                viewModels.Add(new InstructorViewModel
                {
                    Id = user.Id,
                    FullName = user.FullName ?? "Unnamed mentor",
                    ImageUrl = user.AvatarUrl ?? "~/uploads/avatars/avatar.png",
                    CourseCount = courseCount,
                    StudentCount = studentCount
                });
            }

            return viewModels;
        }

        public async Task<User?> GetUserByNameAsync(string userName)
        {
            return await _userRepository.GetByUserNameAsync(userName);
        }
    }
}