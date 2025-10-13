using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace OnlineLearningPlatform.Models.ViewModels
{
    public class CourseCreateViewModel
    {
        [Required(ErrorMessage = "The Course Name field is required.")]
        [StringLength(255)]
        [Display(Name = "Course Name")]
        public string CourseName { get; set; } = null!;

        [Display(Name = "Description")]
        public string? Description { get; set; }

        [Required(ErrorMessage = "The Price field is required.")]
        [Range(0, double.MaxValue, ErrorMessage = "Price must be a positive number.")]
        [Display(Name = "Price")]
        public decimal Price { get; set; }


        [Display(Name = "Discount Price")]
        [Range(0, double.MaxValue, ErrorMessage = "Discount must be a positive number.")]
        public decimal? Discount { get; set; }

        [Display(Name = "Level")]
        public long? LevelId { get; set; }

        [Display(Name = "Categories")]
        public List<long> SelectedCategoryIds { get; set; } = new();

        [Display(Name = "Image Source")]
        public string ImageOption { get; set; } = "file";

        [Display(Name = "Upload Cover Image")]
        public IFormFile? CoverImageFile { get; set; }

        [Display(Name = "Or enter Image URL")]
        [Url(ErrorMessage = "Please enter a valid URL.")]
        public string? CoverImageUrl { get; set; }

        public SelectList? Levels { get; set; }
        public List<CategoryViewModel>? AllCategories { get; set; }
    }

    public class CategoryViewModel
    {
        public long Id { get; set; }
        public string Name { get; set; } = null!;
        public bool IsSelected { get; set; }
    }
}
