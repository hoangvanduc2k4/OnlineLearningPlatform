using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using OnlineLearningPlatform.Enums;
using OnlineLearningPlatform.Models.Entities.CoursePart;

namespace OnlineLearningPlatform.Data.Seeds
{
    public class CourseSeedConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasData(GetCourses());
        }

        private static List<Course> GetCourses()
        {
            var courses = new List<Course>();

            for (long i = 1; i <= 12; i++)
            {
                courses.Add(new Course
                {
                    CourseId = i,
                    CourseName = $"Demo Course {i}",
                    Description = $"Mô t? ng?n g?n cho khoá h?c s? {i}",
                    Price = 20 + i,
                    Discount = (i % 3 == 0) ? 5m : 0m,
                    Creator = "2",
                    Acceptor = "1",
                    CreatedAt = new DateTime(2025, 1, 1),
                    UpdatedAt = new DateTime(2025, 1, 5),
                    PublishedAt = (i <= 8) ? new DateTime(2025, 2, 1) : null,
                    StudyTime = "5 hours",
                    LevelId = (i % 3) + 1,
                    Status = CourseStatus.Approved
                });
            }
            return courses;
        }
    }
}
