using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using OnlineLearningPlatform.Enums;

namespace OnlineLearningPlatform.Models.ViewModels
{
    public class CourseEditViewModel
    {
        public long CourseId { get; set; }

        [Required(ErrorMessage = "The Course Name field is required.")]
        [Display(Name = "Course Name")]
        public string CourseName { get; set; } = null!;

        [Display(Name = "Description")]
        public string? Description { get; set; }

        [Required(ErrorMessage = "The Study Time field is required.")]
        [StringLength(50)]
        [Display(Name = "Study Time")]
        public string? StudyTime { get; set; }

        [Required(ErrorMessage = "The Price field is required.")]
        [Range(1000, double.MaxValue, ErrorMessage = "Price must be at least 1.000 VND.")]
        [Display(Name = "Price")]
        public decimal Price { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Discount must be a positive number.")]
        [Display(Name = "Discount Price")]
        public decimal Discount { get; set; }

        [Required(ErrorMessage = "Please select a level.")]
        [Display(Name = "Level")]
        public long? LevelId { get; set; }

        [Display(Name = "Categories")]
        public List<long> SelectedCategoryIds { get; set; } = new();

        [Display(Name = "Change Cover Image")]
        public IFormFile? NewCoverImage { get; set; }

        public CourseStatus CurrentStatus { get; set; }
        public string? ExistingCoverImageUrl { get; set; }
        public SelectList? Levels { get; set; }
        public List<CategoryViewModel>? AllCategories { get; set; }
        public string ImageOption { get; set; } = "file";
        public string? CoverImageUrl { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Discount > Price)
            {
                yield return new ValidationResult(
                    "Discount price cannot be higher than the original price.",
                    new[] { nameof(Discount) }
                );
            }
        }
    }
}
