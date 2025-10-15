// CourseListViewModel (CourseViewModel)
namespace OnlineLearningPlatform.Models.ViewModels
{
    public class CourseViewModel
    {
        public long CourseId { get; set; }
        public string CourseName { get; set; } = null!;
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public decimal? Discount { get; set; }
        public string? ImageUrl { get; set; }
        public string? StudyTime { get; set; }

        // mentor
        public string MentorId { get; set; } = null!;
        public string? MentorName { get; set; }
        public string? MentorAvatarUrl { get; set; }
        
        // level
        public string? LevelName { get; set; }

        public string Status { get; set; } = null!;

        public List<string> CategoryNames { get; set; } = new();
    }
}


