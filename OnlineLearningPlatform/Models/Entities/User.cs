using Microsoft.AspNetCore.Identity;
using OnlineLearningPlarform.Models.Entities.CoursePart;
using OnlineLearningPlarform.Models.Entities.Others;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineLearningPlarform.Models.Entities.UserPart
{
    [Table("User")]
    public class User : IdentityUser
    {

        [StringLength(255)]
        public string? FullName { get; set; }

        public DateOnly? Dob { get; set; }

        public bool IsDeleted { get; set; } = false;
        public bool IsActived { get; set; } = true;

        [StringLength(20)]
        public string? Phone { get; set; }

        [StringLength(2000)]
        public string? AvatarUrl { get; set; }

        public bool? Gender { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; } = DateTime.Now;
        public DateTime? DeletedAt { get; set; }

        public virtual ICollection<MentorApplication> MentorApplications { get; set; } = new List<MentorApplication>();
        public virtual ICollection<MentorApplication> ReviewedApplications { get; set; } = new List<MentorApplication>();

        public virtual ICollection<Course> CreatedCourses { get; set; } = new List<Course>();
        public virtual ICollection<Course> AcceptedCourses { get; set; } = new List<Course>();

    }
}