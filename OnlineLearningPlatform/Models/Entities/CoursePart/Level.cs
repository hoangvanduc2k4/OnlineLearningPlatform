using System.ComponentModel.DataAnnotations;

namespace OnlineLearningPlarform.Models.Entities.CoursePart
{
    public class Level
    {
        [Key]
        public long LevelId { get; set; }

        [StringLength(255)]
        public string? LevelName { get; set; }

        [Required]
        public bool IsDeleted { get; set; } = false;    

        public virtual ICollection<Course> Courses { get; set; } = new List<Course>();

    }
}
