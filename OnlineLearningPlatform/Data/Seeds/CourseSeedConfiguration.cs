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
            var baseDate = new DateTime(2025, 1, 1);

            for (long i = 1; i <= 50; i++)
            {
                var createdDate = baseDate.AddDays(i - 1);
                var updatedDate = createdDate.AddDays(i % 3 + 1);

                courses.Add(new Course
                {
                    CourseId = i,
                    CourseName = $"Sample Course {i}",
                    Description = $"This is a short description for sample course number {i}.",

                    Price = 499000 + ((i - 1) * 10000),

                    Discount = (i % 4 == 0) ? 50000m : 0m,
                    Creator = "2",
                    Acceptor = "1",
                    CreatedAt = createdDate,
                    UpdatedAt = updatedDate,

                    PublishedAt = updatedDate.AddDays(5),

                    StudyTime = $"{(i % 5) + 3} hours",
                    LevelId = (i % 3) + 1,
                    Status = CourseStatus.Approved
                });
            }
            return courses;
        }
    }
}