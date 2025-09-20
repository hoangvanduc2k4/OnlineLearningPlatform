using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineLearningPlatform.Models.Entities.CoursePart;
using System.Collections.Generic;

namespace OnlineLearningPlatform.Data.Seeds
{
    public class LevelSeedConfiguration : IEntityTypeConfiguration<Level>
    {
        public void Configure(EntityTypeBuilder<Level> builder)
        {
            builder.HasData(GetLevels().ToArray());
        }

        private static List<Level> GetLevels()
        {
            return new List<Level>
            {
                new Level { LevelId = 1, LevelName = "Beginner", IsDeleted = false },
                new Level { LevelId = 2, LevelName = "Intermediate", IsDeleted = false },
                new Level { LevelId = 3, LevelName = "Advanced", IsDeleted = false }
            };
        }
    }
}
