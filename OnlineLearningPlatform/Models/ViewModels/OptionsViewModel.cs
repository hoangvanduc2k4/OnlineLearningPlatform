using System.ComponentModel.DataAnnotations;

namespace OnlineLearningPlatform.Models.ViewModels
{
    public class OptionsViewModel
    {
        //[Required]
        public long OptionId { get; set; }

        //[Required]
        public long QuestionId { get; set; }

        [Required(ErrorMessage = "Option Text Cannot Be Left Blank")]
        [StringLength(255, ErrorMessage = "Option Text cannot exceed 255 characters.")]
        public string OptionText { get; set; } = null!; // Dùng null! để tránh cảnh báo nullable

        public bool IsCorrect { get; set; }
    }
}
