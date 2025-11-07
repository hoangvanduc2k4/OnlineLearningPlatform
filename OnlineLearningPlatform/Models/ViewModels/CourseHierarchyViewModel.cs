namespace OnlineLearningPlatform.Models.ViewModels
{
    public class CourseHierarchyViewModel
    {
        public long CourseId { get; set; }
        public string CourseName { get; set; } = null!;
        public List<ModuleHierarchyViewModel> Modules { get; set; } = new();
    }
}
