using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineLearningPlatform.Models.Entities.UserPart;
using System;

namespace OnlineLearningPlatform.Data.Seeds
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(
                // --- Admin ---
                new User
                {
                    Id = "1",
                    UserName = "admin@admin.com",
                    NormalizedUserName = "ADMIN@ADMIN.COM",
                    Email = "admin@admin.com",
                    NormalizedEmail = "ADMIN@ADMIN.COM",
                    EmailConfirmed = true,
                    FullName = "System Admin",
                    Dob = new DateOnly(2003, 7, 6),
                    Phone = "0000000000",
                    Gender = true,
                    AvatarUrl = "https://picsum.photos/seed/1/200/200",
                    CreatedAt = new DateTime(2025, 1, 1),
                    PasswordHash = "AQAAAAIAAYagAAAAEGc+7apP...==" // hash 123456
                },

                // --- Mentor demo ---
                new User
                {
                    Id = "2",
                    UserName = "mentor@demo.com",
                    NormalizedUserName = "MENTOR@DEMO.COM",
                    Email = "mentor@demo.com",
                    NormalizedEmail = "MENTOR@DEMO.COM",
                    EmailConfirmed = true,
                    FullName = "Demo Mentor",
                    Dob = new DateOnly(1990, 1, 1),
                    Phone = "0000000001",
                    Gender = true,
                    AvatarUrl = "https://picsum.photos/seed/2/200/200",
                    CreatedAt = new DateTime(2025, 1, 1),
                    PasswordHash = "AQAAAAIAAYagAAAAEGc+7apP...==" // hash 123456
                },

                // --- 10 user thêm ---
                new User
                {
                    Id = "3",
                    UserName = "user3@example.com",
                    NormalizedUserName = "USER3@EXAMPLE.COM",
                    Email = "user3@example.com",
                    NormalizedEmail = "USER3@EXAMPLE.COM",
                    EmailConfirmed = true,
                    FullName = "User Three",
                    Dob = new DateOnly(1995, 5, 5),
                    Phone = "0000000003",
                    Gender = true,
                    AvatarUrl = "https://picsum.photos/seed/3/200/200",
                    CreatedAt = new DateTime(2025, 1, 1),
                    PasswordHash = "AQAAAAIAAYagAAAAEGc+7apP...=="
                },
                new User
                {
                    Id = "4",
                    UserName = "user4@example.com",
                    NormalizedUserName = "USER4@EXAMPLE.COM",
                    Email = "user4@example.com",
                    NormalizedEmail = "USER4@EXAMPLE.COM",
                    EmailConfirmed = true,
                    FullName = "User Four",
                    Dob = new DateOnly(1992, 2, 2),
                    Phone = "0000000004",
                    Gender = false,
                    AvatarUrl = "https://picsum.photos/seed/4/200/200",
                    CreatedAt = new DateTime(2025, 1, 1),
                    PasswordHash = "AQAAAAIAAYagAAAAEGc+7apP...=="
                },
                new User
                {
                    Id = "5",
                    UserName = "user5@example.com",
                    NormalizedUserName = "USER5@EXAMPLE.COM",
                    Email = "user5@example.com",
                    NormalizedEmail = "USER5@EXAMPLE.COM",
                    EmailConfirmed = true,
                    FullName = "User Five",
                    Dob = new DateOnly(1993, 3, 3),
                    Phone = "0000000005",
                    Gender = true,
                    AvatarUrl = "https://picsum.photos/seed/5/200/200",
                    CreatedAt = new DateTime(2025, 1, 1),
                    PasswordHash = "AQAAAAIAAYagAAAAEGc+7apP...=="
                },
                new User
                {
                    Id = "6",
                    UserName = "user6@example.com",
                    NormalizedUserName = "USER6@EXAMPLE.COM",
                    Email = "user6@example.com",
                    NormalizedEmail = "USER6@EXAMPLE.COM",
                    EmailConfirmed = true,
                    FullName = "User Six",
                    Dob = new DateOnly(1994, 4, 4),
                    Phone = "0000000006",
                    Gender = false,
                    AvatarUrl = "https://picsum.photos/seed/6/200/200",
                    CreatedAt = new DateTime(2025, 1, 1),
                    PasswordHash = "AQAAAAIAAYagAAAAEGc+7apP...=="
                },
                new User
                {
                    Id = "7",
                    UserName = "user7@example.com",
                    NormalizedUserName = "USER7@EXAMPLE.COM",
                    Email = "user7@example.com",
                    NormalizedEmail = "USER7@EXAMPLE.COM",
                    EmailConfirmed = true,
                    FullName = "User Seven",
                    Dob = new DateOnly(1996, 6, 6),
                    Phone = "0000000007",
                    Gender = true,
                    AvatarUrl = "https://picsum.photos/seed/7/200/200",
                    CreatedAt = new DateTime(2025, 1, 1),
                    PasswordHash = "AQAAAAIAAYagAAAAEGc+7apP...=="
                },
                new User
                {
                    Id = "8",
                    UserName = "user8@example.com",
                    NormalizedUserName = "USER8@EXAMPLE.COM",
                    Email = "user8@example.com",
                    NormalizedEmail = "USER8@EXAMPLE.COM",
                    EmailConfirmed = true,
                    FullName = "User Eight",
                    Dob = new DateOnly(1997, 7, 7),
                    Phone = "0000000008",
                    Gender = false,
                    AvatarUrl = "https://picsum.photos/seed/8/200/200",
                    CreatedAt = new DateTime(2025, 1, 1),
                    PasswordHash = "AQAAAAIAAYagAAAAEGc+7apP...=="
                },
                new User
                {
                    Id = "9",
                    UserName = "user9@example.com",
                    NormalizedUserName = "USER9@EXAMPLE.COM",
                    Email = "user9@example.com",
                    NormalizedEmail = "USER9@EXAMPLE.COM",
                    EmailConfirmed = true,
                    FullName = "User Nine",
                    Dob = new DateOnly(1998, 8, 8),
                    Phone = "0000000009",
                    Gender = true,
                    AvatarUrl = "https://picsum.photos/seed/9/200/200",
                    CreatedAt = new DateTime(2025, 1, 1),
                    PasswordHash = "AQAAAAIAAYagAAAAEGc+7apP...=="
                },
                new User
                {
                    Id = "10",
                    UserName = "user10@example.com",
                    NormalizedUserName = "USER10@EXAMPLE.COM",
                    Email = "user10@example.com",
                    NormalizedEmail = "USER10@EXAMPLE.COM",
                    EmailConfirmed = true,
                    FullName = "User Ten",
                    Dob = new DateOnly(1999, 9, 9),
                    Phone = "0000000010",
                    Gender = false,
                    AvatarUrl = "https://picsum.photos/seed/10/200/200",
                    CreatedAt = new DateTime(2025, 1, 1),
                    PasswordHash = "AQAAAAIAAYagAAAAEGc+7apP...=="
                },
                new User
                {
                    Id = "11",
                    UserName = "user11@example.com",
                    NormalizedUserName = "USER11@EXAMPLE.COM",
                    Email = "user11@example.com",
                    NormalizedEmail = "USER11@EXAMPLE.COM",
                    EmailConfirmed = true,
                    FullName = "User Eleven",
                    Dob = new DateOnly(1991, 1, 11),
                    Phone = "0000000011",
                    Gender = true,
                    AvatarUrl = "https://picsum.photos/seed/11/200/200",
                    CreatedAt = new DateTime(2025, 1, 1),
                    PasswordHash = "AQAAAAIAAYagAAAAEGc+7apP...=="
                },
                new User
                {
                    Id = "12",
                    UserName = "user12@example.com",
                    NormalizedUserName = "USER12@EXAMPLE.COM",
                    Email = "user12@example.com",
                    NormalizedEmail = "USER12@EXAMPLE.COM",
                    EmailConfirmed = true,
                    FullName = "User Twelve",
                    Dob = new DateOnly(1992, 2, 12),
                    Phone = "0000000012",
                    Gender = false,
                    AvatarUrl = "https://picsum.photos/seed/12/200/200",
                    CreatedAt = new DateTime(2025, 1, 1),
                    PasswordHash = "AQAAAAIAAYagAAAAEGc+7apP...=="
                }
            );
        }
    }
}
