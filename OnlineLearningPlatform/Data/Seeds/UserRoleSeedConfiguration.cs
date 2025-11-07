using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace OnlineLearningPlatform.Data.Seeds
{

    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            var userRoles = new List<IdentityUserRole<string>>
            {
                // --- Admin ---
                new IdentityUserRole<string>
                {
                    UserId = "1",          // Id của admin trong UserSeedConfiguration
                    RoleId = "admin-role"  // Id của role Admin trong RoleSeedConfiguration
                },

                // --- Mentor demo ---
                new IdentityUserRole<string>
                {
                    UserId = "2",
                    RoleId = "mentor-role"
                },
                new IdentityUserRole<string>
                {
                    UserId = "3",
                    RoleId = "mentor-role"

                },
                new IdentityUserRole<string>
                {
                    UserId = "4",
                    RoleId = "mentor-role"
                }
            };

            for (int i = 5; i <= 50; i++)
            {
                userRoles.Add(new IdentityUserRole<string>
                {
                    UserId = i.ToString(),
                    RoleId = "mentee-role"
                });
            }

            builder.HasData(userRoles);
        }
    }
}
