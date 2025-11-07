using OnlineLearningPlatform.Enums;
using System.ComponentModel.DataAnnotations;

namespace OnlineLearningPlatform.Models.ViewModels
{
    public class ModuleInputViewModel
    {
        public long ModuleId { get; set; }

        [Required(ErrorMessage = "Module name is required.")]
        [StringLength(255)]
        public string ModuleName { get; set; } = null!;

        [Required(ErrorMessage = "Please select a course.")]
        public long CourseId { get; set; }

        [Required(ErrorMessage = "Module number is required.")]
        [Range(1, int.MaxValue, ErrorMessage = "Module number must be at least 1.")]
        public int ModuleNumber { get; set; }

        [Required(ErrorMessage = "Please select a status.")]
        public CommonStatus Status { get; set; }
    }
}
