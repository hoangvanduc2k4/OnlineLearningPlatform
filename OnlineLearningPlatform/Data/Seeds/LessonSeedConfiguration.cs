using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineLearningPlatform.Enums;
using OnlineLearningPlatform.Models.Entities.CoursePart;

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

            // M?i module có 2 lessons
            for (long moduleId = 1; moduleId <= 36; moduleId++)
            {
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
                        CreatedAt = new DateTime(2025, 1, 1),
                        UpdatedAt = null,
                        Status = l == 1 ? CommonStatus.Showed : CommonStatus.Hided,
                        DateCreated = new DateTime(2025, 1, 1)
                    });
                }
            }

            return lessons;
        }
    }
}
