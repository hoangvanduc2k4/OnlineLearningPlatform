// OnlineLearningPlatform/Services/Implementations/StatisticService.cs
using OnlineLearningPlatform.Models.ViewModels;
using OnlineLearningPlatform.Repositories.Interfaces;
using OnlineLearningPlatform.Services.Interfaces;

namespace OnlineLearningPlatform.Services.Implementations
{
    public class StatisticService : IStatisticService
    {
        private readonly ITransactionRepository _transactionRepository;
        private readonly ICourseRepository _courseRepository;
        private readonly IUserRepository _userRepository;
        private readonly IRoleRepository _roleRepository;

        // Constructor đã được dọn dẹp, chỉ phụ thuộc vào các Repository Interfaces
        public StatisticService(
            ITransactionRepository transactionRepository,
            ICourseRepository courseRepository,
            IUserRepository userRepository,
            IRoleRepository roleRepository)
        {
            _transactionRepository = transactionRepository;
            _courseRepository = courseRepository;
            _userRepository = userRepository;
            _roleRepository = roleRepository;
        }

        public async Task<DashboardViewModel> GetDashboardStatisticsAsync(DateTime? startDate, DateTime? endDate)
        {
            var today = DateTime.UtcNow.Date;
            var viewModel = new DashboardViewModel
            {
                StartDate = startDate,
                EndDate = endDate
            };

            // 1. LẤY DỮ LIỆU DOANH THU TỪ REPOSITORY
            var transactions = await _transactionRepository.GetSuccessfulTransactionsByDateRangeAsync(startDate, endDate);
            var startOfMonth = new DateTime(today.Year, today.Month, 1);

            // Xử lý logic nghiệp vụ cho doanh thu
            viewModel.TotalRevenue = transactions.Sum(t => t.Amount);
            viewModel.TotalSuccessfulTransactions = transactions.Count;
            viewModel.RevenueToday = transactions.Where(t => t.DateCreated.Date == today).Sum(t => t.Amount);
            viewModel.RevenueThisMonth = transactions.Where(t => t.DateCreated.Date >= startOfMonth).Sum(t => t.Amount);

            viewModel.RevenueByDay = transactions
                .GroupBy(t => t.DateCreated.Date)
                .Select(g => new ChartDataPoint { Period = g.Key.ToString("yyyy-MM-dd"), Amount = g.Sum(t => t.Amount) })
                .OrderBy(d => d.Period)
                .ToList();

            viewModel.TopSellingCourses = transactions
                .Where(t => t.Course != null)
                .GroupBy(t => t.Course)
                .Select(g => new TopSellingCourseViewModel
                {
                    CourseName = g.Key!.CourseName,
                    TotalRevenue = g.Sum(t => t.Amount),
                    EnrollmentCount = g.Count()
                })
                .OrderByDescending(c => c.TotalRevenue)
                .Take(5)
                .ToList();

            viewModel.TotalUsers = await _userRepository.GetTotalUsersCountAsync();
            viewModel.NewUsersToday = await _userRepository.GetNewUsersCountOnDateAsync(today);
            viewModel.UserRoleCounts = await _roleRepository.GetUserCountsByRoleAsync();

            viewModel.CourseStatusCounts = await _courseRepository.GetCourseStatusCountsAsync();
            viewModel.TotalCourses = viewModel.CourseStatusCounts.Values.Sum();

            return viewModel;
        }
    }
}