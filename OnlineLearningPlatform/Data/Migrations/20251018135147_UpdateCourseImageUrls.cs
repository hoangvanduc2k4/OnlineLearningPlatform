using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OnlineLearningPlatform.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCourseImageUrls : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 1L, 1L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 2L, 2L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 8L, 3L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 34L, 3L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 2L, 4L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 24L, 4L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 28L, 4L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 22L, 5L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 49L, 5L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 23L, 6L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 3L, 7L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 42L, 7L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 6L, 8L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 31L, 8L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 51L, 8L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 17L, 9L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 44L, 9L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 49L, 9L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 11L, 10L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 2L, 11L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 26L, 11L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 27L, 11L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 20L, 12L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 29L, 12L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 52L, 12L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 5L, 13L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 12L, 13L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 19L, 13L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 37L, 14L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 52L, 14L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 2L, 15L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 50L, 16L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 9L, 17L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 24L, 18L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 25L, 18L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 13L, 19L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 24L, 20L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 46L, 20L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 3L, 21L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 8L, 21L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 34L, 21L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 35L, 22L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 45L, 22L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 23L, 23L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 4L, 24L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 12L, 24L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 42L, 24L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 24L, 25L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 36L, 25L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 53L, 25L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 1L, 26L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 7L, 26L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 11L, 26L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 26L, 27L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 30L, 27L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 47L, 27L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 45L, 28L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 54L, 28L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 39L, 29L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 23L, 30L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 28L, 30L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 23L, 31L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 27L, 31L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 3L, 32L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 43L, 32L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 21L, 33L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 29L, 33L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 41L, 33L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 19L, 34L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 36L, 34L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 52L, 35L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 47L, 36L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 3L, 37L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 22L, 37L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 38L, 37L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 54L, 38L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 10L, 40L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 32L, 40L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 38L, 40L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 33L, 41L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 10L, 42L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 38L, 42L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 50L, 42L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 26L, 43L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 35L, 43L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 13L, 44L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 8L, 45L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 17L, 45L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 21L, 46L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 2L, 47L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 18L, 48L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 36L, 48L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 19L, 49L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 21L, 49L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 17L, 50L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 28L, 50L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 12L, 51L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 43L, 51L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 6L, 52L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 17L, 52L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 12L, 53L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 48L, 53L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 27L, 55L });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 2L, "5" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 2L, "6" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 2L, "7" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 3L, "6" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 8L, "7" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 10L, "6" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 12L, "6" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 12L, "7" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 13L, "5" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 14L, "7" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 15L, "5" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 16L, "5" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 18L, "5" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 20L, "5" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 21L, "5" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 21L, "7" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 22L, "7" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 23L, "6" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 23L, "7" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 25L, "6" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 28L, "6" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 28L, "7" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 33L, "7" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 35L, "5" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 38L, "6" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 41L, "6" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 43L, "5" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 47L, "7" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 48L, "5" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 48L, "6" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 49L, "5" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 50L, "5" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 52L, "6" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 55L, "7" });

            migrationBuilder.DeleteData(
                table: "WishLists",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 2L, "5" });

            migrationBuilder.DeleteData(
                table: "WishLists",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 7L, "5" });

            migrationBuilder.DeleteData(
                table: "WishLists",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 8L, "5" });

            migrationBuilder.DeleteData(
                table: "WishLists",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 11L, "5" });

            migrationBuilder.DeleteData(
                table: "WishLists",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 18L, "5" });

            migrationBuilder.DeleteData(
                table: "WishLists",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 25L, "5" });

            migrationBuilder.DeleteData(
                table: "WishLists",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 37L, "5" });

            migrationBuilder.DeleteData(
                table: "WishLists",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 4L, "6" });

            migrationBuilder.DeleteData(
                table: "WishLists",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 5L, "6" });

            migrationBuilder.DeleteData(
                table: "WishLists",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 9L, "6" });

            migrationBuilder.DeleteData(
                table: "WishLists",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 15L, "6" });

            migrationBuilder.DeleteData(
                table: "WishLists",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 19L, "6" });

            migrationBuilder.DeleteData(
                table: "WishLists",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 51L, "6" });

            migrationBuilder.DeleteData(
                table: "WishLists",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 54L, "6" });

            migrationBuilder.DeleteData(
                table: "WishLists",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 1L, "7" });

            migrationBuilder.DeleteData(
                table: "WishLists",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 6L, "7" });

            migrationBuilder.DeleteData(
                table: "WishLists",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 15L, "7" });

            migrationBuilder.DeleteData(
                table: "WishLists",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 19L, "7" });

            migrationBuilder.DeleteData(
                table: "WishLists",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 20L, "7" });

            migrationBuilder.DeleteData(
                table: "WishLists",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 39L, "7" });

            migrationBuilder.DeleteData(
                table: "WishLists",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 55L, "7" });

            migrationBuilder.InsertData(
                table: "CourseCategories",
                columns: new[] { "CategoryId", "CourseId" },
                values: new object[,]
                {
                    { 23L, 1L },
                    { 36L, 2L },
                    { 49L, 2L },
                    { 32L, 4L },
                    { 48L, 4L },
                    { 12L, 5L },
                    { 30L, 5L },
                    { 40L, 5L },
                    { 52L, 6L },
                    { 53L, 6L },
                    { 55L, 6L },
                    { 53L, 7L },
                    { 5L, 8L },
                    { 30L, 8L },
                    { 34L, 8L },
                    { 27L, 9L },
                    { 40L, 9L },
                    { 52L, 9L },
                    { 2L, 10L },
                    { 24L, 10L },
                    { 51L, 10L },
                    { 9L, 11L },
                    { 40L, 11L },
                    { 46L, 11L },
                    { 2L, 12L },
                    { 13L, 12L },
                    { 18L, 12L },
                    { 1L, 13L },
                    { 45L, 13L },
                    { 24L, 14L },
                    { 38L, 14L },
                    { 51L, 14L },
                    { 46L, 15L },
                    { 50L, 15L },
                    { 20L, 16L },
                    { 39L, 16L },
                    { 53L, 16L },
                    { 51L, 18L },
                    { 16L, 19L },
                    { 37L, 19L },
                    { 46L, 19L },
                    { 21L, 20L },
                    { 46L, 21L },
                    { 1L, 22L },
                    { 27L, 22L },
                    { 36L, 22L },
                    { 15L, 23L },
                    { 17L, 23L },
                    { 50L, 23L },
                    { 45L, 24L },
                    { 5L, 25L },
                    { 32L, 25L },
                    { 9L, 26L },
                    { 24L, 26L },
                    { 30L, 26L },
                    { 3L, 27L },
                    { 10L, 27L },
                    { 53L, 27L },
                    { 1L, 28L },
                    { 14L, 29L },
                    { 25L, 29L },
                    { 42L, 29L },
                    { 6L, 30L },
                    { 50L, 30L },
                    { 14L, 31L },
                    { 16L, 31L },
                    { 51L, 32L },
                    { 1L, 33L },
                    { 2L, 33L },
                    { 44L, 33L },
                    { 13L, 34L },
                    { 27L, 34L },
                    { 45L, 34L },
                    { 25L, 35L },
                    { 27L, 35L },
                    { 7L, 36L },
                    { 19L, 36L },
                    { 48L, 36L },
                    { 4L, 37L },
                    { 14L, 37L },
                    { 32L, 37L },
                    { 18L, 38L },
                    { 20L, 38L },
                    { 30L, 38L },
                    { 18L, 39L },
                    { 47L, 39L },
                    { 12L, 40L },
                    { 23L, 41L },
                    { 46L, 41L },
                    { 20L, 42L },
                    { 18L, 43L },
                    { 24L, 43L },
                    { 55L, 43L },
                    { 10L, 44L },
                    { 43L, 44L },
                    { 30L, 45L },
                    { 13L, 46L },
                    { 43L, 46L },
                    { 6L, 47L },
                    { 10L, 48L },
                    { 33L, 48L },
                    { 31L, 49L },
                    { 5L, 50L },
                    { 14L, 50L },
                    { 50L, 50L },
                    { 6L, 51L },
                    { 8L, 51L },
                    { 16L, 52L },
                    { 48L, 52L },
                    { 34L, 53L },
                    { 20L, 55L },
                    { 26L, 55L },
                    { 35L, 55L }
                });

            migrationBuilder.UpdateData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 4L, "6" },
                column: "DateCreated",
                value: new DateTime(2025, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 11L, "7" },
                column: "DateCreated",
                value: new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 15L, "7" },
                column: "DateCreated",
                value: new DateTime(2025, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 31L, "7" },
                column: "DateCreated",
                value: new DateTime(2025, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 34L, "6" },
                column: "DateCreated",
                value: new DateTime(2025, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 35L, "6" },
                column: "DateCreated",
                value: new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 39L, "5" },
                column: "DateCreated",
                value: new DateTime(2025, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 40L, "5" },
                column: "DateCreated",
                value: new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 41L, "5" },
                column: "DateCreated",
                value: new DateTime(2025, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 50L, "6" },
                column: "DateCreated",
                value: new DateTime(2025, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 53L, "7" },
                column: "DateCreated",
                value: new DateTime(2025, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "CourseEnrollments",
                columns: new[] { "CourseId", "UserId", "DateCreated", "ModifiedDate" },
                values: new object[,]
                {
                    { 1L, "5", new DateTime(2025, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 5L, "5", new DateTime(2025, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 5L, "7", new DateTime(2025, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 7L, "7", new DateTime(2025, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 9L, "6", new DateTime(2025, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 10L, "7", new DateTime(2025, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 12L, "5", new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 17L, "5", new DateTime(2025, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 17L, "7", new DateTime(2025, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 19L, "7", new DateTime(2025, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 20L, "6", new DateTime(2025, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 21L, "6", new DateTime(2025, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 23L, "5", new DateTime(2025, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 24L, "5", new DateTime(2025, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 25L, "5", new DateTime(2025, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 25L, "7", new DateTime(2025, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 26L, "6", new DateTime(2025, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 27L, "5", new DateTime(2025, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 27L, "7", new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 29L, "6", new DateTime(2025, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 30L, "5", new DateTime(2025, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 30L, "7", new DateTime(2025, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 32L, "6", new DateTime(2025, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 34L, "7", new DateTime(2025, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 35L, "7", new DateTime(2025, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 36L, "6", new DateTime(2025, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 37L, "5", new DateTime(2025, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 37L, "6", new DateTime(2025, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 41L, "7", new DateTime(2025, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 42L, "6", new DateTime(2025, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 43L, "6", new DateTime(2025, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 52L, "5", new DateTime(2025, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 53L, "5", new DateTime(2025, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 54L, "6", new DateTime(2025, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.UpdateData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Url",
                value: "/img/blog/Course/1.png");

            migrationBuilder.UpdateData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Url",
                value: "/img/blog/Course/2.png");

            migrationBuilder.UpdateData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 3L,
                column: "Url",
                value: "/img/blog/Course/3.png");

            migrationBuilder.UpdateData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 4L,
                column: "Url",
                value: "/img/blog/Course/1.png");

            migrationBuilder.UpdateData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 5L,
                column: "Url",
                value: "/img/blog/Course/2.png");

            migrationBuilder.UpdateData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 6L,
                column: "Url",
                value: "/img/blog/Course/3.png");

            migrationBuilder.UpdateData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 7L,
                column: "Url",
                value: "/img/blog/Course/1.png");

            migrationBuilder.UpdateData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 8L,
                column: "Url",
                value: "/img/blog/Course/2.png");

            migrationBuilder.UpdateData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 9L,
                column: "Url",
                value: "/img/blog/Course/3.png");

            migrationBuilder.UpdateData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 10L,
                column: "Url",
                value: "/img/blog/Course/1.png");

            migrationBuilder.UpdateData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 11L,
                column: "Url",
                value: "/img/blog/Course/2.png");

            migrationBuilder.UpdateData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 12L,
                column: "Url",
                value: "/img/blog/Course/3.png");

            migrationBuilder.UpdateData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 13L,
                column: "Url",
                value: "/img/blog/Course/1.png");

            migrationBuilder.UpdateData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 14L,
                column: "Url",
                value: "/img/blog/Course/2.png");

            migrationBuilder.UpdateData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 15L,
                column: "Url",
                value: "/img/blog/Course/3.png");

            migrationBuilder.UpdateData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 16L,
                column: "Url",
                value: "/img/blog/Course/1.png");

            migrationBuilder.UpdateData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 17L,
                column: "Url",
                value: "/img/blog/Course/2.png");

            migrationBuilder.UpdateData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 18L,
                column: "Url",
                value: "/img/blog/Course/3.png");

            migrationBuilder.UpdateData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 19L,
                column: "Url",
                value: "/img/blog/Course/1.png");

            migrationBuilder.UpdateData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 20L,
                column: "Url",
                value: "/img/blog/Course/2.png");

            migrationBuilder.UpdateData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 21L,
                column: "Url",
                value: "/img/blog/Course/3.png");

            migrationBuilder.UpdateData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 22L,
                column: "Url",
                value: "/img/blog/Course/1.png");

            migrationBuilder.UpdateData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 23L,
                column: "Url",
                value: "/img/blog/Course/2.png");

            migrationBuilder.UpdateData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 24L,
                column: "Url",
                value: "/img/blog/Course/3.png");

            migrationBuilder.UpdateData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 25L,
                column: "Url",
                value: "/img/blog/Course/1.png");

            migrationBuilder.UpdateData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 26L,
                column: "Url",
                value: "/img/blog/Course/2.png");

            migrationBuilder.UpdateData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 27L,
                column: "Url",
                value: "/img/blog/Course/3.png");

            migrationBuilder.UpdateData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 28L,
                column: "Url",
                value: "/img/blog/Course/1.png");

            migrationBuilder.UpdateData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 29L,
                column: "Url",
                value: "/img/blog/Course/2.png");

            migrationBuilder.UpdateData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 30L,
                column: "Url",
                value: "/img/blog/Course/3.png");

            migrationBuilder.UpdateData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 31L,
                column: "Url",
                value: "/img/blog/Course/1.png");

            migrationBuilder.UpdateData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 32L,
                column: "Url",
                value: "/img/blog/Course/2.png");

            migrationBuilder.UpdateData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 33L,
                column: "Url",
                value: "/img/blog/Course/3.png");

            migrationBuilder.UpdateData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 34L,
                column: "Url",
                value: "/img/blog/Course/1.png");

            migrationBuilder.UpdateData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 35L,
                column: "Url",
                value: "/img/blog/Course/2.png");

            migrationBuilder.UpdateData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 36L,
                column: "Url",
                value: "/img/blog/Course/3.png");

            migrationBuilder.InsertData(
                table: "CourseImageUrls",
                columns: new[] { "Id", "CourseId", "Url" },
                values: new object[,]
                {
                    { 37L, 13L, "/img/blog/Course/1.png" },
                    { 38L, 13L, "/img/blog/Course/2.png" },
                    { 39L, 13L, "/img/blog/Course/3.png" },
                    { 40L, 14L, "/img/blog/Course/1.png" },
                    { 41L, 14L, "/img/blog/Course/2.png" },
                    { 42L, 14L, "/img/blog/Course/3.png" },
                    { 43L, 15L, "/img/blog/Course/1.png" },
                    { 44L, 15L, "/img/blog/Course/2.png" },
                    { 45L, 15L, "/img/blog/Course/3.png" },
                    { 46L, 16L, "/img/blog/Course/1.png" },
                    { 47L, 16L, "/img/blog/Course/2.png" },
                    { 48L, 16L, "/img/blog/Course/3.png" },
                    { 49L, 17L, "/img/blog/Course/1.png" },
                    { 50L, 17L, "/img/blog/Course/2.png" },
                    { 51L, 17L, "/img/blog/Course/3.png" },
                    { 52L, 18L, "/img/blog/Course/1.png" },
                    { 53L, 18L, "/img/blog/Course/2.png" },
                    { 54L, 18L, "/img/blog/Course/3.png" },
                    { 55L, 19L, "/img/blog/Course/1.png" },
                    { 56L, 19L, "/img/blog/Course/2.png" },
                    { 57L, 19L, "/img/blog/Course/3.png" },
                    { 58L, 20L, "/img/blog/Course/1.png" },
                    { 59L, 20L, "/img/blog/Course/2.png" },
                    { 60L, 20L, "/img/blog/Course/3.png" },
                    { 61L, 21L, "/img/blog/Course/1.png" },
                    { 62L, 21L, "/img/blog/Course/2.png" },
                    { 63L, 21L, "/img/blog/Course/3.png" },
                    { 64L, 22L, "/img/blog/Course/1.png" },
                    { 65L, 22L, "/img/blog/Course/2.png" },
                    { 66L, 22L, "/img/blog/Course/3.png" },
                    { 67L, 23L, "/img/blog/Course/1.png" },
                    { 68L, 23L, "/img/blog/Course/2.png" },
                    { 69L, 23L, "/img/blog/Course/3.png" },
                    { 70L, 24L, "/img/blog/Course/1.png" },
                    { 71L, 24L, "/img/blog/Course/2.png" },
                    { 72L, 24L, "/img/blog/Course/3.png" },
                    { 73L, 25L, "/img/blog/Course/1.png" },
                    { 74L, 25L, "/img/blog/Course/2.png" },
                    { 75L, 25L, "/img/blog/Course/3.png" },
                    { 76L, 26L, "/img/blog/Course/1.png" },
                    { 77L, 26L, "/img/blog/Course/2.png" },
                    { 78L, 26L, "/img/blog/Course/3.png" },
                    { 79L, 27L, "/img/blog/Course/1.png" },
                    { 80L, 27L, "/img/blog/Course/2.png" },
                    { 81L, 27L, "/img/blog/Course/3.png" },
                    { 82L, 28L, "/img/blog/Course/1.png" },
                    { 83L, 28L, "/img/blog/Course/2.png" },
                    { 84L, 28L, "/img/blog/Course/3.png" },
                    { 85L, 29L, "/img/blog/Course/1.png" },
                    { 86L, 29L, "/img/blog/Course/2.png" },
                    { 87L, 29L, "/img/blog/Course/3.png" },
                    { 88L, 30L, "/img/blog/Course/1.png" },
                    { 89L, 30L, "/img/blog/Course/2.png" },
                    { 90L, 30L, "/img/blog/Course/3.png" },
                    { 91L, 31L, "/img/blog/Course/1.png" },
                    { 92L, 31L, "/img/blog/Course/2.png" },
                    { 93L, 31L, "/img/blog/Course/3.png" },
                    { 94L, 32L, "/img/blog/Course/1.png" },
                    { 95L, 32L, "/img/blog/Course/2.png" },
                    { 96L, 32L, "/img/blog/Course/3.png" },
                    { 97L, 33L, "/img/blog/Course/1.png" },
                    { 98L, 33L, "/img/blog/Course/2.png" },
                    { 99L, 33L, "/img/blog/Course/3.png" },
                    { 100L, 34L, "/img/blog/Course/1.png" },
                    { 101L, 34L, "/img/blog/Course/2.png" },
                    { 102L, 34L, "/img/blog/Course/3.png" },
                    { 103L, 35L, "/img/blog/Course/1.png" },
                    { 104L, 35L, "/img/blog/Course/2.png" },
                    { 105L, 35L, "/img/blog/Course/3.png" },
                    { 106L, 36L, "/img/blog/Course/1.png" },
                    { 107L, 36L, "/img/blog/Course/2.png" },
                    { 108L, 36L, "/img/blog/Course/3.png" },
                    { 109L, 37L, "/img/blog/Course/1.png" },
                    { 110L, 37L, "/img/blog/Course/2.png" },
                    { 111L, 37L, "/img/blog/Course/3.png" },
                    { 112L, 38L, "/img/blog/Course/1.png" },
                    { 113L, 38L, "/img/blog/Course/2.png" },
                    { 114L, 38L, "/img/blog/Course/3.png" },
                    { 115L, 39L, "/img/blog/Course/1.png" },
                    { 116L, 39L, "/img/blog/Course/2.png" },
                    { 117L, 39L, "/img/blog/Course/3.png" },
                    { 118L, 40L, "/img/blog/Course/1.png" },
                    { 119L, 40L, "/img/blog/Course/2.png" },
                    { 120L, 40L, "/img/blog/Course/3.png" },
                    { 121L, 41L, "/img/blog/Course/1.png" },
                    { 122L, 41L, "/img/blog/Course/2.png" },
                    { 123L, 41L, "/img/blog/Course/3.png" },
                    { 124L, 42L, "/img/blog/Course/1.png" },
                    { 125L, 42L, "/img/blog/Course/2.png" },
                    { 126L, 42L, "/img/blog/Course/3.png" },
                    { 127L, 43L, "/img/blog/Course/1.png" },
                    { 128L, 43L, "/img/blog/Course/2.png" },
                    { 129L, 43L, "/img/blog/Course/3.png" },
                    { 130L, 44L, "/img/blog/Course/1.png" },
                    { 131L, 44L, "/img/blog/Course/2.png" },
                    { 132L, 44L, "/img/blog/Course/3.png" },
                    { 133L, 45L, "/img/blog/Course/1.png" },
                    { 134L, 45L, "/img/blog/Course/2.png" },
                    { 135L, 45L, "/img/blog/Course/3.png" },
                    { 136L, 46L, "/img/blog/Course/1.png" },
                    { 137L, 46L, "/img/blog/Course/2.png" },
                    { 138L, 46L, "/img/blog/Course/3.png" },
                    { 139L, 47L, "/img/blog/Course/1.png" },
                    { 140L, 47L, "/img/blog/Course/2.png" },
                    { 141L, 47L, "/img/blog/Course/3.png" },
                    { 142L, 48L, "/img/blog/Course/1.png" },
                    { 143L, 48L, "/img/blog/Course/2.png" },
                    { 144L, 48L, "/img/blog/Course/3.png" },
                    { 145L, 49L, "/img/blog/Course/1.png" },
                    { 146L, 49L, "/img/blog/Course/2.png" },
                    { 147L, 49L, "/img/blog/Course/3.png" },
                    { 148L, 50L, "/img/blog/Course/1.png" },
                    { 149L, 50L, "/img/blog/Course/2.png" },
                    { 150L, 50L, "/img/blog/Course/3.png" },
                    { 151L, 51L, "/img/blog/Course/1.png" },
                    { 152L, 51L, "/img/blog/Course/2.png" },
                    { 153L, 51L, "/img/blog/Course/3.png" },
                    { 154L, 52L, "/img/blog/Course/1.png" },
                    { 155L, 52L, "/img/blog/Course/2.png" },
                    { 156L, 52L, "/img/blog/Course/3.png" },
                    { 157L, 53L, "/img/blog/Course/1.png" },
                    { 158L, 53L, "/img/blog/Course/2.png" },
                    { 159L, 53L, "/img/blog/Course/3.png" },
                    { 160L, 54L, "/img/blog/Course/1.png" },
                    { 161L, 54L, "/img/blog/Course/2.png" },
                    { 162L, 54L, "/img/blog/Course/3.png" },
                    { 163L, 55L, "/img/blog/Course/1.png" },
                    { 164L, 55L, "/img/blog/Course/2.png" },
                    { 165L, 55L, "/img/blog/Course/3.png" }
                });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 1L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "4", "18 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 2L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "3", "5 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 3L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "4", "8 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 4L,
                column: "StudyTime",
                value: "11 hours");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 5L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "3", "6 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 6L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "3", "7 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 7L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "4", "3 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 8L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "2", "30 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 9L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "4", "15 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 10L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "4", "26 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 11L,
                column: "StudyTime",
                value: "26 hours");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 12L,
                column: "StudyTime",
                value: "5 hours");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 13L,
                column: "StudyTime",
                value: "15 hours");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 14L,
                column: "StudyTime",
                value: "9 hours");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 15L,
                column: "StudyTime",
                value: "14 hours");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 16L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "2", "9 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 17L,
                column: "MentorId",
                value: "4");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 19L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "3", "20 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 20L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "3", "28 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 21L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "4", "29 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 22L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "3", "12 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 23L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "2", "11 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 24L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "2", "19 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 25L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "2", "23 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 26L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "2", "5 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 27L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "4", "25 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 28L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "3", "28 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 29L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "4", "27 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 30L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "3", "3 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 31L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "2", "4 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 32L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "3", "29 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 33L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "2", "30 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 34L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "2", "20 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 35L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "4", "30 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 36L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "2", "30 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 37L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "2", "20 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 38L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "4", "28 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 39L,
                column: "StudyTime",
                value: "3 hours");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 40L,
                column: "MentorId",
                value: "4");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 41L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "4", "28 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 42L,
                column: "StudyTime",
                value: "11 hours");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 43L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "2", "24 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 44L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "2", "12 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 45L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "2", "10 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 46L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "4", "17 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 47L,
                column: "StudyTime",
                value: "8 hours");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 48L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "4", "13 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 49L,
                column: "StudyTime",
                value: "26 hours");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 50L,
                column: "StudyTime",
                value: "16 hours");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 51L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "2", "3 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 52L,
                column: "StudyTime",
                value: "16 hours");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 53L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "4", "15 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 54L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "4", "25 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 55L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "4", "21 hours" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 1L,
                columns: new[] { "Content", "IsRead", "ReceiverId", "SenderId" },
                values: new object[] { "Welcome aboard! We're thrilled to have you as part of our learning community.", false, "25", "2" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 2L,
                columns: new[] { "Content", "ReceiverId" },
                values: new object[] { "Did you know you can download course resources from the 'Materials' tab? Hope this helps!", "26" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 3L,
                columns: new[] { "Content", "IsRead", "ReceiverId", "SenderId" },
                values: new object[] { "A quick check-in to see how you are enjoying the platform. Any feedback is welcome!", true, "31", "2" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 4L,
                columns: new[] { "Content", "IsRead", "ReceiverId", "SenderId" },
                values: new object[] { "We have a new course on Advanced C# that you might be interested in. Check it out!", false, "37", "3" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 5L,
                columns: new[] { "IsRead", "ReceiverId", "SenderId" },
                values: new object[] { false, "12", "2" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 6L,
                columns: new[] { "Content", "ReceiverId" },
                values: new object[] { "Welcome aboard! We're thrilled to have you as part of our learning community.", "55" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 7L,
                columns: new[] { "IsRead", "ReceiverId" },
                values: new object[] { true, "27" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 8L,
                columns: new[] { "Content", "ReceiverId" },
                values: new object[] { "Welcome aboard! We're thrilled to have you as part of our learning community.", "10" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 9L,
                columns: new[] { "ReceiverId", "SenderId" },
                values: new object[] { "18", "2" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 10L,
                columns: new[] { "Content", "ReceiverId", "SenderId" },
                values: new object[] { "Welcome aboard! We're thrilled to have you as part of our learning community.", "29", "4" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 11L,
                columns: new[] { "IsRead", "ReceiverId" },
                values: new object[] { true, "27" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 12L,
                columns: new[] { "Content", "IsRead", "ReceiverId" },
                values: new object[] { "Hello! We noticed you're making great progress in your course. Keep up the excellent work!", false, "15" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 13L,
                columns: new[] { "Content", "IsRead", "ReceiverId", "SenderId" },
                values: new object[] { "A quick check-in to see how you are enjoying the platform. Any feedback is welcome!", true, "18", "3" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 14L,
                columns: new[] { "ReceiverId", "SenderId" },
                values: new object[] { "10", "2" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 15L,
                columns: new[] { "Content", "IsRead", "ReceiverId", "SenderId" },
                values: new object[] { "Do you have any questions or need assistance with your current lesson? We're here to help.", false, "49", "4" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 16L,
                columns: new[] { "Content", "ReceiverId", "SenderId" },
                values: new object[] { "Hello! We noticed you're making great progress in your course. Keep up the excellent work!", "9", "3" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 17L,
                columns: new[] { "Content", "ReceiverId", "SenderId" },
                values: new object[] { "A quick check-in to see how you are enjoying the platform. Any feedback is welcome!", "39", "3" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 18L,
                columns: new[] { "Content", "IsRead", "ReceiverId", "SenderId" },
                values: new object[] { "Your learning journey is inspiring! Don't hesitate to reach out to the community for discussions.", false, "43", "1" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 19L,
                columns: new[] { "Content", "ReceiverId", "SenderId" },
                values: new object[] { "A quick check-in to see how you are enjoying the platform. Any feedback is welcome!", "39", "3" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 20L,
                columns: new[] { "Content", "IsRead", "ReceiverId", "SenderId" },
                values: new object[] { "A quick check-in to see how you are enjoying the platform. Any feedback is welcome!", true, "27", "3" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 21L,
                columns: new[] { "Content", "IsRead", "ReceiverId", "SenderId" },
                values: new object[] { "Did you know you can download course resources from the 'Materials' tab? Hope this helps!", false, "28", "3" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 22L,
                columns: new[] { "Content", "ReceiverId", "SenderId" },
                values: new object[] { "Welcome aboard! We're thrilled to have you as part of our learning community.", "33", "3" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 23L,
                columns: new[] { "Content", "ReceiverId", "SenderId" },
                values: new object[] { "Did you know you can download course resources from the 'Materials' tab? Hope this helps!", "50", "1" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 24L,
                columns: new[] { "Content", "ReceiverId", "SenderId" },
                values: new object[] { "Welcome aboard! We're thrilled to have you as part of our learning community.", "46", "1" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 25L,
                columns: new[] { "Content", "ReceiverId", "SenderId" },
                values: new object[] { "Your learning journey is inspiring! Don't hesitate to reach out to the community for discussions.", "6", "3" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 26L,
                columns: new[] { "ReceiverId", "SenderId" },
                values: new object[] { "48", "4" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 27L,
                columns: new[] { "Content", "IsRead", "ReceiverId", "SenderId" },
                values: new object[] { "We have a new course on Advanced C# that you might be interested in. Check it out!", true, "22", "1" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 28L,
                columns: new[] { "Content", "IsRead", "ReceiverId", "SenderId" },
                values: new object[] { "Welcome aboard! We're thrilled to have you as part of our learning community.", true, "52", "4" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 29L,
                columns: new[] { "IsRead", "ReceiverId", "SenderId" },
                values: new object[] { false, "24", "4" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 30L,
                columns: new[] { "Content", "ReceiverId", "SenderId" },
                values: new object[] { "Welcome aboard! We're thrilled to have you as part of our learning community.", "32", "4" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 31L,
                columns: new[] { "IsRead", "ReceiverId", "SenderId" },
                values: new object[] { false, "27", "2" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 32L,
                columns: new[] { "Content", "IsRead", "SenderId" },
                values: new object[] { "Hello! We noticed you're making great progress in your course. Keep up the excellent work!", true, "2" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 33L,
                columns: new[] { "Content", "ReceiverId", "SenderId" },
                values: new object[] { "Did you know you can download course resources from the 'Materials' tab? Hope this helps!", "18", "2" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 34L,
                columns: new[] { "Content", "IsRead", "ReceiverId", "SenderId" },
                values: new object[] { "Do you have any questions or need assistance with your current lesson? We're here to help.", false, "37", "4" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 35L,
                columns: new[] { "Content", "IsRead", "ReceiverId" },
                values: new object[] { "Just a friendly reminder that a new module has been unlocked in your course.", false, "18" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 36L,
                columns: new[] { "Content", "IsRead", "ReceiverId", "SenderId" },
                values: new object[] { "We have a new course on Advanced C# that you might be interested in. Check it out!", true, "45", "3" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 37L,
                columns: new[] { "Content", "IsRead", "ReceiverId" },
                values: new object[] { "Did you know you can download course resources from the 'Materials' tab? Hope this helps!", true, "27" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 38L,
                columns: new[] { "Content", "ReceiverId" },
                values: new object[] { "A quick check-in to see how you are enjoying the platform. Any feedback is welcome!", "51" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 39L,
                columns: new[] { "Content", "ReceiverId", "SenderId" },
                values: new object[] { "Do you have any questions or need assistance with your current lesson? We're here to help.", "32", "3" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 40L,
                columns: new[] { "Content", "ReceiverId", "SenderId" },
                values: new object[] { "Just a friendly reminder that a new module has been unlocked in your course.", "27", "3" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 41L,
                columns: new[] { "Content", "ReceiverId" },
                values: new object[] { "Welcome aboard! We're thrilled to have you as part of our learning community.", "55" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 42L,
                columns: new[] { "Content", "ReceiverId", "SenderId" },
                values: new object[] { "Do you have any questions or need assistance with your current lesson? We're here to help.", "13", "2" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 43L,
                columns: new[] { "Content", "IsRead", "ReceiverId", "SenderId" },
                values: new object[] { "A quick check-in to see how you are enjoying the platform. Any feedback is welcome!", false, "45", "2" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 44L,
                columns: new[] { "Content", "IsRead", "ReceiverId", "SenderId" },
                values: new object[] { "Do you have any questions or need assistance with your current lesson? We're here to help.", false, "47", "1" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 45L,
                columns: new[] { "Content", "ReceiverId", "SenderId" },
                values: new object[] { "Did you know you can download course resources from the 'Materials' tab? Hope this helps!", "49", "4" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 46L,
                columns: new[] { "Content", "ReceiverId", "SenderId" },
                values: new object[] { "Do you have any questions or need assistance with your current lesson? We're here to help.", "8", "4" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 47L,
                columns: new[] { "Content", "IsRead", "ReceiverId", "SenderId" },
                values: new object[] { "Did you know you can download course resources from the 'Materials' tab? Hope this helps!", true, "9", "4" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 48L,
                columns: new[] { "Content", "ReceiverId", "SenderId" },
                values: new object[] { "Just a friendly reminder that a new module has been unlocked in your course.", "52", "4" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 49L,
                columns: new[] { "Content", "IsRead", "ReceiverId", "SenderId" },
                values: new object[] { "We have a new course on Advanced C# that you might be interested in. Check it out!", false, "16", "4" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 50L,
                columns: new[] { "Content", "ReceiverId" },
                values: new object[] { "We have a new course on Advanced C# that you might be interested in. Check it out!", "43" });

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 1L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8118));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 2L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8156));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 3L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8160));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 4L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8163));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 5L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8165));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 6L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8169));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 7L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8171));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 8L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8173));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 9L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8174));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 10L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8177));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 11L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8179));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 12L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8180));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 13L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8182));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 14L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8183));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 15L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8185));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 16L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8204));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 17L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8206));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 18L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8209));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 19L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8211));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 20L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8213));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 21L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8215));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 22L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8217));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 23L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8218));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 24L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8219));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 25L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8221));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 26L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8222));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 27L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8224));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 28L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8225));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 29L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8227));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 30L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8228));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 31L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8229));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 32L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8231));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 33L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8232));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 34L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8235));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 35L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8236));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 36L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8238));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 37L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8239));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 38L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8241));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 39L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8242));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 40L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8243));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 41L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8245));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 42L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8246));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 43L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8247));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 44L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8249));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 45L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8250));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 46L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8251));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 47L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8253));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 48L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8254));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 49L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8256));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 50L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8257));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 51L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8258));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 52L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8260));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 53L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8261));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 54L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8262));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 55L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8264));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 56L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8265));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 57L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8266));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 58L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8268));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 59L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8269));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 60L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8271));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 61L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8272));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 62L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8273));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 63L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8275));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 64L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8276));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 65L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8277));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 66L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8280));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 67L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8281));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 68L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8283));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 69L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8294));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 70L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8296));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 71L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8297));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 72L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8299));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 73L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8300));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 74L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8302));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 75L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8303));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 76L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8305));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 77L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8306));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 78L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8308));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 79L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8310));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 80L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8311));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 81L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8313));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 82L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8314));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 83L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8316));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 84L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8318));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 85L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8319));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 86L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8321));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 87L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8323));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 88L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8324));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 89L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8326));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 90L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8327));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 91L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 92L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8330));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 93L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8331));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 94L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8333));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 95L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8335));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 96L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8336));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 97L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8337));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 98L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8339));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 99L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8340));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 100L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8342));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 101L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8343));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 102L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8344));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 103L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8346));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 104L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8348));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 105L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8349));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 106L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8351));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 107L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8353));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 108L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8354));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 109L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8356));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 110L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8358));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 111L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8359));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 112L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8361));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 113L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8363));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 114L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8365));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 115L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8366));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 116L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8368));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 117L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8370));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 118L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8371));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 119L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8373));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 120L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8375));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 121L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8376));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 122L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8378));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 123L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8380));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 124L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8382));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 125L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8384));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 126L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8385));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 127L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8387));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 128L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8389));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 129L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8390));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 130L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8405));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 131L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8407));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 132L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8409));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 133L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8411));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 134L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8413));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 135L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8415));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 136L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8416));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 137L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8418));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 138L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8420));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 139L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8421));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 140L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8423));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 141L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8425));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 142L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8426));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 143L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8428));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 144L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8430));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 145L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8431));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 146L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8433));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 147L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8435));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 148L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8437));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 149L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8438));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 150L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8440));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 151L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8442));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 152L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8443));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 153L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8445));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 154L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8447));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 155L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8448));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 156L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8450));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 157L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8452));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 158L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8454));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 159L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8455));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 160L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8457));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 161L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8459));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 162L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8460));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 163L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 164L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8464));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 165L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8465));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 166L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8467));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 167L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8468));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 168L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8470));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 169L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8472));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 170L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8474));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 171L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8475));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 172L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8477));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 173L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8479));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 174L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8480));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 175L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8482));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 176L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8484));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 177L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8485));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 178L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8487));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 179L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8488));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 180L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8490));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 181L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8492));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 182L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8493));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 183L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8495));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 184L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8496));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 185L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8498));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 186L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8500));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 187L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8502));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 188L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8511));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 189L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8513));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 190L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8515));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 191L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8517));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 192L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8519));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 193L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8521));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 194L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8522));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 195L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8524));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 196L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8526));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 197L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8527));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 198L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8529));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 199L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8531));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 200L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8532));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 201L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8534));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 202L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8536));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 203L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8537));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 204L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8539));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 205L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8540));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 206L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 207L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8544));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 208L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8545));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 209L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8547));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 210L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8549));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 211L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8550));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 212L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8552));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 213L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8554));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 214L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8556));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 215L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8557));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 216L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8559));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 217L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8560));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 218L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8562));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 219L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8564));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 220L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8565));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 221L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8567));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 222L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8569));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 223L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8570));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 224L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8572));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 225L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8574));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 226L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8575));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 227L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8577));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 228L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8579));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 229L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8580));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 230L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8582));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 231L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8584));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 232L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8586));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 233L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8587));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 234L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8589));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 235L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8590));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 236L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8592));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 237L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8594));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 238L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8596));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 239L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8597));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 240L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8599));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 241L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8601));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 242L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8602));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 243L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8604));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 244L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8606));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 245L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8607));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 246L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8609));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 247L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8611));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 248L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8612));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 249L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8614));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 250L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8616));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 251L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8617));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 252L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8619));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 253L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8621));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 254L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8622));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 255L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8624));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 256L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8637));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 257L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8639));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 258L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8643));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 259L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8645));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 260L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8647));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 261L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8649));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 262L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8650));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 263L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8652));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 264L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8653));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 265L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8655));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 266L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8657));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 267L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8658));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 268L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8660));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 269L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8662));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 270L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8663));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 271L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8665));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 272L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8667));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 273L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8668));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 274L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8670));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 275L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8671));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 276L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8673));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 277L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8675));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 278L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8676));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 279L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8678));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 280L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8680));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 281L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8682));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 282L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8683));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 283L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8685));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 284L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8686));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 285L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8688));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 286L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8690));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 287L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8691));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 288L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8693));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 289L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8695));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 290L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8706));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 291L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8708));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 292L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8709));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 293L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8711));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 294L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8712));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 295L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8714));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 296L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8716));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 297L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8718));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 298L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8719));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 299L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8721));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 300L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8723));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 301L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8724));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 302L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8726));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 303L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8728));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 304L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8729));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 305L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8731));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 306L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8732));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 307L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8734));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 308L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8736));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 309L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8737));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 310L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8739));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 311L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8740));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 312L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8742));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 313L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8744));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 314L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8745));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 315L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8747));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 316L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8749));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 317L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8750));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 318L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8752));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 319L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8754));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 320L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8755));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 321L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8757));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 322L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8759));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 323L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8760));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 324L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8762));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 325L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8763));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 326L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8765));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 327L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8767));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 328L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8768));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 329L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8770));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 330L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8772));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 331L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8773));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 332L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8775));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 333L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8777));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 334L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8779));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 335L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8780));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 336L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8782));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 337L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8784));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 338L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8785));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 339L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8787));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 340L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8789));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 341L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8791));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 342L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8792));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 343L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8794));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 344L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8796));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 345L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8797));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 346L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8799));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 347L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8800));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 348L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8802));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 349L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8804));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 350L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8805));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 351L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8807));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 352L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8809));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 353L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8810));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 354L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8812));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 355L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8813));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 356L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8815));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 357L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8817));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 358L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8818));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 359L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8829));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 360L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8831));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 361L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8833));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 362L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8835));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 363L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8836));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 364L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8838));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 365L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8840));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 366L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8842));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 367L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8843));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 368L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8845));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 369L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8846));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 370L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8848));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 371L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8850));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 372L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8851));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 373L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8853));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 374L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8855));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 375L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8856));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 376L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8858));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 377L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8859));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 378L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8861));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 379L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8863));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 380L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8864));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 381L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8866));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 382L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8867));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 383L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8869));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 384L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8871));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 385L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8872));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 386L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8874));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 387L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8876));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 388L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8877));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 389L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8879));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 390L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8880));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 391L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8882));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 392L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8884));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 393L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8885));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 394L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8887));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 395L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8889));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 396L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8890));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 397L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8892));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 398L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8894));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 399L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8895));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 400L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8897));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 401L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8899));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 402L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8900));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 403L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8902));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 404L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8903));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 405L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8905));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 406L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8907));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 407L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8908));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 408L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8910));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 409L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8912));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 410L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8913));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 411L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8915));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 412L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8917));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 413L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8919));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 414L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8920));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 415L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8922));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 416L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8923));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 417L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8925));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 418L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8927));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 419L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8928));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 420L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8930));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 421L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8932));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 422L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8933));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 423L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8935));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 424L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8936));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 425L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8938));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 426L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8940));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 427L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8950));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 428L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8951));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 429L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8953));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 430L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8954));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 431L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8956));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 432L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8958));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 433L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8960));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 434L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8961));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 435L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8963));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 436L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8965));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 437L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8966));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 438L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8968));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 439L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8970));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 440L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8972));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 441L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8973));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 442L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8975));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 443L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8976));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 444L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8978));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 445L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8980));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 446L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8982));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 447L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8983));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 448L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8985));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 449L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8986));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 450L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8988));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 451L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8990));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 452L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8992));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 453L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8993));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 454L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8995));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 455L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8996));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 456L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(8998));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 457L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(9000));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 458L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(9001));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 459L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(9003));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 460L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(9005));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 461L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(9006));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 462L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(9008));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 463L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(9009));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 464L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(9011));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 465L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 20, 51, 44, 32, DateTimeKind.Local).AddTicks(9013));

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 1L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 78.68m, 31L, "Purchase of course 31" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 2L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 97.29m, 11L, "Purchase of course 11" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 3L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 24.09m, 16L, "Purchase of course 16" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 4L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 88.66m, 46L, "Purchase of course 46" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 5L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 56.19m, 36L, "Purchase of course 36" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 6L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 88.38m, 13L, "Purchase of course 13" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 7L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 94.69m, 32L, "Purchase of course 32" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 8L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 41.17m, 6L, "Purchase of course 6" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 9L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 95.64m, 54L, "Purchase of course 54" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 10L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 76.33m, 30L, "Purchase of course 30" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 11L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 80.31m, 37L, "Purchase of course 37" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 12L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 39.18m, 32L, "Purchase of course 32" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 13L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 64.54m, 43L, "Purchase of course 43" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 14L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 83.84m, 51L, "Purchase of course 51" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 15L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 41.71m, 22L, "Purchase of course 22" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 16L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 31.38m, 46L, "Purchase of course 46" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 17L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 37.09m, 19L, "Purchase of course 19" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 18L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 69.15m, 26L, "Purchase of course 26" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 19L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 27.14m, 23L, "Purchase of course 23" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 20L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 72.90m, 28L, "Purchase of course 28" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 21L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 96.27m, 33L, "Purchase of course 33" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 22L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 30.37m, 35L, "Purchase of course 35" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 23L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 67.56m, 11L, "Purchase of course 11" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 24L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 35.97m, 16L, "Purchase of course 16" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 25L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 58.07m, 34L, "Purchase of course 34" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 26L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 38.61m, 47L, "Purchase of course 47" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 27L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 69.41m, 25L, "Purchase of course 25" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 28L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 41.56m, 52L, "Purchase of course 52" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 29L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 60.57m, 8L, "Purchase of course 8" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 30L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 76.47m, 4L, "Purchase of course 4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "3a130885-e2f9-499f-9e30-9f27d64a167d", "AQAAAAIAAYagAAAAEOJGNe5F98B0VFcP+RRua9n3rfgkyh2a/JHJMtNHJ4KRRzjXJ7HORs7JQ2wVan61Xg==", "4c954dc0-c34a-4d4f-bc73-e71cf0d64031", new DateTime(2025, 10, 18, 20, 51, 40, 791, DateTimeKind.Local).AddTicks(5494) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "1cac5338-4eef-42b0-aef5-f9d39102ea31", "AQAAAAIAAYagAAAAEOOSj/+eRO0TypiaZ5U4EKdTwNNQ+APfnQJtgifHDQnA73mmWkJHXQckIs7KSwnRxA==", "5b5bdf9e-402a-4e29-a68b-24b0d567b27a", new DateTime(2025, 10, 18, 20, 51, 41, 358, DateTimeKind.Local).AddTicks(1458) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "87c15a7c-12f5-424d-a211-16bbc12a408d", "AQAAAAIAAYagAAAAECYtBmOsxhVTX8FcJvPlShPR9ZX8NQhZt6Zo3h36lG6DAEDDkLS/E5yIrXeS9A74pQ==", "cc982502-c203-4604-bc0f-dcdc222f9d73", new DateTime(2025, 10, 18, 20, 51, 41, 413, DateTimeKind.Local).AddTicks(7425) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "52d9b21a-57aa-4779-bbb4-c8bf63f43e0d", "AQAAAAIAAYagAAAAEEMFzBnRObCc2sAnYE7eACaIZiJiqYC62FFd/BVFnE4/5ZhrXrBjWHO/wEKAFEUX+Q==", "c92901a4-2387-433d-b67c-bc0de6b07b49", new DateTime(2025, 10, 18, 20, 51, 41, 472, DateTimeKind.Local).AddTicks(7937) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "cf559745-dd1c-4889-a378-d29e9925ec21", "AQAAAAIAAYagAAAAEHP/RQeA7L+MGGypm8QjHwrQOzM0yT+yDlm4L+XmpFj9jMnrmzr9R+LBdpMRDXmAlg==", "fcaceb49-2c56-4e08-8df0-ec3b39ca8338", new DateTime(2025, 10, 18, 20, 51, 41, 535, DateTimeKind.Local).AddTicks(9811) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "663bcaeb-eefd-4a63-8d19-cf97724d8fb3", "AQAAAAIAAYagAAAAEEgRsSYYhlEejT3cwsJeSsfYEZhiYbKeV5l3COnGNCpl6zdRYUR0nMtHHaqW0VJHOQ==", "2668656d-e8dd-4966-bcb1-e76c63138426", new DateTime(2025, 10, 18, 20, 51, 41, 593, DateTimeKind.Local).AddTicks(612) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "42886ba1-34b8-41ca-a749-eb029a8778f2", "AQAAAAIAAYagAAAAEMVfbAzgRr3sy0o/W052zqBHYagjsHkessP1tcIGCKU2GCQRs+5KVQRBW79z1SxWqA==", "d5287be1-c7c0-4a75-b0c1-381b561523c1", new DateTime(2025, 10, 18, 20, 51, 41, 649, DateTimeKind.Local).AddTicks(1012) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "d0f22a8f-2be9-445c-a3ab-84751944c3a4", "AQAAAAIAAYagAAAAEJN9CKITr6izdU9Y6wgjd+qvL+Ne4nCDKv8PDTEcfhMl5HTu8q2tkELHWMVTq/Auog==", "63c1640e-e96d-4bd0-a263-4402cada4148", new DateTime(2025, 10, 18, 20, 51, 41, 705, DateTimeKind.Local).AddTicks(3037) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "26415738-8a42-4ac8-8b74-a9f13c944fa8", "AQAAAAIAAYagAAAAEDK8xOcVA8sBc7vjj0tyoDqEXvHvwZnowE1KUCoqgW1+PjPXmMqetRt+FUUOxwF4zA==", "edab0aa3-ab0a-43ea-95a2-6abf0fbb5cf4", new DateTime(2025, 10, 18, 20, 51, 41, 762, DateTimeKind.Local).AddTicks(3124) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "6efa7615-d3dd-4c9a-a7a2-d54342b7e4a8", "AQAAAAIAAYagAAAAEH5ehCVyiUga5QdMWGPaX1Vq5XIsE9f6NQEC8TMVZQ9R6AsGlKQ2vd1Tik1pwut6Ww==", "c17d5c4e-3693-4434-acd4-93ba436ab005", new DateTime(2025, 10, 18, 20, 51, 41, 819, DateTimeKind.Local).AddTicks(9394) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "d3e7af9d-bc23-4b68-a6ad-9efddd0a3929", "AQAAAAIAAYagAAAAEJTdSZk1005Lyunh4ct7rFS8fmD4RsjEUzf6DI7LuVPBbHGoajucKmGN9koIW2UH3g==", "a870a4e3-a335-44de-a76f-4aa6631fc856", new DateTime(2025, 10, 18, 20, 51, 41, 879, DateTimeKind.Local).AddTicks(595) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "2447018e-4780-4e27-b55f-b5b24e3af2e0", "AQAAAAIAAYagAAAAEEIyKjfS60tRc8oud7MGy5ofgRnqPDPW+2pB8y/wdsb4ihFSe5Qr3hgnaGXAZwUIpA==", "79f84a6d-3b33-4a6c-9966-c5d83de6a7c1", new DateTime(2025, 10, 18, 20, 51, 40, 846, DateTimeKind.Local).AddTicks(8070) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "c5bbc7f2-083d-4cb4-adfc-1094e30920b1", "AQAAAAIAAYagAAAAEPfK8WkjMBMrl6FGQbbzXiOmTQ6d+Mk+PiaeApfujTB2xA9/ykhqfqmKto4jyjIWOw==", "3303d913-060e-486f-8678-538bccedf8ca", new DateTime(2025, 10, 18, 20, 51, 41, 934, DateTimeKind.Local).AddTicks(4182) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "75c3c242-6520-47df-8ad4-74b874ebe357", "AQAAAAIAAYagAAAAEL1Z2+tl5Sj1Av43Q23O/8CuJw5lDgXSsyKkJrCW+082KVboqOGP8kCGr5qn9lbzoA==", "bb6c89a6-c009-4160-850f-64ac6891ed7c", new DateTime(2025, 10, 18, 20, 51, 41, 991, DateTimeKind.Local).AddTicks(9459) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "6bb7db93-201c-4e8c-9717-3a2e1b37c383", "AQAAAAIAAYagAAAAEEMpyMVexRbXpsRRZntJJYIkPiZ/XniJ3BAmZUKnS1nlKpzPVYrsNLvmxuPZqKRzMQ==", "72f457ab-ed9a-4869-93a0-5ff8d83d32a0", new DateTime(2025, 10, 18, 20, 51, 42, 47, DateTimeKind.Local).AddTicks(5061) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "23",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "eaba89cd-1988-4a5d-85a6-b635a092420f", "AQAAAAIAAYagAAAAEJE0nsBHgpAjdQBp+J5h4EbYHgYPUkoB5h7EkHfz43H/y3qF519JwEodro/5eSa1jA==", "691022a5-1dad-4d17-82c3-7de88b05b497", new DateTime(2025, 10, 18, 20, 51, 42, 106, DateTimeKind.Local).AddTicks(1021) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "24",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "f0233414-c0b2-4508-9d32-2708e3aa27db", "AQAAAAIAAYagAAAAELT/YXke4yD/mAU3h0RMDE0ghE9SYdG9YEVwMjCo0i6fPkSMYrLLXDuue5TwfWBnPQ==", "7dfc7e7f-acb7-4463-a5db-4948a8394b3b", new DateTime(2025, 10, 18, 20, 51, 42, 162, DateTimeKind.Local).AddTicks(2743) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "25",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "394af055-4f0d-4bba-88ce-29063cc2a44a", "AQAAAAIAAYagAAAAECLbEP8Z8OSDK+8wZNygYmRUg855GqqMWTpYa/PxcIDuWD/oQOYl/6kC0U8m+s7ncg==", "d45d94b0-cef2-4748-ae51-0e9cd47fae5b", new DateTime(2025, 10, 18, 20, 51, 42, 220, DateTimeKind.Local).AddTicks(2086) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "26",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "5e96a422-6925-48f7-ab7c-ca64a39eb54e", "AQAAAAIAAYagAAAAEP1h89F23KsIS8Ii+dOr25KRsmKr4h0vkncmsLyYtjnfSm1JXUsIKxTwjdyQh/iYdA==", "775455e2-4479-4313-8661-d29a901a8695", new DateTime(2025, 10, 18, 20, 51, 42, 275, DateTimeKind.Local).AddTicks(6646) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "a3996737-9c46-438a-bfaa-c48b73b1bfc0", "AQAAAAIAAYagAAAAEHEHalJonVaUI253MwnLx9kJslTgpzjvHeSIIG/H3h3NtjQ8rqlS2J1vaLzjhl+X0g==", "b0b6a67b-8fb5-45a3-bd1b-fa47e03d1a10", new DateTime(2025, 10, 18, 20, 51, 42, 335, DateTimeKind.Local).AddTicks(1967) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "28",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "9e2f32c0-2498-488d-b724-f53b8f502fb5", "AQAAAAIAAYagAAAAECZErJR+ahdM/nbrGPjcIw0EMcFFnKkcOwj4HGs7hd8VRtDRYSNI7SwXkNUZ00oQfA==", "b5a6b94e-7477-4c66-9d27-9d041f0cf085", new DateTime(2025, 10, 18, 20, 51, 42, 391, DateTimeKind.Local).AddTicks(3637) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "29",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "a61ffea7-62ab-40df-aacd-f463ce2bfd0f", "AQAAAAIAAYagAAAAEFdZaD67v5lp6f/cG1veyog7J19X5Lm26iGjJt0lnSEBY6Joh+HvzJNH2F1LiNi/tw==", "75d335b6-4837-4df9-8e9a-521cce397b47", new DateTime(2025, 10, 18, 20, 51, 42, 450, DateTimeKind.Local).AddTicks(9852) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "d8f544d3-bd5e-49c5-b3fc-dd0f5761f62a", "AQAAAAIAAYagAAAAEDgXQUiG715zpRZJrKMOi+//rZ0tuNmoj+be/U6gPhykFWlKbeVL6xadsE/NsoGMhQ==", "7992771b-7b5c-47bf-beab-1024318a4cda", new DateTime(2025, 10, 18, 20, 51, 40, 901, DateTimeKind.Local).AddTicks(4978) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "30",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "3dd35a9b-95ac-490b-bd59-9c6a59a0323f", "AQAAAAIAAYagAAAAEFDRnPaPPMH8hYN2jw44UCo5PBSu2w2rIj5hlQ7vYb6zIesUGU4XfU2Ydk6KPLDgrA==", "a7f21914-5c63-46fc-b8dc-abcacd99e79c", new DateTime(2025, 10, 18, 20, 51, 42, 507, DateTimeKind.Local).AddTicks(6826) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "31",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "3043ad6c-b88d-4c9f-82ab-7cee60929f44", "AQAAAAIAAYagAAAAELITn+zmTOKIW89wgNP2F4MTduZjByLpna+jWLhHpuVPWSmudE5B0cWAS33fENwQfw==", "65819a7b-acf4-4e68-bfd3-e1375f87c18c", new DateTime(2025, 10, 18, 20, 51, 42, 565, DateTimeKind.Local).AddTicks(8812) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "32",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "47623761-2727-4bde-bd0b-b2001ed5807d", "AQAAAAIAAYagAAAAEMhD4eG9ZGNbY5BgHph/lF4geZregx86PViuWExavSnSIho/eja9x6CFOI5gNRxLow==", "2ed237da-40f2-4aa0-8cb7-8d74d4360355", new DateTime(2025, 10, 18, 20, 51, 42, 624, DateTimeKind.Local).AddTicks(971) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "33",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "da82f5c3-cd06-4c03-81d5-d7f8c8310ee5", "AQAAAAIAAYagAAAAEIQH1ybNcvTxneRRsS1RBvyVpJHZMUM6N7EmCXrvc5ToOHPeRxpk14ft0wrtZuqNYQ==", "30e7bb5a-3bba-4595-bebc-c9347b15a8e6", new DateTime(2025, 10, 18, 20, 51, 42, 681, DateTimeKind.Local).AddTicks(7119) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "34",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "7c502f0d-a2a3-43c9-982f-ab8ca48fb502", "AQAAAAIAAYagAAAAEMq2g/6k5B4BE2iV7q9VlkfUFVPn4fNoBX63JA39wcUPjWQUzzPjLe5nezLZdIylfA==", "51da5a5e-1f05-4f4b-b666-a524355c727a", new DateTime(2025, 10, 18, 20, 51, 42, 737, DateTimeKind.Local).AddTicks(5301) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "35",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "3bb71519-ece5-46f9-95c6-85e6ec435553", "AQAAAAIAAYagAAAAEG2yA4dl86uVwrP8ec1u9gNBr9KesBFEW4Atg/81WqlfAW28BJG5OQAdgrjFaE001Q==", "460a7e1f-428b-4f9a-b7aa-f87b9d26e72e", new DateTime(2025, 10, 18, 20, 51, 42, 793, DateTimeKind.Local).AddTicks(2533) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "36",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "a5a5d026-e4fb-4afc-95c2-cd121a0d779f", "AQAAAAIAAYagAAAAEMgfzqwS4Zy3zy8NOkKWS140+tt3bwr80JskADqlFeB3CFK6s/Rh0B5/L1UkzU+cFg==", "67b8ffdb-08a2-432f-a5a0-0fb13a0241a8", new DateTime(2025, 10, 18, 20, 51, 42, 849, DateTimeKind.Local).AddTicks(9566) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "37",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "7dd159ed-de49-4f6a-b90b-92302f7d9ed9", "AQAAAAIAAYagAAAAEOKCfE5isgIJsODJD44qi1z10u9xc22VgJ+LzIZANBlAEIarXEujYsXxArauIqyeBg==", "bfd989fe-327d-4854-9c21-a19c4b181bc4", new DateTime(2025, 10, 18, 20, 51, 42, 906, DateTimeKind.Local).AddTicks(3569) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "38",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "c47dcb30-febf-42d2-8eb0-12be40219ebf", "AQAAAAIAAYagAAAAEEtOv0Lqh2/7aHA2xcQoV3CXRRN4yU7kvL2XqAJHbDnlKHpZ9cHloLL0fXpjo7zwcw==", "dd2722af-950b-4366-8a6e-967de8f70ce9", new DateTime(2025, 10, 18, 20, 51, 42, 962, DateTimeKind.Local).AddTicks(9030) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "39",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "2c8938ec-06ce-4545-8988-a6292d9a7ede", "AQAAAAIAAYagAAAAEDybP/0io9QhThkzsC9N+2cK13Xf34vOjxqAn+rLHE59UWaLOZ1u38B5dkZQQ9SH/A==", "28ffefd2-6e5a-4464-8d63-2bb462b62dcf", new DateTime(2025, 10, 18, 20, 51, 43, 18, DateTimeKind.Local).AddTicks(8028) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "43ce08a2-4e00-4182-9f41-96b1703dae8c", "AQAAAAIAAYagAAAAEBjbE3mmE3WXWwNQ8uWKIiVgv9D6KooRaDesoKUgGNjEjQowaL0EaKHbde+yaNBfBQ==", "792a0989-c933-40ea-b4cf-507e5bca1b73", new DateTime(2025, 10, 18, 20, 51, 40, 968, DateTimeKind.Local).AddTicks(9426) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "40",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "5a2fa8c6-7208-4a7f-8280-d6089e2240d3", "AQAAAAIAAYagAAAAEN3IspI/K4FSwUuLKejsqS8Rx8Pi0x1+DIr/TrEZFPtgs6oNteQdrhYWb3aSRItP7Q==", "9158c4c3-7e9b-48e4-8418-abf7a504c418", new DateTime(2025, 10, 18, 20, 51, 43, 76, DateTimeKind.Local).AddTicks(9271) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "41",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "d8e31705-a635-4a06-ae23-7785419fa06c", "AQAAAAIAAYagAAAAEEvsE2+HXG9EMRQPTxWVE+4aOLuuSP+WEpE9ZkmjKgNRtusPQIg9n9fx5jgOIez7Xg==", "6eeb14ea-2167-41a9-81c6-05fa519ba480", new DateTime(2025, 10, 18, 20, 51, 43, 134, DateTimeKind.Local).AddTicks(7610) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "42",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "6f45cc4a-d11b-4a7b-a6eb-7c164ce2065c", "AQAAAAIAAYagAAAAEPG0cPk1zNzs7nu1HFSF6krW0gEoozNEN402bSfMyTLySWC91eGEJOJXqAsKdHKukw==", "93254ae6-db56-4ed6-844b-c0f178bfaa86", new DateTime(2025, 10, 18, 20, 51, 43, 190, DateTimeKind.Local).AddTicks(8818) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "43",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "702413bf-b324-407c-933b-cf68312bdaeb", "AQAAAAIAAYagAAAAEHdzbhmOoP3A/aYYZSz/fF8ndYoC+quuU/vhsXrhavezUkPsw8ciKjKPt+dVmtJakA==", "519395ac-38f3-4b82-bc00-e8e27eb534f6", new DateTime(2025, 10, 18, 20, 51, 43, 250, DateTimeKind.Local).AddTicks(2729) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "44",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "cbab3eb8-658b-4cf2-9b22-b1705d093a87", "AQAAAAIAAYagAAAAEKTTcKDcyk0dGE5pVXg1kZ/1+yBycxC2w7L8OQZghbxPcWa+PpTQA4X6dD7kUW4X/w==", "720e4ba8-ac31-4be6-ab6a-29e193eb7bbf", new DateTime(2025, 10, 18, 20, 51, 43, 305, DateTimeKind.Local).AddTicks(6436) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "45",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "44a2a812-b758-4bdc-9d57-40de62db9590", "AQAAAAIAAYagAAAAEMyQ0gh9E1uZK+0RlT8aSHhdXgKl8nOcgO1y98zEhdbmCRyKo5Bmop4pqeFFKAlsQg==", "556173a7-ac5b-43ae-beee-a89f291f08ac", new DateTime(2025, 10, 18, 20, 51, 43, 365, DateTimeKind.Local).AddTicks(1631) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "46",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "1db70e61-20a5-4205-ad6d-99f25a222854", "AQAAAAIAAYagAAAAED56vdNYqBxv7I3e0hatcqkqvCBn37sgstfP57+jRdk0pnPER4U//EZ+4HWSosfEmw==", "d4a0ba51-edb5-4270-aeb5-db6bfcfc9a74", new DateTime(2025, 10, 18, 20, 51, 43, 423, DateTimeKind.Local).AddTicks(4817) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "47",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "2119459d-fdf3-49d3-90b9-39d5728d8526", "AQAAAAIAAYagAAAAEDe1lEPay2+11S1ymu1kWnC56B9lPHnUFUQGRyP6crHJ/6dCjcOBTAavQ4MexS5NcQ==", "3d4f2ff1-10a0-489e-bf2f-5a3569206cf4", new DateTime(2025, 10, 18, 20, 51, 43, 480, DateTimeKind.Local).AddTicks(8173) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "48",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "19ea1832-32e1-4d69-bc98-7cce2f02f400", "AQAAAAIAAYagAAAAEAMiKD0+DMkThLv7OGSHXRnP3xHAUugbijWGqdN8z3bA8/COaBjalAT3M66KlPouOA==", "24e4efaf-d2c0-4cd2-b0a4-614ac9f4fbe4", new DateTime(2025, 10, 18, 20, 51, 43, 538, DateTimeKind.Local).AddTicks(5837) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "49",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "c79a7b60-7606-475b-bfaf-c803471509ad", "AQAAAAIAAYagAAAAEIxUkrz6F4XIBcCrwZdyQkZ6shkMInSzrRPW57JbbNusNNmVEfY69QoB0Bketsav3w==", "69d255b0-0ff3-4c6e-b6fd-d06d50052525", new DateTime(2025, 10, 18, 20, 51, 43, 601, DateTimeKind.Local).AddTicks(92) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "25e173bb-437c-4910-a90f-f413c0c42ed2", "AQAAAAIAAYagAAAAEPb64/+ugt+K6hsl+wW32961E+C7ZluJwKqTine4lVXigtqGAATxu+/+1ANcdDqVUw==", "4eecd7b4-274f-41f8-bbcb-0a49ecdbf4f7", new DateTime(2025, 10, 18, 20, 51, 41, 33, DateTimeKind.Local).AddTicks(3785) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "50",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "018e13a6-924a-47c9-bf86-53eecbf45502", "AQAAAAIAAYagAAAAEL0/OSiubonb1C27nog8xmsDn+asL1bVAj/tHeA3rq0pINCRJ5CmQ/92l4gLkmfnTg==", "fb2aa41a-c212-4bc1-a5bc-5f35b41903db", new DateTime(2025, 10, 18, 20, 51, 43, 667, DateTimeKind.Local).AddTicks(5837) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "51",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "cc05f09f-2208-4fd2-9d7c-083c39f56bbf", "AQAAAAIAAYagAAAAEMbjTopphvl20tELWjl8Jsj5x0/BSt27VSUD8vXUaQpY53ueJxZHgCdhq6X4uCj7hg==", "bd7599f0-acff-4cee-8728-25d95240e398", new DateTime(2025, 10, 18, 20, 51, 43, 727, DateTimeKind.Local).AddTicks(4003) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "52",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "77dfc26f-8f91-4cce-998a-5e0ae4615eb4", "AQAAAAIAAYagAAAAENRwA6OY8aXGKV4kebE0XISQdePKyIAbX5ZGdO0dSq0b4HIyXRw7F9O+LF5MmaRTgQ==", "2e0b9949-49d1-4202-aa51-6902a75f032e", new DateTime(2025, 10, 18, 20, 51, 43, 783, DateTimeKind.Local).AddTicks(5890) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "53",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "75dba93d-b559-48d8-97f0-fa8c7aafe316", "AQAAAAIAAYagAAAAEAIs9SIUKFGMK20XaNf2YVOCMeEJV3ubDXoZm8IW7AMOTznVIx2mCzqgFfAZ8r+54A==", "bd4910bf-a901-4f39-b769-95a6b442fee4", new DateTime(2025, 10, 18, 20, 51, 43, 844, DateTimeKind.Local).AddTicks(5865) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "54",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "aaeef688-eab4-47e7-a0d1-729bbecb0827", "AQAAAAIAAYagAAAAEGHQMT7gorYKBqRaNml0JYv5NFiUbOv2GHuxc+H0EB4tF4+PqA/yvhn/97HoXzojOw==", "75f6072e-5664-46ac-a766-ecb64aa195e2", new DateTime(2025, 10, 18, 20, 51, 43, 908, DateTimeKind.Local).AddTicks(6849) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "55",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "6d27f7c0-8c8b-4653-bb5a-d3fc91c8aa39", "AQAAAAIAAYagAAAAEDNXcAkp2uxhxavqSBZXH/WgZGJt4Jhqv/EWbGHYOlbWKg1PYULkin+V4EKJb0XteQ==", "a75422f7-3e55-4045-9c4f-ab9b7952643a", new DateTime(2025, 10, 18, 20, 51, 43, 970, DateTimeKind.Local).AddTicks(1141) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "7fef04a0-089c-4dbc-81cc-5f6dda8d9609", "AQAAAAIAAYagAAAAEA1sNPBxvm2CJZT0snDBqJTdX47BvmrRpZtKWOjEPaQEZCOfg7rkwo+MFMNkDUONzg==", "d8d92a25-03d6-4015-b622-568ef7d6636e", new DateTime(2025, 10, 18, 20, 51, 41, 88, DateTimeKind.Local).AddTicks(5969) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "8819e6e7-137f-425f-9d2e-29a0df6138f1", "AQAAAAIAAYagAAAAEM1U7VIEBcZNuJmwAdpR1ZWPdtcAqPgxahk0tlQtmC65+oCn0VlIqjN24dvZqNc7RA==", "8668a496-0ab1-4ddb-a6d0-7fc114d2bf95", new DateTime(2025, 10, 18, 20, 51, 41, 163, DateTimeKind.Local).AddTicks(4603) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "90d620b2-fc13-4766-b3d1-e56a41e00ea1", "AQAAAAIAAYagAAAAEFzsZqoqUCbGCALzNq1yBbFqpgiU9YCnYX0CNQ0Y2fwGdsgAxK0IoKPreWr9MGs00w==", "dc6cebca-dfd8-47ca-923e-e3c52d113ae8", new DateTime(2025, 10, 18, 20, 51, 41, 245, DateTimeKind.Local).AddTicks(9314) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "04241c18-e442-4e3c-b894-befa201e9dbe", "AQAAAAIAAYagAAAAEKznNz5m5oIXwI5tmasRcCxH2rIzUoBTZ5HvgktGedmKtPaye4r1xM7Zo7LWs8WyFw==", "fbb6c364-6940-4d09-9fd9-914d536d538f", new DateTime(2025, 10, 18, 20, 51, 41, 301, DateTimeKind.Local).AddTicks(9917) });

            migrationBuilder.InsertData(
                table: "WishLists",
                columns: new[] { "CourseId", "UserId", "CreatedAt" },
                values: new object[,]
                {
                    { 9L, "5", new DateTime(2025, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 23L, "5", new DateTime(2025, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 24L, "5", new DateTime(2025, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 27L, "5", new DateTime(2025, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 29L, "5", new DateTime(2025, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 43L, "5", new DateTime(2025, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 50L, "5", new DateTime(2025, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14L, "6", new DateTime(2025, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16L, "6", new DateTime(2025, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 22L, "6", new DateTime(2025, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 23L, "6", new DateTime(2025, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 32L, "6", new DateTime(2025, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 38L, "6", new DateTime(2025, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 42L, "6", new DateTime(2025, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5L, "7", new DateTime(2025, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8L, "7", new DateTime(2025, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 26L, "7", new DateTime(2025, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 29L, "7", new DateTime(2025, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 40L, "7", new DateTime(2025, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 43L, "7", new DateTime(2025, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 45L, "7", new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 23L, 1L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 36L, 2L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 49L, 2L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 32L, 4L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 48L, 4L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 12L, 5L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 30L, 5L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 40L, 5L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 52L, 6L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 53L, 6L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 55L, 6L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 53L, 7L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 5L, 8L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 30L, 8L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 34L, 8L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 27L, 9L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 40L, 9L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 52L, 9L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 2L, 10L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 24L, 10L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 51L, 10L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 9L, 11L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 40L, 11L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 46L, 11L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 2L, 12L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 13L, 12L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 18L, 12L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 1L, 13L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 45L, 13L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 24L, 14L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 38L, 14L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 51L, 14L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 46L, 15L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 50L, 15L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 20L, 16L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 39L, 16L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 53L, 16L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 51L, 18L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 16L, 19L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 37L, 19L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 46L, 19L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 21L, 20L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 46L, 21L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 1L, 22L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 27L, 22L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 36L, 22L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 15L, 23L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 17L, 23L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 50L, 23L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 45L, 24L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 5L, 25L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 32L, 25L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 9L, 26L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 24L, 26L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 30L, 26L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 3L, 27L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 10L, 27L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 53L, 27L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 1L, 28L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 14L, 29L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 25L, 29L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 42L, 29L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 6L, 30L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 50L, 30L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 14L, 31L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 16L, 31L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 51L, 32L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 1L, 33L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 2L, 33L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 44L, 33L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 13L, 34L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 27L, 34L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 45L, 34L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 25L, 35L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 27L, 35L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 7L, 36L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 19L, 36L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 48L, 36L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 4L, 37L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 14L, 37L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 32L, 37L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 18L, 38L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 20L, 38L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 30L, 38L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 18L, 39L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 47L, 39L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 12L, 40L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 23L, 41L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 46L, 41L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 20L, 42L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 18L, 43L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 24L, 43L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 55L, 43L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 10L, 44L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 43L, 44L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 30L, 45L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 13L, 46L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 43L, 46L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 6L, 47L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 10L, 48L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 33L, 48L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 31L, 49L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 5L, 50L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 14L, 50L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 50L, 50L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 6L, 51L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 8L, 51L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 16L, 52L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 48L, 52L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 34L, 53L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 20L, 55L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 26L, 55L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 35L, 55L });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 1L, "5" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 5L, "5" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 5L, "7" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 7L, "7" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 9L, "6" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 10L, "7" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 12L, "5" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 17L, "5" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 17L, "7" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 19L, "7" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 20L, "6" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 21L, "6" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 23L, "5" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 24L, "5" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 25L, "5" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 25L, "7" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 26L, "6" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 27L, "5" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 27L, "7" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 29L, "6" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 30L, "5" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 30L, "7" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 32L, "6" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 34L, "7" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 35L, "7" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 36L, "6" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 37L, "5" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 37L, "6" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 41L, "7" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 42L, "6" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 43L, "6" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 52L, "5" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 53L, "5" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 54L, "6" });

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 37L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 38L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 39L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 40L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 41L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 42L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 43L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 44L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 45L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 46L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 47L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 48L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 49L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 50L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 51L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 52L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 53L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 54L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 55L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 56L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 57L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 58L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 59L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 60L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 61L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 62L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 63L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 64L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 65L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 66L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 67L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 68L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 69L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 70L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 71L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 72L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 73L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 74L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 75L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 76L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 77L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 78L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 79L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 80L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 81L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 82L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 83L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 84L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 85L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 86L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 87L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 88L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 89L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 90L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 91L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 92L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 93L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 94L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 95L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 96L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 97L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 98L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 99L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 100L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 101L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 102L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 103L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 104L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 105L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 106L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 107L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 108L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 109L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 110L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 111L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 112L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 113L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 114L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 115L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 116L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 117L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 118L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 119L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 120L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 121L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 122L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 123L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 124L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 125L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 126L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 127L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 128L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 129L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 130L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 131L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 132L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 133L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 134L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 135L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 136L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 137L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 138L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 139L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 140L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 141L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 142L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 143L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 144L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 145L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 146L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 147L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 148L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 149L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 150L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 151L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 152L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 153L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 154L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 155L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 156L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 157L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 158L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 159L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 160L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 161L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 162L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 163L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 164L);

            migrationBuilder.DeleteData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 165L);

            migrationBuilder.DeleteData(
                table: "WishLists",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 9L, "5" });

            migrationBuilder.DeleteData(
                table: "WishLists",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 23L, "5" });

            migrationBuilder.DeleteData(
                table: "WishLists",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 24L, "5" });

            migrationBuilder.DeleteData(
                table: "WishLists",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 27L, "5" });

            migrationBuilder.DeleteData(
                table: "WishLists",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 29L, "5" });

            migrationBuilder.DeleteData(
                table: "WishLists",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 43L, "5" });

            migrationBuilder.DeleteData(
                table: "WishLists",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 50L, "5" });

            migrationBuilder.DeleteData(
                table: "WishLists",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 14L, "6" });

            migrationBuilder.DeleteData(
                table: "WishLists",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 16L, "6" });

            migrationBuilder.DeleteData(
                table: "WishLists",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 22L, "6" });

            migrationBuilder.DeleteData(
                table: "WishLists",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 23L, "6" });

            migrationBuilder.DeleteData(
                table: "WishLists",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 32L, "6" });

            migrationBuilder.DeleteData(
                table: "WishLists",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 38L, "6" });

            migrationBuilder.DeleteData(
                table: "WishLists",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 42L, "6" });

            migrationBuilder.DeleteData(
                table: "WishLists",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 5L, "7" });

            migrationBuilder.DeleteData(
                table: "WishLists",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 8L, "7" });

            migrationBuilder.DeleteData(
                table: "WishLists",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 26L, "7" });

            migrationBuilder.DeleteData(
                table: "WishLists",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 29L, "7" });

            migrationBuilder.DeleteData(
                table: "WishLists",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 40L, "7" });

            migrationBuilder.DeleteData(
                table: "WishLists",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 43L, "7" });

            migrationBuilder.DeleteData(
                table: "WishLists",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 45L, "7" });

            migrationBuilder.InsertData(
                table: "CourseCategories",
                columns: new[] { "CategoryId", "CourseId" },
                values: new object[,]
                {
                    { 1L, 1L },
                    { 2L, 2L },
                    { 8L, 3L },
                    { 34L, 3L },
                    { 2L, 4L },
                    { 24L, 4L },
                    { 28L, 4L },
                    { 22L, 5L },
                    { 49L, 5L },
                    { 23L, 6L },
                    { 3L, 7L },
                    { 42L, 7L },
                    { 6L, 8L },
                    { 31L, 8L },
                    { 51L, 8L },
                    { 17L, 9L },
                    { 44L, 9L },
                    { 49L, 9L },
                    { 11L, 10L },
                    { 2L, 11L },
                    { 26L, 11L },
                    { 27L, 11L },
                    { 20L, 12L },
                    { 29L, 12L },
                    { 52L, 12L },
                    { 5L, 13L },
                    { 12L, 13L },
                    { 19L, 13L },
                    { 37L, 14L },
                    { 52L, 14L },
                    { 2L, 15L },
                    { 50L, 16L },
                    { 9L, 17L },
                    { 24L, 18L },
                    { 25L, 18L },
                    { 13L, 19L },
                    { 24L, 20L },
                    { 46L, 20L },
                    { 3L, 21L },
                    { 8L, 21L },
                    { 34L, 21L },
                    { 35L, 22L },
                    { 45L, 22L },
                    { 23L, 23L },
                    { 4L, 24L },
                    { 12L, 24L },
                    { 42L, 24L },
                    { 24L, 25L },
                    { 36L, 25L },
                    { 53L, 25L },
                    { 1L, 26L },
                    { 7L, 26L },
                    { 11L, 26L },
                    { 26L, 27L },
                    { 30L, 27L },
                    { 47L, 27L },
                    { 45L, 28L },
                    { 54L, 28L },
                    { 39L, 29L },
                    { 23L, 30L },
                    { 28L, 30L },
                    { 23L, 31L },
                    { 27L, 31L },
                    { 3L, 32L },
                    { 43L, 32L },
                    { 21L, 33L },
                    { 29L, 33L },
                    { 41L, 33L },
                    { 19L, 34L },
                    { 36L, 34L },
                    { 52L, 35L },
                    { 47L, 36L },
                    { 3L, 37L },
                    { 22L, 37L },
                    { 38L, 37L },
                    { 54L, 38L },
                    { 10L, 40L },
                    { 32L, 40L },
                    { 38L, 40L },
                    { 33L, 41L },
                    { 10L, 42L },
                    { 38L, 42L },
                    { 50L, 42L },
                    { 26L, 43L },
                    { 35L, 43L },
                    { 13L, 44L },
                    { 8L, 45L },
                    { 17L, 45L },
                    { 21L, 46L },
                    { 2L, 47L },
                    { 18L, 48L },
                    { 36L, 48L },
                    { 19L, 49L },
                    { 21L, 49L },
                    { 17L, 50L },
                    { 28L, 50L },
                    { 12L, 51L },
                    { 43L, 51L },
                    { 6L, 52L },
                    { 17L, 52L },
                    { 12L, 53L },
                    { 48L, 53L },
                    { 27L, 55L }
                });

            migrationBuilder.UpdateData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 4L, "6" },
                column: "DateCreated",
                value: new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 11L, "7" },
                column: "DateCreated",
                value: new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 15L, "7" },
                column: "DateCreated",
                value: new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 31L, "7" },
                column: "DateCreated",
                value: new DateTime(2025, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 34L, "6" },
                column: "DateCreated",
                value: new DateTime(2025, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 35L, "6" },
                column: "DateCreated",
                value: new DateTime(2025, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 39L, "5" },
                column: "DateCreated",
                value: new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 40L, "5" },
                column: "DateCreated",
                value: new DateTime(2025, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 41L, "5" },
                column: "DateCreated",
                value: new DateTime(2025, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 50L, "6" },
                column: "DateCreated",
                value: new DateTime(2025, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 53L, "7" },
                column: "DateCreated",
                value: new DateTime(2025, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "CourseEnrollments",
                columns: new[] { "CourseId", "UserId", "DateCreated", "ModifiedDate" },
                values: new object[,]
                {
                    { 2L, "5", new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2L, "6", new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2L, "7", new DateTime(2025, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 3L, "6", new DateTime(2025, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 8L, "7", new DateTime(2025, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 10L, "6", new DateTime(2025, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 12L, "6", new DateTime(2025, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 12L, "7", new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 13L, "5", new DateTime(2025, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 14L, "7", new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 15L, "5", new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 16L, "5", new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 18L, "5", new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 20L, "5", new DateTime(2025, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 21L, "5", new DateTime(2025, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 21L, "7", new DateTime(2025, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 22L, "7", new DateTime(2025, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 23L, "6", new DateTime(2025, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 23L, "7", new DateTime(2025, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 25L, "6", new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 28L, "6", new DateTime(2025, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 28L, "7", new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 33L, "7", new DateTime(2025, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 35L, "5", new DateTime(2025, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 38L, "6", new DateTime(2025, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 41L, "6", new DateTime(2025, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 43L, "5", new DateTime(2025, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 47L, "7", new DateTime(2025, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 48L, "5", new DateTime(2025, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 48L, "6", new DateTime(2025, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 49L, "5", new DateTime(2025, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 50L, "5", new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 52L, "6", new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 55L, "7", new DateTime(2025, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.UpdateData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Url",
                value: "https://picsum.photos/seed/course1_img1/600/400");

            migrationBuilder.UpdateData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Url",
                value: "https://picsum.photos/seed/course1_img2/600/400");

            migrationBuilder.UpdateData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 3L,
                column: "Url",
                value: "https://picsum.photos/seed/course1_img3/600/400");

            migrationBuilder.UpdateData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 4L,
                column: "Url",
                value: "https://picsum.photos/seed/course2_img1/600/400");

            migrationBuilder.UpdateData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 5L,
                column: "Url",
                value: "https://picsum.photos/seed/course2_img2/600/400");

            migrationBuilder.UpdateData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 6L,
                column: "Url",
                value: "https://picsum.photos/seed/course2_img3/600/400");

            migrationBuilder.UpdateData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 7L,
                column: "Url",
                value: "https://picsum.photos/seed/course3_img1/600/400");

            migrationBuilder.UpdateData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 8L,
                column: "Url",
                value: "https://picsum.photos/seed/course3_img2/600/400");

            migrationBuilder.UpdateData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 9L,
                column: "Url",
                value: "https://picsum.photos/seed/course3_img3/600/400");

            migrationBuilder.UpdateData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 10L,
                column: "Url",
                value: "https://picsum.photos/seed/course4_img1/600/400");

            migrationBuilder.UpdateData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 11L,
                column: "Url",
                value: "https://picsum.photos/seed/course4_img2/600/400");

            migrationBuilder.UpdateData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 12L,
                column: "Url",
                value: "https://picsum.photos/seed/course4_img3/600/400");

            migrationBuilder.UpdateData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 13L,
                column: "Url",
                value: "https://picsum.photos/seed/course5_img1/600/400");

            migrationBuilder.UpdateData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 14L,
                column: "Url",
                value: "https://picsum.photos/seed/course5_img2/600/400");

            migrationBuilder.UpdateData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 15L,
                column: "Url",
                value: "https://picsum.photos/seed/course5_img3/600/400");

            migrationBuilder.UpdateData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 16L,
                column: "Url",
                value: "https://picsum.photos/seed/course6_img1/600/400");

            migrationBuilder.UpdateData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 17L,
                column: "Url",
                value: "https://picsum.photos/seed/course6_img2/600/400");

            migrationBuilder.UpdateData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 18L,
                column: "Url",
                value: "https://picsum.photos/seed/course6_img3/600/400");

            migrationBuilder.UpdateData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 19L,
                column: "Url",
                value: "https://picsum.photos/seed/course7_img1/600/400");

            migrationBuilder.UpdateData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 20L,
                column: "Url",
                value: "https://picsum.photos/seed/course7_img2/600/400");

            migrationBuilder.UpdateData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 21L,
                column: "Url",
                value: "https://picsum.photos/seed/course7_img3/600/400");

            migrationBuilder.UpdateData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 22L,
                column: "Url",
                value: "https://picsum.photos/seed/course8_img1/600/400");

            migrationBuilder.UpdateData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 23L,
                column: "Url",
                value: "https://picsum.photos/seed/course8_img2/600/400");

            migrationBuilder.UpdateData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 24L,
                column: "Url",
                value: "https://picsum.photos/seed/course8_img3/600/400");

            migrationBuilder.UpdateData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 25L,
                column: "Url",
                value: "https://picsum.photos/seed/course9_img1/600/400");

            migrationBuilder.UpdateData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 26L,
                column: "Url",
                value: "https://picsum.photos/seed/course9_img2/600/400");

            migrationBuilder.UpdateData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 27L,
                column: "Url",
                value: "https://picsum.photos/seed/course9_img3/600/400");

            migrationBuilder.UpdateData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 28L,
                column: "Url",
                value: "https://picsum.photos/seed/course10_img1/600/400");

            migrationBuilder.UpdateData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 29L,
                column: "Url",
                value: "https://picsum.photos/seed/course10_img2/600/400");

            migrationBuilder.UpdateData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 30L,
                column: "Url",
                value: "https://picsum.photos/seed/course10_img3/600/400");

            migrationBuilder.UpdateData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 31L,
                column: "Url",
                value: "https://picsum.photos/seed/course11_img1/600/400");

            migrationBuilder.UpdateData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 32L,
                column: "Url",
                value: "https://picsum.photos/seed/course11_img2/600/400");

            migrationBuilder.UpdateData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 33L,
                column: "Url",
                value: "https://picsum.photos/seed/course11_img3/600/400");

            migrationBuilder.UpdateData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 34L,
                column: "Url",
                value: "https://picsum.photos/seed/course12_img1/600/400");

            migrationBuilder.UpdateData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 35L,
                column: "Url",
                value: "https://picsum.photos/seed/course12_img2/600/400");

            migrationBuilder.UpdateData(
                table: "CourseImageUrls",
                keyColumn: "Id",
                keyValue: 36L,
                column: "Url",
                value: "https://picsum.photos/seed/course12_img3/600/400");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 1L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "3", "9 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 2L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "2", "17 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 3L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "2", "20 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 4L,
                column: "StudyTime",
                value: "23 hours");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 5L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "2", "16 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 6L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "4", "27 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 7L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "3", "13 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 8L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "3", "5 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 9L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "3", "20 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 10L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "2", "5 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 11L,
                column: "StudyTime",
                value: "24 hours");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 12L,
                column: "StudyTime",
                value: "16 hours");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 13L,
                column: "StudyTime",
                value: "12 hours");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 14L,
                column: "StudyTime",
                value: "15 hours");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 15L,
                column: "StudyTime",
                value: "20 hours");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 16L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "4", "21 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 17L,
                column: "MentorId",
                value: "3");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 19L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "2", "4 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 20L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "4", "18 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 21L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "3", "9 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 22L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "4", "26 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 23L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "3", "21 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 24L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "3", "5 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 25L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "3", "5 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 26L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "4", "13 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 27L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "3", "16 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 28L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "2", "30 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 29L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "2", "16 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 30L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "2", "4 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 31L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "4", "19 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 32L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "4", "15 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 33L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "4", "21 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 34L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "4", "25 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 35L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "3", "3 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 36L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "3", "16 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 37L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "4", "18 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 38L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "2", "14 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 39L,
                column: "StudyTime",
                value: "16 hours");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 40L,
                column: "MentorId",
                value: "3");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 41L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "3", "24 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 42L,
                column: "StudyTime",
                value: "9 hours");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 43L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "4", "30 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 44L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "3", "4 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 45L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "4", "28 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 46L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "3", "18 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 47L,
                column: "StudyTime",
                value: "14 hours");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 48L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "3", "30 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 49L,
                column: "StudyTime",
                value: "24 hours");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 50L,
                column: "StudyTime",
                value: "3 hours");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 51L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "4", "27 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 52L,
                column: "StudyTime",
                value: "19 hours");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 53L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "3", "5 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 54L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "2", "27 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 55L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "3", "27 hours" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 1L,
                columns: new[] { "Content", "IsRead", "ReceiverId", "SenderId" },
                values: new object[] { "Just a friendly reminder that a new module has been unlocked in your course.", true, "27", "3" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 2L,
                columns: new[] { "Content", "ReceiverId" },
                values: new object[] { "We have a new course on Advanced C# that you might be interested in. Check it out!", "13" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 3L,
                columns: new[] { "Content", "IsRead", "ReceiverId", "SenderId" },
                values: new object[] { "Your learning journey is inspiring! Don't hesitate to reach out to the community for discussions.", false, "7", "1" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 4L,
                columns: new[] { "Content", "IsRead", "ReceiverId", "SenderId" },
                values: new object[] { "A quick check-in to see how you are enjoying the platform. Any feedback is welcome!", true, "30", "2" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 5L,
                columns: new[] { "IsRead", "ReceiverId", "SenderId" },
                values: new object[] { true, "48", "4" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 6L,
                columns: new[] { "Content", "ReceiverId" },
                values: new object[] { "Your learning journey is inspiring! Don't hesitate to reach out to the community for discussions.", "6" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 7L,
                columns: new[] { "IsRead", "ReceiverId" },
                values: new object[] { false, "10" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 8L,
                columns: new[] { "Content", "ReceiverId" },
                values: new object[] { "Did you know you can download course resources from the 'Materials' tab? Hope this helps!", "44" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 9L,
                columns: new[] { "ReceiverId", "SenderId" },
                values: new object[] { "27", "1" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 10L,
                columns: new[] { "Content", "ReceiverId", "SenderId" },
                values: new object[] { "A quick check-in to see how you are enjoying the platform. Any feedback is welcome!", "36", "1" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 11L,
                columns: new[] { "IsRead", "ReceiverId" },
                values: new object[] { false, "53" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 12L,
                columns: new[] { "Content", "IsRead", "ReceiverId" },
                values: new object[] { "Just a friendly reminder that a new module has been unlocked in your course.", true, "54" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 13L,
                columns: new[] { "Content", "IsRead", "ReceiverId", "SenderId" },
                values: new object[] { "Your learning journey is inspiring! Don't hesitate to reach out to the community for discussions.", false, "44", "2" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 14L,
                columns: new[] { "ReceiverId", "SenderId" },
                values: new object[] { "48", "1" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 15L,
                columns: new[] { "Content", "IsRead", "ReceiverId", "SenderId" },
                values: new object[] { "Hello! We noticed you're making great progress in your course. Keep up the excellent work!", true, "48", "1" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 16L,
                columns: new[] { "Content", "ReceiverId", "SenderId" },
                values: new object[] { "Just a friendly reminder that a new module has been unlocked in your course.", "43", "4" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 17L,
                columns: new[] { "Content", "ReceiverId", "SenderId" },
                values: new object[] { "Just a friendly reminder that a new module has been unlocked in your course.", "38", "4" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 18L,
                columns: new[] { "Content", "IsRead", "ReceiverId", "SenderId" },
                values: new object[] { "We have a new course on Advanced C# that you might be interested in. Check it out!", true, "46", "4" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 19L,
                columns: new[] { "Content", "ReceiverId", "SenderId" },
                values: new object[] { "Just a friendly reminder that a new module has been unlocked in your course.", "45", "2" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 20L,
                columns: new[] { "Content", "IsRead", "ReceiverId", "SenderId" },
                values: new object[] { "Your learning journey is inspiring! Don't hesitate to reach out to the community for discussions.", false, "7", "2" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 21L,
                columns: new[] { "Content", "IsRead", "ReceiverId", "SenderId" },
                values: new object[] { "Do you have any questions or need assistance with your current lesson? We're here to help.", true, "10", "1" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 22L,
                columns: new[] { "Content", "ReceiverId", "SenderId" },
                values: new object[] { "Hello! We noticed you're making great progress in your course. Keep up the excellent work!", "51", "2" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 23L,
                columns: new[] { "Content", "ReceiverId", "SenderId" },
                values: new object[] { "We have a new course on Advanced C# that you might be interested in. Check it out!", "47", "2" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 24L,
                columns: new[] { "Content", "ReceiverId", "SenderId" },
                values: new object[] { "Do you have any questions or need assistance with your current lesson? We're here to help.", "23", "3" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 25L,
                columns: new[] { "Content", "ReceiverId", "SenderId" },
                values: new object[] { "A quick check-in to see how you are enjoying the platform. Any feedback is welcome!", "45", "2" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 26L,
                columns: new[] { "ReceiverId", "SenderId" },
                values: new object[] { "50", "1" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 27L,
                columns: new[] { "Content", "IsRead", "ReceiverId", "SenderId" },
                values: new object[] { "Do you have any questions or need assistance with your current lesson? We're here to help.", false, "14", "4" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 28L,
                columns: new[] { "Content", "IsRead", "ReceiverId", "SenderId" },
                values: new object[] { "A quick check-in to see how you are enjoying the platform. Any feedback is welcome!", false, "38", "3" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 29L,
                columns: new[] { "IsRead", "ReceiverId", "SenderId" },
                values: new object[] { true, "6", "2" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 30L,
                columns: new[] { "Content", "ReceiverId", "SenderId" },
                values: new object[] { "Just a friendly reminder that a new module has been unlocked in your course.", "15", "3" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 31L,
                columns: new[] { "IsRead", "ReceiverId", "SenderId" },
                values: new object[] { true, "11", "1" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 32L,
                columns: new[] { "Content", "IsRead", "SenderId" },
                values: new object[] { "A quick check-in to see how you are enjoying the platform. Any feedback is welcome!", false, "3" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 33L,
                columns: new[] { "Content", "ReceiverId", "SenderId" },
                values: new object[] { "Just a friendly reminder that a new module has been unlocked in your course.", "24", "1" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 34L,
                columns: new[] { "Content", "IsRead", "ReceiverId", "SenderId" },
                values: new object[] { "Your learning journey is inspiring! Don't hesitate to reach out to the community for discussions.", true, "27", "2" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 35L,
                columns: new[] { "Content", "IsRead", "ReceiverId" },
                values: new object[] { "Welcome aboard! We're thrilled to have you as part of our learning community.", true, "30" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 36L,
                columns: new[] { "Content", "IsRead", "ReceiverId", "SenderId" },
                values: new object[] { "A quick check-in to see how you are enjoying the platform. Any feedback is welcome!", false, "21", "2" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 37L,
                columns: new[] { "Content", "IsRead", "ReceiverId" },
                values: new object[] { "A quick check-in to see how you are enjoying the platform. Any feedback is welcome!", false, "20" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 38L,
                columns: new[] { "Content", "ReceiverId" },
                values: new object[] { "Did you know you can download course resources from the 'Materials' tab? Hope this helps!", "13" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 39L,
                columns: new[] { "Content", "ReceiverId", "SenderId" },
                values: new object[] { "We have a new course on Advanced C# that you might be interested in. Check it out!", "51", "4" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 40L,
                columns: new[] { "Content", "ReceiverId", "SenderId" },
                values: new object[] { "We have a new course on Advanced C# that you might be interested in. Check it out!", "42", "2" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 41L,
                columns: new[] { "Content", "ReceiverId" },
                values: new object[] { "Hello! We noticed you're making great progress in your course. Keep up the excellent work!", "6" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 42L,
                columns: new[] { "Content", "ReceiverId", "SenderId" },
                values: new object[] { "Welcome aboard! We're thrilled to have you as part of our learning community.", "23", "3" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 43L,
                columns: new[] { "Content", "IsRead", "ReceiverId", "SenderId" },
                values: new object[] { "Welcome aboard! We're thrilled to have you as part of our learning community.", true, "41", "4" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 44L,
                columns: new[] { "Content", "IsRead", "ReceiverId", "SenderId" },
                values: new object[] { "Just a friendly reminder that a new module has been unlocked in your course.", true, "33", "4" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 45L,
                columns: new[] { "Content", "ReceiverId", "SenderId" },
                values: new object[] { "Your learning journey is inspiring! Don't hesitate to reach out to the community for discussions.", "14", "1" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 46L,
                columns: new[] { "Content", "ReceiverId", "SenderId" },
                values: new object[] { "Hello! We noticed you're making great progress in your course. Keep up the excellent work!", "34", "3" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 47L,
                columns: new[] { "Content", "IsRead", "ReceiverId", "SenderId" },
                values: new object[] { "Do you have any questions or need assistance with your current lesson? We're here to help.", false, "24", "2" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 48L,
                columns: new[] { "Content", "ReceiverId", "SenderId" },
                values: new object[] { "Welcome aboard! We're thrilled to have you as part of our learning community.", "37", "2" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 49L,
                columns: new[] { "Content", "IsRead", "ReceiverId", "SenderId" },
                values: new object[] { "Did you know you can download course resources from the 'Materials' tab? Hope this helps!", true, "38", "1" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 50L,
                columns: new[] { "Content", "ReceiverId" },
                values: new object[] { "A quick check-in to see how you are enjoying the platform. Any feedback is welcome!", "26" });

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 1L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7116));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 2L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7144));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 3L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7148));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 4L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7150));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 5L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7152));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 6L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7163));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 7L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7165));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 8L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7166));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 9L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7167));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 10L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7169));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 11L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7170));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 12L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7171));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 13L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7172));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 14L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7173));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 15L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7174));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 16L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7175));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 17L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7177));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 18L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7178));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 19L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7179));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 20L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7180));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 21L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7181));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 22L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7182));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 23L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7183));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 24L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7184));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 25L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7185));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 26L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7186));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 27L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7187));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 28L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7188));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 29L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7189));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 30L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7190));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 31L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7192));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 32L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7193));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 33L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7194));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 34L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7195));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 35L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7196));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 36L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7197));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 37L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7198));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 38L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7199));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 39L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7200));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 40L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7201));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 41L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7202));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 42L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7203));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 43L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7204));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 44L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7205));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 45L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7206));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 46L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7207));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 47L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7208));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 48L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7209));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 49L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7210));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 50L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7211));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 51L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7212));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 52L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7213));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 53L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7215));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 54L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7216));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 55L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7217));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 56L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7218));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 57L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7218));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 58L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7220));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 59L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7221));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 60L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7222));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 61L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7223));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 62L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7224));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 63L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7225));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 64L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7226));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 65L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7227));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 66L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7237));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 67L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7238));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 68L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7239));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 69L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7240));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 70L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7241));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 71L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7242));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 72L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7243));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 73L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7244));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 74L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7245));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 75L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7246));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 76L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7246));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 77L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7247));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 78L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7248));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 79L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7249));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 80L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7250));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 81L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7251));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 82L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7252));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 83L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7254));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 84L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7255));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 85L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7256));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 86L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7257));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 87L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7258));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 88L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7259));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 89L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7260));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 90L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7261));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 91L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7262));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 92L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7263));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 93L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7264));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 94L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7265));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 95L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7266));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 96L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7267));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 97L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7268));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 98L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7269));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 99L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7270));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 100L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7271));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 101L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7272));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 102L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7273));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 103L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7274));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 104L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7275));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 105L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7276));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 106L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7277));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 107L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7278));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 108L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7279));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 109L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7280));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 110L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7281));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 111L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7282));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 112L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7283));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 113L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7284));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 114L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7285));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 115L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7286));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 116L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7287));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 117L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7288));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 118L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7289));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 119L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7290));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 120L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7291));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 121L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7292));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 122L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7293));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 123L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7294));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 124L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7295));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 125L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7296));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 126L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7304));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 127L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7305));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 128L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7306));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 129L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7307));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 130L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7309));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 131L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7310));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 132L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7311));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 133L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7312));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 134L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7313));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 135L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7314));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 136L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7316));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 137L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7316));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 138L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7318));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 139L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7319));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 140L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7320));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 141L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7320));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 142L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7322));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 143L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7323));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 144L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7324));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 145L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7325));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 146L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7326));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 147L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7327));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 148L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7328));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 149L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7329));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 150L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7330));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 151L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7331));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 152L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7332));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 153L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7333));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 154L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7334));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 155L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7335));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 156L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7336));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 157L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7337));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 158L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7338));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 159L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7339));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 160L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7340));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 161L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7341));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 162L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7342));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 163L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7343));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 164L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7344));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 165L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7345));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 166L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7346));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 167L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7347));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 168L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7348));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 169L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7349));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 170L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7350));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 171L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7351));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 172L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7352));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 173L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7353));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 174L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7355));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 175L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7356));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 176L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7357));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 177L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7366));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 178L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7367));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 179L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7368));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 180L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7369));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 181L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7370));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 182L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7371));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 183L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7372));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 184L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7373));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 185L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7374));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 186L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7375));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 187L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7376));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 188L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7377));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 189L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7378));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 190L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7379));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 191L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7380));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 192L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7381));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 193L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7383));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 194L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7384));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 195L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7385));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 196L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7386));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 197L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7387));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 198L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7388));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 199L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7389));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 200L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7390));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 201L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7391));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 202L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7392));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 203L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7393));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 204L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7394));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 205L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7395));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 206L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7396));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 207L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7397));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 208L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7398));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 209L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7399));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 210L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7400));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 211L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7401));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 212L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7402));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 213L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7403));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 214L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7404));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 215L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7405));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 216L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7406));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 217L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7407));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 218L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7408));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 219L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7409));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 220L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7410));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 221L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7411));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 222L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7412));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 223L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7413));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 224L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7414));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 225L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7415));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 226L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7416));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 227L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7417));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 228L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7418));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 229L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7419));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 230L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7420));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 231L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7421));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 232L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7422));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 233L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7423));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 234L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7424));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 235L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7425));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 236L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7426));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 237L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7427));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 238L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7428));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 239L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7430));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 240L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7431));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 241L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7432));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 242L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7433));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 243L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7434));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 244L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7435));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 245L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7436));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 246L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7448));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 247L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7449));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 248L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7450));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 249L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7452));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 250L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7453));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 251L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7453));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 252L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7455));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 253L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7456));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 254L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7457));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 255L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7458));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 256L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7459));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 257L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7460));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 258L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7462));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 259L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7463));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 260L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7464));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 261L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7465));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 262L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7466));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 263L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7467));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 264L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7468));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 265L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7469));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 266L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7470));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 267L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7471));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 268L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7472));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 269L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7473));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 270L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7474));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 271L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7475));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 272L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7476));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 273L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7477));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 274L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7478));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 275L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7479));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 276L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7480));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 277L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7481));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 278L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7482));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 279L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7483));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 280L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7490));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 281L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7491));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 282L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7492));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 283L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7493));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 284L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7494));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 285L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7495));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 286L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7496));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 287L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7497));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 288L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7498));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 289L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7499));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 290L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7500));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 291L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7501));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 292L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7502));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 293L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7503));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 294L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7504));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 295L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7505));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 296L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7506));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 297L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7507));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 298L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7508));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 299L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7509));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 300L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7510));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 301L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7511));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 302L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7512));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 303L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7513));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 304L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7514));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 305L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7515));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 306L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7516));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 307L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7517));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 308L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7518));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 309L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7519));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 310L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7520));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 311L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7521));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 312L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7522));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 313L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7523));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 314L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7524));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 315L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7525));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 316L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7526));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 317L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7527));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 318L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7528));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 319L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7530));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 320L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7531));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 321L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7532));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 322L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7533));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 323L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7534));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 324L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7535));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 325L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7536));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 326L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7537));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 327L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7538));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 328L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7539));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 329L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7540));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 330L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7541));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 331L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7542));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 332L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7543));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 333L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7544));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 334L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7545));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 335L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7546));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 336L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7547));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 337L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7548));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 338L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7549));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 339L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7550));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 340L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7551));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 341L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7552));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 342L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7553));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 343L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7554));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 344L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7555));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 345L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7556));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 346L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7557));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 347L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7558));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 348L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7565));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 349L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7566));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 350L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7568));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 351L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7569));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 352L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7570));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 353L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7571));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 354L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7572));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 355L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7573));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 356L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7574));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 357L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7575));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 358L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7576));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 359L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7577));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 360L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7578));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 361L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7579));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 362L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7580));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 363L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7581));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 364L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7582));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 365L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7583));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 366L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7584));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 367L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7585));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 368L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7586));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 369L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7587));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 370L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7588));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 371L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7589));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 372L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7590));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 373L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7591));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 374L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7592));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 375L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7593));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 376L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7594));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 377L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7595));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 378L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7596));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 379L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7597));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 380L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7599));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 381L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7600));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 382L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7601));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 383L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7602));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 384L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7603));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 385L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7604));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 386L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7605));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 387L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7606));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 388L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7607));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 389L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7608));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 390L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7609));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 391L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7610));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 392L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7611));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 393L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7612));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 394L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7613));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 395L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7614));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 396L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7615));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 397L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7616));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 398L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7617));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 399L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7618));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 400L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7619));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 401L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7620));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 402L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7621));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 403L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7622));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 404L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7623));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 405L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7624));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 406L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7625));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 407L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7626));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 408L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7627));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 409L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7628));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 410L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7629));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 411L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7630));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 412L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7631));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 413L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7632));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 414L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7633));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 415L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7634));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 416L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7641));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 417L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7642));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 418L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7643));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 419L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7644));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 420L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7645));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 421L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7646));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 422L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7647));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 423L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7648));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 424L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7649));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 425L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7650));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 426L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7651));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 427L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7652));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 428L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7653));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 429L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7654));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 430L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7655));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 431L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7657));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 432L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7658));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 433L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7659));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 434L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7660));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 435L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7661));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 436L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7662));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 437L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7663));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 438L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7664));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 439L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7665));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 440L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7666));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 441L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7667));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 442L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7668));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 443L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7669));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 444L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7670));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 445L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7671));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 446L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7672));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 447L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7673));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 448L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7674));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 449L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7675));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 450L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7676));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 451L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7677));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 452L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7678));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 453L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7679));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 454L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7680));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 455L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7681));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 456L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7682));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 457L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7683));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 458L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7684));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 459L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7685));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 460L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7686));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 461L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7687));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 462L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7688));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 463L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7689));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 464L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7690));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 465L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 16, 3, 37, 802, DateTimeKind.Local).AddTicks(7691));

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 1L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 73.85m, 2L, "Purchase of course 2" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 2L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 99.62m, 15L, "Purchase of course 15" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 3L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 55.63m, 26L, "Purchase of course 26" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 4L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 99.05m, 21L, "Purchase of course 21" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 5L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 32.01m, 23L, "Purchase of course 23" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 6L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 51.94m, 49L, "Purchase of course 49" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 7L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 52.61m, 19L, "Purchase of course 19" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 8L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 79.09m, 39L, "Purchase of course 39" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 9L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 50.68m, 13L, "Purchase of course 13" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 10L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 37.84m, 34L, "Purchase of course 34" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 11L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 74.40m, 29L, "Purchase of course 29" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 12L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 21.11m, 35L, "Purchase of course 35" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 13L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 28.55m, 42L, "Purchase of course 42" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 14L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 72.46m, 2L, "Purchase of course 2" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 15L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 24.51m, 34L, "Purchase of course 34" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 16L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 29.78m, 30L, "Purchase of course 30" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 17L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 81.11m, 46L, "Purchase of course 46" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 18L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 81.88m, 32L, "Purchase of course 32" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 19L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 26.68m, 20L, "Purchase of course 20" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 20L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 79.24m, 13L, "Purchase of course 13" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 21L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 77.83m, 18L, "Purchase of course 18" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 22L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 86.76m, 51L, "Purchase of course 51" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 23L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 57.67m, 10L, "Purchase of course 10" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 24L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 98.38m, 53L, "Purchase of course 53" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 25L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 71.90m, 41L, "Purchase of course 41" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 26L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 47.18m, 6L, "Purchase of course 6" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 27L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 91.60m, 17L, "Purchase of course 17" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 28L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 95.70m, 54L, "Purchase of course 54" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 29L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 47.14m, 23L, "Purchase of course 23" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 30L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 46.23m, 31L, "Purchase of course 31" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "8424eab9-2409-4945-8a55-9c2d5cb99d25", "AQAAAAIAAYagAAAAEE1xQQNZ9aJC6kh4a16xT9OsyjsvyCj2j+NmjIpnrE4cYmxyjXRERA6FFXUCHo+w2Q==", "e78475ce-4626-41b4-bb67-e95c26255263", new DateTime(2025, 10, 18, 16, 3, 35, 436, DateTimeKind.Local).AddTicks(3057) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "e1627c31-2d5a-4127-888f-6922251033ba", "AQAAAAIAAYagAAAAEOS+KqvnYxPCbxDmdd7Uf3w84Bp9ZlBnXxJqc+WzO6RespEr03zJuKF2PXh7C/R6Fw==", "2c30837b-235f-46b5-8d91-f2b2a65545f9", new DateTime(2025, 10, 18, 16, 3, 35, 825, DateTimeKind.Local).AddTicks(2593) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "b2474db0-da7b-4263-a6a0-69665903f123", "AQAAAAIAAYagAAAAEKEGPZHJwrDFIwGJcqvYk/WfItNySYz0VnQenZyrKj7aRKj0ZI8qMXovFujxJq2KVg==", "0ee938c1-e83e-419a-b97c-14c210806467", new DateTime(2025, 10, 18, 16, 3, 35, 868, DateTimeKind.Local).AddTicks(3845) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "5177ea3a-d556-4967-84ac-f3b21ad3d76e", "AQAAAAIAAYagAAAAEOpuuw98TRPQFRHuTZizA4ccvt5xHx17EskI8bF2WiaxwOD5xdoFkp153uZBurTLEA==", "011d51df-7a3a-4c5c-8687-b86e50a4531a", new DateTime(2025, 10, 18, 16, 3, 35, 911, DateTimeKind.Local).AddTicks(5795) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "32b2db42-a28d-4d88-9e60-a531bce7d012", "AQAAAAIAAYagAAAAEJDPoJLAxYNYjzDw2pKNxD3+Cnwsc58EGbsDKnvu24wPJuIO2Xbsmbmo/D5ycLeYUA==", "e4093c8d-5ec7-4864-9bfd-716b36c811ec", new DateTime(2025, 10, 18, 16, 3, 35, 955, DateTimeKind.Local).AddTicks(1313) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "115b3667-6a97-4a5e-840e-7a67b5fa658f", "AQAAAAIAAYagAAAAEAKtpNeomoz4ZBMRS0yeIvi2b+pkmBKPNkQ7ktEshf0SfrY0R2Kl7YyJduRSieWh6Q==", "9a66b725-e024-47a9-96e9-ad04e82c2a9b", new DateTime(2025, 10, 18, 16, 3, 35, 998, DateTimeKind.Local).AddTicks(2942) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "e24dccb7-7971-40bc-9607-d794fe24aa2a", "AQAAAAIAAYagAAAAEAyfwtryBEvyQctT6wuRAIKAH7huBiwEMwwh4QaPWJ2Qe8KgzYukx1dKu+eBjgFT+g==", "8c1c59fa-558b-4bd6-97b2-190dbc1b8421", new DateTime(2025, 10, 18, 16, 3, 36, 42, DateTimeKind.Local).AddTicks(2712) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "210cf5d1-7ab6-4d43-be95-c69a0182e82c", "AQAAAAIAAYagAAAAEPs7RLVGyOKaQV6jUc1OdaJGsxVwlOhiIOacFUJ1RuaW3XHUxWPXTWCTVOMD+Aa2Nw==", "bf856363-bc0b-4c8b-9d6d-b6512b04c638", new DateTime(2025, 10, 18, 16, 3, 36, 97, DateTimeKind.Local).AddTicks(5925) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "c4701b8e-c2bb-4148-a6b9-6502e9662cc8", "AQAAAAIAAYagAAAAELUrMA7U9TYhW6lvXlCLw1WA4YW4Ue1IMiblqPI6+3Jr1i8I/71eUMS/cWaAZlaChQ==", "37c2f0a1-df6b-40e4-b7a2-054ed1ec130e", new DateTime(2025, 10, 18, 16, 3, 36, 142, DateTimeKind.Local).AddTicks(5303) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "80e24a5e-3ead-42cf-a21d-2d8e30b9c959", "AQAAAAIAAYagAAAAEJSpK7vAn3BtJfvqQUMr1WyABdIN/BE1aZ3qMcpPwcLM7EnvvJ6aiHJ/od62gUnMvw==", "b28b4a65-7f64-480b-a5ee-ba6c71f99ee5", new DateTime(2025, 10, 18, 16, 3, 36, 186, DateTimeKind.Local).AddTicks(6678) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "76286d7b-e5e9-4e0c-b9df-02708562c3f9", "AQAAAAIAAYagAAAAENjblEzr07twg2O6bhOgniof3Kx/9kZibunOP/X7T47THleSREm+oO++51jKZZOTcQ==", "112671d1-7148-4938-a13d-5d4fe06e06bd", new DateTime(2025, 10, 18, 16, 3, 36, 228, DateTimeKind.Local).AddTicks(88) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "8f97b686-1aec-42db-8a54-b7b11e8702b6", "AQAAAAIAAYagAAAAEGCdDVHAlqfyOueh71kYa9cyvjuzC6BEHiz1I7XYpO8RYHziMh4qh5uuUMVCZTl23w==", "a260336f-59bb-4185-975d-b0e8e42f96a6", new DateTime(2025, 10, 18, 16, 3, 35, 478, DateTimeKind.Local).AddTicks(7598) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "df452a7e-ee74-4fae-85b7-0ea3903e3af8", "AQAAAAIAAYagAAAAEOTS0DNbcX7emNWTNlseGwmDvGz2Y5MR/xy93CUxbibCDCXhuTBZ/wiTGp6yP13vQA==", "1995cec3-b701-458e-9fa4-f0900d052040", new DateTime(2025, 10, 18, 16, 3, 36, 269, DateTimeKind.Local).AddTicks(8999) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "51a0c665-40f6-4529-a715-6e3114da9cc5", "AQAAAAIAAYagAAAAEMoEe06KV0N0VGRJVlenqt+n83LeINWHPqxGpfyOqTQ03zV2XT+dLuPizRch0U15+g==", "37de54e8-82f4-48e5-8922-a23b10888d1f", new DateTime(2025, 10, 18, 16, 3, 36, 310, DateTimeKind.Local).AddTicks(949) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "7631d16f-f195-43be-8dc8-f2bae15e43b3", "AQAAAAIAAYagAAAAEFfmz1klMCIT/eJWDP1qmNCCZscF95NBJuadRIDOns19uyjrFJvzk/BnRxTj++TrJA==", "5ac81037-3a2c-4bcc-8cc5-428ef1cf9cbd", new DateTime(2025, 10, 18, 16, 3, 36, 351, DateTimeKind.Local).AddTicks(6580) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "23",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "94317d4d-c6fb-4f08-8632-e47474c6bc26", "AQAAAAIAAYagAAAAEGStsIesmPB/dsgwLE6pQs5F64ZDiDBLfitQ9/jXvT0h+B60MZMxlx1VyI3EL61hFg==", "39a44c1c-0a3b-40a1-b1b0-58dc643532f0", new DateTime(2025, 10, 18, 16, 3, 36, 393, DateTimeKind.Local).AddTicks(3756) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "24",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "31d9c5fe-c03a-4c0d-a770-5988d89e4417", "AQAAAAIAAYagAAAAEIjEJ9m9lJSsiHZfpg7F1pdnAzNp/MTswGnq8r9CkQqAPP2dQTF+sS2RmEzJ8IYcdQ==", "8beb7302-08ec-4197-a583-2dea50564806", new DateTime(2025, 10, 18, 16, 3, 36, 438, DateTimeKind.Local).AddTicks(7459) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "25",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "ce331b9a-2abf-49b4-b59b-6d0f4364dd1c", "AQAAAAIAAYagAAAAEDXYp1S7ExCbkpqGVH+JtPLeLNfowJ/+EGMojSnnaYrEswMT4RAGak6gGSBMGlkyDw==", "7028394e-b2d4-4204-9415-e68b2067a4fe", new DateTime(2025, 10, 18, 16, 3, 36, 481, DateTimeKind.Local).AddTicks(453) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "26",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "6f5180d4-d5fe-4826-acbe-fcce255f3dc3", "AQAAAAIAAYagAAAAEGsfEqecv0G/HN7T1jYHxV74dVX++qEL+LV5TWd122ny5UVe+qK22+fTj4w+K6FDYQ==", "81657227-3606-4752-b7ef-ec5dfdc44e75", new DateTime(2025, 10, 18, 16, 3, 36, 523, DateTimeKind.Local).AddTicks(8758) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "5fbc3219-11e4-4773-a5ec-5d7a283ea351", "AQAAAAIAAYagAAAAEEbHgFLFi7t0YWuevPzZEwnaPCjsQSKTCvQuoGsJpBuoSWXnmsNtw7XPnPof8XQyuA==", "07605d4a-b3f3-49f2-874a-1631769300dd", new DateTime(2025, 10, 18, 16, 3, 36, 566, DateTimeKind.Local).AddTicks(2926) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "28",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "83e60f13-4a4f-4907-b6e6-9f880c5070c3", "AQAAAAIAAYagAAAAEHNlf2IeWopuguj+SnX2lCxjMssHx0iOQPF3LQ/9tkCW3npQG0kEReB5PahRoOdY7g==", "612d0aef-db1b-4521-a708-b5fe2d55a2fe", new DateTime(2025, 10, 18, 16, 3, 36, 608, DateTimeKind.Local).AddTicks(6963) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "29",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "6e6c0aa4-66e0-4b45-a30f-e552f90259ac", "AQAAAAIAAYagAAAAEOnvHXUKGSHLahwtyN2RlllAkWTBw1toGn9cM7V+xWWamOwZ3PPG/UNiw1MYbXvCUw==", "0a346f32-2266-4e9f-99d1-d7d26ab043d6", new DateTime(2025, 10, 18, 16, 3, 36, 651, DateTimeKind.Local).AddTicks(3520) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "f186e207-cb51-430d-ae4a-51aee82ce481", "AQAAAAIAAYagAAAAECjZnNZXQLWX8E5B67VU1gKCJWY1nCckxPQUcoHLw4lUgjBiwq9JkPWhkjkjLvvgJw==", "b04d19a7-42f6-41d3-860f-7ed9e23b7fe3", new DateTime(2025, 10, 18, 16, 3, 35, 521, DateTimeKind.Local).AddTicks(9923) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "30",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "01dfa4f8-1c9f-4100-879d-e51373c0168b", "AQAAAAIAAYagAAAAEHPJNNNstiu6/2l7oXOfgTRtsQXcpg2O7QFJEpy2KSJ11nChjj8Kqu7OeOhfLbwUFg==", "470a5244-ba64-41b7-aa20-3d196af289db", new DateTime(2025, 10, 18, 16, 3, 36, 693, DateTimeKind.Local).AddTicks(5964) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "31",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "527db6d6-471d-45f6-8945-a4f77d586c1e", "AQAAAAIAAYagAAAAEHVjfOOl5gAdcMuBmHJNVvtU/VRLm9WsE1vSUY5xwjqit9VR+c/WeW2OsXRRchydkA==", "59d17b84-6c92-4885-a638-90d9b2256f88", new DateTime(2025, 10, 18, 16, 3, 36, 737, DateTimeKind.Local).AddTicks(5608) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "32",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "2bd51726-4eee-4522-8e01-4efda693fb32", "AQAAAAIAAYagAAAAECezGYazaAzCVxJCyqQziNlOU/TrrsMd1HKqrPcH5iR+qe+/ZpHSR17+4das9Sv+SA==", "2482a923-d81f-4c32-8389-647a913c84f7", new DateTime(2025, 10, 18, 16, 3, 36, 781, DateTimeKind.Local).AddTicks(4257) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "33",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "43cd400e-4fe7-4730-b882-99f91b793572", "AQAAAAIAAYagAAAAECzh1GbE8q+LFFjFSNBQqkl2CpBfSe9iaI7Ceyr56VzxF5c0uOkcTMVySknqtCuYwg==", "d2b0b370-8b95-4d34-8782-15dc9de35128", new DateTime(2025, 10, 18, 16, 3, 36, 826, DateTimeKind.Local).AddTicks(6049) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "34",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "20c29218-dd74-4c74-91bf-1b34b0cf6f12", "AQAAAAIAAYagAAAAEBw1PuPVwVLZ+qIcBtC28NMh1eTgGRLsJYisYGJu41IGxD8kpuu2FVh+7UIyZjFQ3Q==", "a50bec65-b8e7-49bd-92ab-28f267a179a8", new DateTime(2025, 10, 18, 16, 3, 36, 870, DateTimeKind.Local).AddTicks(7460) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "35",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "1273a508-9a75-43d7-850c-fc0c086af357", "AQAAAAIAAYagAAAAEB6h+lk1cZawB/SV0gLhsTGnvE0hCGf7TFxB3LQ5to6VBUC+okAWuwgGxkajLaNa4A==", "779956b4-fb07-4922-a9d9-0f34b0a0b083", new DateTime(2025, 10, 18, 16, 3, 36, 913, DateTimeKind.Local).AddTicks(3143) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "36",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "888d9f0a-44c7-40f6-a4f4-10c869859851", "AQAAAAIAAYagAAAAEPiDKFxWKotDUmwDvcqCNW0AolhSZxVlICAEHCmyn1xvyhRNVgDbwYiot49IOMMrLg==", "cc5ddfed-9414-4c36-8375-118f92a73e4b", new DateTime(2025, 10, 18, 16, 3, 36, 955, DateTimeKind.Local).AddTicks(7998) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "37",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "341dc1f7-8c3a-4fed-9c62-219e232c84af", "AQAAAAIAAYagAAAAEHySJopRnLGqqrYt9WxMNH8BoB7C53saXBC6j9WRWBblludg/nD2JLlNPJScZeMWeQ==", "da02292e-edf6-48d4-91dd-d1b5b519a168", new DateTime(2025, 10, 18, 16, 3, 36, 997, DateTimeKind.Local).AddTicks(2463) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "38",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "2f51c650-81cd-4516-bff2-4006b42908bd", "AQAAAAIAAYagAAAAEI4pqa7BXEorhH4mGznDoB4YZJ/RMGyqwGcEFZBpnBmACDB0RoVrD09UHGGipC/Oxg==", "0e4bbb7b-6aee-4b38-bda6-abcbde2ab0d1", new DateTime(2025, 10, 18, 16, 3, 37, 39, DateTimeKind.Local).AddTicks(2805) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "39",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "5217fe9c-9cd3-446b-a151-baa446c61436", "AQAAAAIAAYagAAAAEHpplCxnk8h09bbBsPdzU38pGNGevjjw4WT7vO8t81sVLseyswmTXR0E/tvsbB/ryA==", "2343ed69-1a05-4fb4-a1e7-e6a0be89f628", new DateTime(2025, 10, 18, 16, 3, 37, 81, DateTimeKind.Local).AddTicks(4002) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "c64e5ffc-8a21-4d6e-a08b-69e9c88095ac", "AQAAAAIAAYagAAAAEIjJ+oJ9VOP5afJo9NIgIHVKKa9bt8wztwDt9Piu+xTWsBEvHHsbKQS/nuwPfrmkyA==", "0a0b42d5-616b-45aa-a752-5173cbd39479", new DateTime(2025, 10, 18, 16, 3, 35, 565, DateTimeKind.Local).AddTicks(3126) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "40",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "b65be182-ba6e-471f-9bee-1e30f424faf5", "AQAAAAIAAYagAAAAEIs5aImyqsZq4Qq5aGKozB6bn8c/6b7hvAKmJNjwoYXt2fStoyuK6gZzmGip27L4lw==", "6ec91bfa-5456-4d16-951a-db02babaf9df", new DateTime(2025, 10, 18, 16, 3, 37, 123, DateTimeKind.Local).AddTicks(4024) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "41",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "6405933c-78af-4aa7-9b59-1495861c8b30", "AQAAAAIAAYagAAAAEOk+LTzQGy9WHW4aGkDp8qqw6hD/6GLa/ZJoH8WnlaswlhDl3vQdAX66ABC7ES4U2w==", "00b37236-322b-466a-bac0-fe634a832903", new DateTime(2025, 10, 18, 16, 3, 37, 165, DateTimeKind.Local).AddTicks(3206) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "42",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "4e09e731-0268-4e7f-bf80-a3a12deb6fd7", "AQAAAAIAAYagAAAAEM3SU7XeY5xFerx3OiXrx/BgL2/i2OP9RuprTSjGWolgRf8crluMwaxZPHDVkJZZTw==", "1fe0652b-510e-4560-8885-1abdc2311f59", new DateTime(2025, 10, 18, 16, 3, 37, 207, DateTimeKind.Local).AddTicks(3998) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "43",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "683f76eb-4945-4cac-8a5c-ff8f13df8f57", "AQAAAAIAAYagAAAAEPD4JF7ktkHXU8xYdKEjlPbXbB+v1ZRfe8m0pEHpv1lQB+Nl18Gh2dhMYykiSXZIxg==", "37b165ea-2f5d-4bce-90ff-dcc074a9aa39", new DateTime(2025, 10, 18, 16, 3, 37, 249, DateTimeKind.Local).AddTicks(6426) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "44",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "638e9b84-930a-42d1-9b9d-65d2caf5f94d", "AQAAAAIAAYagAAAAEN/HgcZOSp83jG09mckDPzNWsuw2eEUHpygwA0j+rXRulbirOOLKQPRqJDs2pyCs3Q==", "6efb9962-741a-4d0e-863b-008b5d151803", new DateTime(2025, 10, 18, 16, 3, 37, 297, DateTimeKind.Local).AddTicks(23) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "45",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "33699390-69a6-4e0d-9557-6d92f8d58fd8", "AQAAAAIAAYagAAAAEHNdOoFIpGcGIMprybGyNPj2bebuaflRxi2sUcwNZUEi/WXUvbDc44waAec6Z20MHg==", "54eb1432-312b-4bf4-a4e7-e3992fd54d49", new DateTime(2025, 10, 18, 16, 3, 37, 337, DateTimeKind.Local).AddTicks(1438) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "46",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "f5a4074d-0d4e-4310-9db8-c07263a563fb", "AQAAAAIAAYagAAAAEEMvm2ZWv9KYBO+3KLtQJHqQJs4J7l2EnvzrfQpGbMAtRJDQS4wfYWpZlhk4cxkekg==", "6dae1c8b-a3cc-4c09-9555-65dea9e2549e", new DateTime(2025, 10, 18, 16, 3, 37, 378, DateTimeKind.Local).AddTicks(2496) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "47",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "cb4b5e41-f40d-4180-8a59-ef544f894313", "AQAAAAIAAYagAAAAEEfY7Ss9zjQ77nIlz35B0M6byjOhI9KaNDEmNZjWsuKw3BO803DQ0cJkyrJd/k02pg==", "363c753a-9d30-45f1-a26b-eea4ad40a520", new DateTime(2025, 10, 18, 16, 3, 37, 420, DateTimeKind.Local).AddTicks(226) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "48",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "e5f9a481-522a-4ee2-98ab-371f9bdc9748", "AQAAAAIAAYagAAAAEAbdQiJS6adN1GBEsVK6tEwtdw5qosntrRJBwwHbg79WrVGUHVEjqjjR5WM5cEW8WQ==", "9927d302-5c23-4391-b051-cc1378cc1c2d", new DateTime(2025, 10, 18, 16, 3, 37, 460, DateTimeKind.Local).AddTicks(6045) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "49",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "bf95edea-f264-4f58-9a49-8a037fc46fee", "AQAAAAIAAYagAAAAEPbEm3BhV9arTA9MmLqN976vhcwebPmuyqlJWl8wZ/tGWQt4W3bACrxyxu4n/0Djxg==", "f557d6c6-f4d2-4c32-ac9c-8cc95f6cc1a0", new DateTime(2025, 10, 18, 16, 3, 37, 502, DateTimeKind.Local).AddTicks(2217) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "873de3c2-57fe-4cd1-b953-3015cfac2b63", "AQAAAAIAAYagAAAAEG48w3dNhzTxtpA4iDFDkcRkY91JMxBlvHvT0YEVl+k79oG0hIrBrWLKGiMqBKyGvA==", "63275913-28d5-4d3f-ab57-122af795aa7c", new DateTime(2025, 10, 18, 16, 3, 35, 609, DateTimeKind.Local).AddTicks(4794) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "50",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "2bc49e66-6aba-4257-8314-39a733907e0c", "AQAAAAIAAYagAAAAEG+1edG1w9zmzKsw81t4wrc7/DI516TdjpMio05cTo6v0Ot5Xg/UBaFl3fVLeCJS1A==", "6a020b26-8f0f-4202-9708-4fdea8218445", new DateTime(2025, 10, 18, 16, 3, 37, 542, DateTimeKind.Local).AddTicks(5321) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "51",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "b9ad8c8b-5e84-405d-bfd0-03cf7c43ed3b", "AQAAAAIAAYagAAAAEK392NifNTKGTLSBe5u5EDehK9P6Cmw1u/LcWeG9oTHdtV9CVNYPTHkQ/Und3AQyCw==", "456a6a76-925b-42a5-94c0-ad4bf6300be7", new DateTime(2025, 10, 18, 16, 3, 37, 584, DateTimeKind.Local).AddTicks(7354) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "52",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "8922d2e1-9b61-4b11-89ea-bc8310ed2f92", "AQAAAAIAAYagAAAAEB77rQOx27tnNxmoBKl25qNnfPQzUqNH97RTBsznQmLWytmS7ysMdvjtkbEHUAgLQw==", "8f24ddc2-9ba1-4607-baf9-76b59518f421", new DateTime(2025, 10, 18, 16, 3, 37, 627, DateTimeKind.Local).AddTicks(8469) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "53",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "a47b6a2c-024c-470b-a4c8-7fdc7f652a9d", "AQAAAAIAAYagAAAAEG0iusOYe45aZgZu27Ojd877RBC4o/aBkEMVGwJSHEO0N4FEd04vDL/hDvfpkpfQWw==", "9f8f5e26-f27e-4d9d-a76a-cef2e3ecb4b1", new DateTime(2025, 10, 18, 16, 3, 37, 669, DateTimeKind.Local).AddTicks(9374) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "54",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "1fd6dd26-fdbc-461f-92e0-2852c9cd5864", "AQAAAAIAAYagAAAAEMxtX39063/xuwlvCjlkBbLDmpKP6OtND3ytUzKtwpb+yNdp+avpkiH+RO2PvPEp/A==", "d25c8c95-24ae-4507-bb4d-8cd209ed8ca9", new DateTime(2025, 10, 18, 16, 3, 37, 711, DateTimeKind.Local).AddTicks(5306) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "55",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "586bcf15-43a5-4da4-81e0-d0f9b0d16cc1", "AQAAAAIAAYagAAAAEDdZUxMhPzd1V7+7tpMr33dndSWUoJnl2JZmj7jnNYpGQTawN++nkvf96JUmDTUp/A==", "57f7c6c0-b4fd-48f4-be75-5cea6aec783e", new DateTime(2025, 10, 18, 16, 3, 37, 756, DateTimeKind.Local).AddTicks(6675) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "ffb2ea12-913f-49f3-90f6-62abf99fffe2", "AQAAAAIAAYagAAAAEAuuHEJVSY3C4zkFIA88V6ESqKhg1QsmFj/3ECwp05YkS4TA3UFLMBpERW6e0cofVA==", "f94bed06-999d-4856-a444-6b2aed2cf76a", new DateTime(2025, 10, 18, 16, 3, 35, 653, DateTimeKind.Local).AddTicks(3924) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "ddb5b53d-9709-45b5-ad82-3d8608ce1e97", "AQAAAAIAAYagAAAAEDWEGL4MCyn+zosKSBe/6tgnrBBH1OEeiyBnSdurjiLvJC6g08RhDW8Q+eSdiF+sDw==", "1d0d2954-93e1-45de-a8ae-0f3eac6aabcc", new DateTime(2025, 10, 18, 16, 3, 35, 696, DateTimeKind.Local).AddTicks(6997) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "fe71479e-d0f4-4d8b-966c-141b41002c4c", "AQAAAAIAAYagAAAAEGLWd950maha0dI0xqQnTHLsHyq3HKYcsfwWEr/4sBld+TZorySan3qZjB+8fc1TnA==", "ca689fc7-7c93-44b8-9ffa-bb8c1a67a8f5", new DateTime(2025, 10, 18, 16, 3, 35, 740, DateTimeKind.Local).AddTicks(1896) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "838d4192-9865-45eb-a061-329dc6892fcb", "AQAAAAIAAYagAAAAEMgl3PRstTZvZDak4gemXcSWJwi8QREdSKU3s1LRZ1QUU3scOKleOId+IyMCKhSpnQ==", "5e513436-2d7c-4eb1-b215-00f9824d067b", new DateTime(2025, 10, 18, 16, 3, 35, 783, DateTimeKind.Local).AddTicks(2676) });

            migrationBuilder.InsertData(
                table: "WishLists",
                columns: new[] { "CourseId", "UserId", "CreatedAt" },
                values: new object[,]
                {
                    { 2L, "5", new DateTime(2025, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7L, "5", new DateTime(2025, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8L, "5", new DateTime(2025, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11L, "5", new DateTime(2025, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18L, "5", new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 25L, "5", new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 37L, "5", new DateTime(2025, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4L, "6", new DateTime(2025, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5L, "6", new DateTime(2025, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9L, "6", new DateTime(2025, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15L, "6", new DateTime(2025, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19L, "6", new DateTime(2025, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 51L, "6", new DateTime(2025, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 54L, "6", new DateTime(2025, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1L, "7", new DateTime(2025, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6L, "7", new DateTime(2025, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15L, "7", new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19L, "7", new DateTime(2025, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 20L, "7", new DateTime(2025, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 39L, "7", new DateTime(2025, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 55L, "7", new DateTime(2025, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }
    }
}
