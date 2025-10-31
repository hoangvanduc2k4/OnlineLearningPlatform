namespace OnlineLearningPlatform.Models.ViewModels
{
    public class ChartDataPoint
    {
        public string Period { get; set; }
        public decimal Amount { get; set; }
    }

    public class TopSellingCourseViewModel
    {
        public string CourseName { get; set; }
        public decimal TotalRevenue { get; set; }
        public int EnrollmentCount { get; set; }
    }

    public class DashboardViewModel
    {
        public decimal TotalRevenue { get; set; }
        public int TotalSuccessfulTransactions { get; set; }
        public decimal RevenueToday { get; set; }
        public decimal RevenueThisMonth { get; set; }
        public List<ChartDataPoint> RevenueByDay { get; set; } = new List<ChartDataPoint>();
        public List<TopSellingCourseViewModel> TopSellingCourses { get; set; } = new List<TopSellingCourseViewModel>();

        public int TotalUsers { get; set; }
        public int NewUsersToday { get; set; }
        public Dictionary<string, int> UserRoleCounts { get; set; } = new Dictionary<string, int>();

        public int TotalCourses { get; set; }
        public Dictionary<string, int> CourseStatusCounts { get; set; } = new Dictionary<string, int>();
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}