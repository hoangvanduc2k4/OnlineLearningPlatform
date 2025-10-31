using OnlineLearningPlatform.Models.ViewModels;

namespace OnlineLearningPlatform.Services.Interfaces
{
    public interface IStatisticService
    {
        Task<DashboardViewModel> GetDashboardStatisticsAsync(DateTime? startDate, DateTime? endDate);
    }
}