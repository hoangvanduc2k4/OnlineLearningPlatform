using OnlineLearningPlatform.Enums;
using System.ComponentModel.DataAnnotations;

namespace OnlineLearningPlatform.Models.ViewModels
{
    public class LessonInputViewModel
    {
        public long LessonId { get; set; }
        public long ModuleId { get; set; }
        public long CourseId { get; set; } 

        [Required(ErrorMessage = "Lesson number is required.")]
        [Range(1, int.MaxValue, ErrorMessage = "Lesson number must be at least 1.")]
        public int LessonNumber { get; set; }

        [Required(ErrorMessage = "Lesson name is required.")]
        [StringLength(255)]
        public string LessonName { get; set; } = null!;

        public string? LessonContent { get; set; }

        [Url(ErrorMessage = "Please enter a valid URL for the video.")]
        public string? LessonVideo { get; set; }

        [Required(ErrorMessage = "Duration is required.")]
        [Range(1, int.MaxValue, ErrorMessage = "Duration must be at least 1.")]
        public string? Duration { get; set; } 

        [Required(ErrorMessage = "Please select a status.")]
        public CommonStatus Status { get; set; }
    }
}
