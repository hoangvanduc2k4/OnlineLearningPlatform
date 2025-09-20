using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using OnlineLearningPlatform.Models.Entities.CoursePart;

namespace OnlineLearningPlatform.Data.Seeds
{
    public class CourseEnrollmentSeedConfiguration : IEntityTypeConfiguration<CourseEnrollment>
    {
        public void Configure(EntityTypeBuilder<CourseEnrollment> builder)
        {
            // Nếu bảng dùng composite key CourseId + UserId
            builder.HasKey(e => new { e.CourseId, e.UserId });

            builder.HasData(
                new CourseEnrollment { CourseId = 1, UserId = "3", DateCreated = new DateTime(2025, 3, 1) },
                new CourseEnrollment { CourseId = 2, UserId = "4", DateCreated = new DateTime(2025, 3, 1) },
                new CourseEnrollment { CourseId = 3, UserId = "5", DateCreated = new DateTime(2025, 3, 1) },
                new CourseEnrollment { CourseId = 4, UserId = "6", DateCreated = new DateTime(2025, 3, 1) },
                new CourseEnrollment { CourseId = 5, UserId = "7", DateCreated = new DateTime(2025, 3, 1) },
                new CourseEnrollment { CourseId = 6, UserId = "8", DateCreated = new DateTime(2025, 3, 1) }
                );
        }
    }
}
