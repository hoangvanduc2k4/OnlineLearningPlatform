using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using OnlineLearningPlatform.Enums;
using OnlineLearningPlatform.Models.Entities.Others;

namespace OnlineLearningPlatform.Data.Seeds
{
    public class MentorApplicationSeedConfiguration : IEntityTypeConfiguration<MentorApplication>
    {
        public void Configure(EntityTypeBuilder<MentorApplication> builder)
        {
            builder.HasData(GetApplications().ToArray());
        }

        private static List<MentorApplication> GetApplications()
        {
            return new List<MentorApplication>
            {
                new MentorApplication
                {
                    Id = 1,
                    UserId = "3",
                    CvUrl = "https://example.com/cv/3.pdf",
                    Note = "Experienced developer",
                    Status = ApplicationStatus.Approved,
                    SubmittedAt = DateTime.Parse("2025-02-01"),
                    ReviewedAt = DateTime.Parse("2025-02-05"),
                    AdminReviewerId = "1" // admin giả định
                },
                new MentorApplication
                {
                    Id = 2,
                    UserId = "4",
                    CvUrl = "https://example.com/cv/4.pdf",
                    Note = "UI/UX designer",
                    Status = ApplicationStatus.Pending,
                    SubmittedAt = DateTime.Parse("2025-02-15"),
                    ReviewedAt = null,
                    AdminReviewerId = null
                },
                new MentorApplication
                {
                    Id = 3,
                    UserId = "5",
                    CvUrl = "https://example.com/cv/5.pdf",
                    Note = "Data analyst background",
                    Status = ApplicationStatus.Rejected,
                    SubmittedAt = DateTime.Parse("2025-02-20"),
                    ReviewedAt = DateTime.Parse("2025-02-25"),
                    AdminReviewerId = "2"
                }
            };
        }
    }
}
