using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;
using OnlineLearningPlatform.Models.Entities.CoursePart;

namespace OnlineLearningPlatform.Data.Seeds
{
    public class CourseCategorySeedConfiguration : IEntityTypeConfiguration<CourseCategory>
    {
        public void Configure(EntityTypeBuilder<CourseCategory> builder)
        {
            builder.HasData(GetCourseCategories().ToArray());
        }

        private static List<CourseCategory> GetCourseCategories()
        {
            var list = new List<CourseCategory>();
            for (long courseId = 1; courseId <= 12; courseId++)
            {
                // assign 2 categories per course
                list.Add(new CourseCategory { CategoryId = ((int)(courseId % 3) + 1), CourseId = courseId });
                list.Add(new CourseCategory { CategoryId = (((int)((courseId + 1) % 3) + 1)), CourseId = courseId });
            }
            return list;
        }
    }
}
