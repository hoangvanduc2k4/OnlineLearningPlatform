using System.ComponentModel.DataAnnotations;
using OnlineLearningPlatform.Models.Entities.UserPart;

namespace OnlineLearningPlatform.Models.Entities.CoursePart
{
    public class CourseEnrollment : BaseEntity
    {
        public long CourseId { get; set; }
        public string UserId { get; set; } = string.Empty;

        public virtual Course Course { get; set; } = null!;
        public virtual User User { get; set; } = null!;

    }
}
