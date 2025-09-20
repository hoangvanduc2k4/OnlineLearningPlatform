using System.ComponentModel.DataAnnotations;

namespace OnlineLearningPlatform.Models.Entities.CoursePart
{
    public class CourseCategory
    {
        public long CategoryId { get; set; }
        public long CourseId { get; set; }

        public virtual Category Category { get; set; } = null!;
        public virtual Course Course { get; set; } = null!;

    }
}
