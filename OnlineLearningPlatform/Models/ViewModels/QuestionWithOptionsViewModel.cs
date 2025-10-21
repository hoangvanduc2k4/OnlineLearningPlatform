using Microsoft.CodeAnalysis.Options;

namespace OnlineLearningPlatform.Models.ViewModels
{
    public class QuestionWithOptionsViewModel
    {
        public long QuestionId { get; set; }
        public long QuizId { get; set; }
        public string QuestionContent { get; set; } = null!;

        public List<OptionsViewModel> Options { get; set; } = new List<OptionsViewModel>();
    }
}
