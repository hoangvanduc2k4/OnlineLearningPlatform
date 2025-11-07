using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineLearningPlatform.Enums;
using OnlineLearningPlatform.Models.Entities.CoursePart;
using System; // Cần cho DateTime
using System.Collections.Generic; // Cần cho List

namespace OnlineLearningPlatform.Data.Seeds
{
    public class LessonSeedConfiguration : IEntityTypeConfiguration<Lesson>
    {
        public void Configure(EntityTypeBuilder<Lesson> builder)
        {
            builder.HasData(GetLessons().ToArray());
        }

        private static List<Lesson> GetLessons()
        {
            var lessons = new List<Lesson>();
            long lessonId = 1;
            var baseDate = new DateTime(2025, 1, 1);

            for (long moduleId = 1; moduleId <= 150; moduleId++)
            {
                var createdDate = baseDate.AddDays((moduleId - 1) / 3);

                for (int l = 1; l <= 2; l++)
                {
                    lessons.Add(new Lesson
                    {
                        LessonId = lessonId++,
                        ModuleId = moduleId,
                        LessonNumber = l,
                        LessonName = $"Lesson {l} of Module {moduleId}",
                        LessonContent = $"This is the content for Lesson {l} of Module {moduleId}.",
                        LessonVideo = null,
                        Duration = 10 * l,
                        UpdatedAt = null,
                        Status = CommonStatus.Showed,

                        DateCreated = createdDate
                    });
                }
            }

            return lessons;
        }
    }
}