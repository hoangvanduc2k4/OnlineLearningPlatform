using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace OnlineLearningPlatform.Data.Seeds
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(GetRoles().ToArray());
        }

        private static List<IdentityRole> GetRoles()
        {
            return new List<IdentityRole>
            {
                new IdentityRole { Id = "admin-role", Name = "Admin", NormalizedName = "ADMIN" },
                new IdentityRole { Id = "mentor-role", Name = "Mentor", NormalizedName = "MENTOR" },
                new IdentityRole { Id = "mentee-role", Name = "Mentee", NormalizedName = "MENTEE" }
            };
        }
    }
}
