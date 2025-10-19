namespace OnlineLearningPlatform.Models.ViewModels
{
    public class InstructorViewModel
    {
        public string Id { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        public int CourseCount { get; set; }
        public int StudentCount { get; set; }
    }
}
