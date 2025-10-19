using System.ComponentModel.DataAnnotations;

namespace OnlineLearningPlatform.Models.ViewModels
{
    public class QuizViewModel
    {
        public int LessonNumber { get; set; }
        public int ModuleNumber { get; set; }
        public int ModuleName { get; set; }
        public int CourseId { get; set; }
      
        //[Required]
        public long QuizId { get; set; }

        //[Required]
        public long ModuleId { get; set; }

        [Required(ErrorMessage = "Quiz name not blank.")]
        [StringLength(255, ErrorMessage = "Quiz name cannot exceed 255 characters.")]
        public string QuizName { get; set; } = null!; // Dùng null! để tránh cảnh báo nullable

        [Required(ErrorMessage = "Quiz time not blank.")]
        [Range(1, int.MaxValue, ErrorMessage = "Quiz time must be greater than 0.")]
        public int QuizTime { get; set; }

        public string TimeUnit { get; set; }

        [Required(ErrorMessage = "Pass score not blank.")]
        [Range(1, 10, ErrorMessage = "Pass score must be greater than 0.")]
        public int PassScore { get; set; }
    }
}
