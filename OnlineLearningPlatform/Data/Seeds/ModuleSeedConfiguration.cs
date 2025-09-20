using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineLearningPlatform.Enums;
using OnlineLearningPlatform.Models.Entities.CoursePart;

namespace OnlineLearningPlatform.Data.Seeds
{
    public class ModuleSeedConfiguration : IEntityTypeConfiguration<Module>
    {
        public void Configure(EntityTypeBuilder<Module> builder)
        {
            builder.HasData(GetModules().ToArray());
        }

        private static List<Module> GetModules()
        {
            var modules = new List<Module>();
            long id = 1;

            // Mỗi course có 3 module
            for (long courseId = 1; courseId <= 12; courseId++)
            {
                for (int m = 1; m <= 3; m++)
                {
                    modules.Add(new Module
                    {
                        ModuleId = id++,
                        ModuleName = $"Module {m} of Course {courseId}",
                        CourseId = courseId,
                        ModuleNumber = m,
                        // Trạng thái thay đổi xen kẽ để dữ liệu phong phú
                        Status = m switch
                        {
                            1 => CommonStatus.Showed,
                            2 => CommonStatus.Hided,
                            _ => CommonStatus.Privated
                        },
                        DateCreated = new DateTime(2025, 1, 1)
                    });
                }
            }

            return modules;
        }
    }
}
