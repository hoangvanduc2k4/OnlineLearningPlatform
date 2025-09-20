using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using OnlineLearningPlatform.Enums;
using OnlineLearningPlatform.Models.Entities.Others;

namespace OnlineLearningPlatform.Data.Seeds
{
    public class AdminReviewCourseSeedConfiguration : IEntityTypeConfiguration<AdminReviewCourse>
    {
        public void Configure(EntityTypeBuilder<AdminReviewCourse> builder)
        {
            builder.HasData(GetReviews().ToArray());
        }

        private static List<AdminReviewCourse> GetReviews()
        {
            var reviews = new List<AdminReviewCourse>();

            long id = 1;
            for (long courseId = 1; courseId <= 12; courseId++)
            {
                reviews.Add(new AdminReviewCourse
                {
                    ReviewId = id++,
                    CourseId = courseId,
                    AdminId = "1", // Admin seed trong UserSeedConfiguration
                    Status = (courseId % 2 == 0) ? ReviewStatus.Rejected : ReviewStatus.Approved,
                    ReviewNotes = (courseId % 2 == 0) ? "Needs improvement before publishing" : "Approved for publishing",
                    ReviewedAt = new DateTime(2025, 2, 1).AddDays(courseId)
                });
            }

            return reviews;
        }
    }
}
