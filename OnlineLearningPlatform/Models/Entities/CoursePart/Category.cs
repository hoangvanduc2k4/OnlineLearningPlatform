using System.ComponentModel.DataAnnotations;

namespace OnlineLearningPlarform.Models.Entities.CoursePart
{
    public class Category
    {
        [Key]
        public long CategoryId { get; set; }

        [Required]
        [StringLength(255)]
        public string CategoryName { get; set; } = null!;

        [Required]
        public bool IsDeleted { get; set; } = false;
        public virtual ICollection<CourseCategory> CourseCategories { get; set; } = new List<CourseCategory>();

    }
}
