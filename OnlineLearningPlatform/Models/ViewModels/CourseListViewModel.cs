using OnlineLearningPlatform.Enums;

namespace OnlineLearningPlatform.Models.ViewModels
{
    public class CourseListViewModel
    {
        public long CourseId { get; set; }
        public string CourseName { get; set; }
        public decimal Price { get; set; }
        public decimal? Discount { get; set; }
        public CourseStatus Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public string? ReviewNote { get; set; }
    }
}
