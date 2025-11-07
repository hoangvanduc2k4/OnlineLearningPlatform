namespace OnlineLearningPlatform.Models.ViewModels
{
    public class ModuleHierarchyViewModel
    {
        public long ModuleId { get; set; }
        public string ModuleName { get; set; } = null!;
        public int ModuleNumber { get; set; }
        public List<LessonHierarchyViewModel> Lessons { get; set; } = new();
        public List<QuizHierarchyViewModel> Quizzes { get; set; } = new();
    }
}
