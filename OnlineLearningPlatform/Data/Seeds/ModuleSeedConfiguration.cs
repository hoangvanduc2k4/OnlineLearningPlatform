using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineLearningPlatform.Enums;
using OnlineLearningPlatform.Models.Entities.CoursePart;
using System;
using System.Collections.Generic;

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
            var baseDate = new DateTime(2025, 1, 1);

            for (long courseId = 1; courseId <= 50; courseId++)
            {
                for (int m = 1; m <= 3; m++)
                {
                    modules.Add(new Module
                    {
                        ModuleId = id++,
                        ModuleName = $"Module {m} of Course {courseId}",
                        CourseId = courseId,
                        ModuleNumber = m,

                        Status = CommonStatus.Showed,
                        DateCreated = baseDate.AddDays(courseId - 1)
                    });
                }
            }

            return modules;
        }
    }
}