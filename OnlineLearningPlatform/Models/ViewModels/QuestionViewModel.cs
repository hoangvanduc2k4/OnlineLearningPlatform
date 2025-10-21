using Microsoft.CodeAnalysis.Options;
using System.ComponentModel.DataAnnotations;

namespace OnlineLearningPlatform.Models.ViewModels
{
    public class QuestionViewModel
    {
        public long QuestionId { get; set; }
        //[Required]
        public long QuizId { get; set; }


        [Required(ErrorMessage = "Question Name Cannot Be Left Blank")]
        [StringLength(255, ErrorMessage = "Quiz name cannot exceed 255 characters.")]
        public string QuestionContent { get; set; } = null!; // Dùng null! để tránh cảnh báo nullable


        // Thu thập thuộc tính Options là danh sách các tùy chọn trả lời
        public List<OptionsViewModel> Options { get; set; } = new List<OptionsViewModel>();
    }
}
