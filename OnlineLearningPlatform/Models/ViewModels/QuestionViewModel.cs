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
        public string QuestionName { get; set; } = null!; // Dùng null! để tránh cảnh báo nullable

        //[Required(ErrorMessage = "Question Type Cannot Be Left Blank")]
        //public QuestionType Type { get; set; }

        // Thu thập thuộc tính Options là danh sách các tùy chọn trả lời
        //public List<OptionsDTO> Options { get; set; } = new List<OptionsDTO>();
    }
}
