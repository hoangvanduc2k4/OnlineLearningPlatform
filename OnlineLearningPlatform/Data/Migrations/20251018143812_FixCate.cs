using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OnlineLearningPlatform.Data.Migrations
{
    /// <inheritdoc />
    public partial class FixCate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 41L);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 42L);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 43L);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 50L);

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 4L, 1L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 40L, 1L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 36L, 2L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 45L, 2L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 18L, 3L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 38L, 3L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 44L, 3L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 4L, 4L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 12L, 4L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 36L, 4L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 20L, 5L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 6L, 6L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 18L, 6L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 30L, 7L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 10L, 8L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 38L, 8L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 7L, 9L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 14L, 9L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 12L, 10L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 26L, 11L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 54L, 11L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 2L, 12L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 54L, 12L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 9L, 13L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 21L, 13L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 29L, 13L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 33L, 14L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 47L, 14L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 53L, 14L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 55L, 15L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 18L, 16L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 9L, 17L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 8L, 18L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 5L, 19L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 52L, 19L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 7L, 20L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 26L, 20L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 52L, 20L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 3L, 21L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 48L, 21L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 33L, 22L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 38L, 22L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 28L, 23L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 47L, 23L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 21L, 24L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 55L, 25L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 46L, 26L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 26L, 27L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 49L, 27L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 55L, 27L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 2L, 28L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 14L, 29L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 35L, 29L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 52L, 29L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 51L, 30L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 3L, 31L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 5L, 31L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 4L, 32L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 15L, 33L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 27L, 33L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 29L, 33L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 46L, 34L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 11L, 35L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 33L, 35L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 45L, 35L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 52L, 36L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 2L, 37L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 17L, 37L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 1L, 38L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 17L, 38L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 2L, 39L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 37L, 39L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 33L, 40L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 16L, 41L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 30L, 42L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 40L, 42L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 15L, 43L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 18L, 43L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 55L, 43L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 47L, 44L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 40L, 45L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 48L, 45L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 51L, 45L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 26L, 46L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 44L, 46L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 26L, 47L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 39L, 47L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 12L, 48L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 3L, 49L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 29L, 49L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 37L, 50L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 45L, 50L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 48L, 50L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 47L, 51L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 5L, 52L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 15L, 53L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 36L, 53L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 3L, 54L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 54L, 54L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 55L, 55L });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 2L, "7" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 3L, "7" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 4L, "7" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 6L, "7" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 8L, "7" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 12L, "6" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 14L, "5" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 15L, "7" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 17L, "7" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 18L, "5" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 19L, "6" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 23L, "6" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 25L, "5" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 26L, "7" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 31L, "5" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 31L, "6" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 33L, "5" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 34L, "5" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 35L, "6" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 39L, "6" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 40L, "5" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 41L, "7" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 42L, "5" });

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
                keyValues: new object[] { 44L, "7" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 46L, "5" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 46L, "7" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 49L, "7" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 50L, "5" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 51L, "5" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 54L, "6" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 55L, "6" });

            migrationBuilder.DeleteData(
                table: "WishLists",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 4L, "5" });

            migrationBuilder.DeleteData(
                table: "WishLists",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 23L, "5" });

            migrationBuilder.DeleteData(
                table: "WishLists",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 44L, "5" });

            migrationBuilder.DeleteData(
                table: "WishLists",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 49L, "5" });

            migrationBuilder.DeleteData(
                table: "WishLists",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 1L, "6" });

            migrationBuilder.DeleteData(
                table: "WishLists",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 19L, "6" });

            migrationBuilder.DeleteData(
                table: "WishLists",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 30L, "6" });

            migrationBuilder.DeleteData(
                table: "WishLists",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 34L, "6" });

            migrationBuilder.DeleteData(
                table: "WishLists",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 42L, "6" });

            migrationBuilder.DeleteData(
                table: "WishLists",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 52L, "6" });

            migrationBuilder.DeleteData(
                table: "WishLists",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 7L, "7" });

            migrationBuilder.DeleteData(
                table: "WishLists",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 8L, "7" });

            migrationBuilder.DeleteData(
                table: "WishLists",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 12L, "7" });

            migrationBuilder.DeleteData(
                table: "WishLists",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 17L, "7" });

            migrationBuilder.DeleteData(
                table: "WishLists",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 44L, "7" });

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 35L);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 36L);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 37L);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 38L);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 39L);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 40L);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 44L);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 45L);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 46L);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 47L);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 48L);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 49L);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 51L);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 52L);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 53L);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 54L);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 55L);

            migrationBuilder.InsertData(
                table: "CourseCategories",
                columns: new[] { "CategoryId", "CourseId" },
                values: new object[,]
                {
                    { 10L, 1L },
                    { 2L, 3L },
                    { 6L, 3L },
                    { 8L, 3L },
                    { 6L, 4L },
                    { 1L, 5L },
                    { 2L, 6L },
                    { 5L, 6L },
                    { 8L, 6L },
                    { 10L, 7L },
                    { 6L, 8L },
                    { 5L, 9L },
                    { 1L, 10L },
                    { 6L, 10L },
                    { 5L, 11L },
                    { 8L, 11L },
                    { 9L, 11L },
                    { 4L, 12L },
                    { 1L, 13L },
                    { 2L, 13L },
                    { 7L, 13L },
                    { 8L, 14L },
                    { 2L, 15L },
                    { 7L, 15L },
                    { 7L, 16L },
                    { 2L, 17L },
                    { 3L, 17L },
                    { 5L, 17L },
                    { 4L, 18L },
                    { 4L, 19L },
                    { 7L, 19L },
                    { 4L, 20L },
                    { 5L, 20L },
                    { 2L, 21L },
                    { 6L, 21L },
                    { 2L, 22L },
                    { 1L, 23L },
                    { 4L, 23L },
                    { 9L, 23L },
                    { 1L, 24L },
                    { 2L, 24L },
                    { 8L, 24L },
                    { 3L, 25L },
                    { 4L, 25L },
                    { 8L, 25L },
                    { 7L, 26L },
                    { 10L, 26L },
                    { 2L, 27L },
                    { 6L, 27L },
                    { 8L, 27L },
                    { 9L, 28L },
                    { 3L, 29L },
                    { 4L, 29L },
                    { 1L, 30L },
                    { 2L, 30L },
                    { 5L, 30L },
                    { 4L, 31L },
                    { 8L, 31L },
                    { 6L, 32L },
                    { 7L, 33L },
                    { 2L, 34L },
                    { 3L, 34L },
                    { 9L, 34L },
                    { 1L, 35L },
                    { 2L, 35L },
                    { 4L, 35L },
                    { 2L, 36L },
                    { 4L, 36L },
                    { 9L, 36L },
                    { 10L, 37L },
                    { 4L, 38L },
                    { 10L, 38L },
                    { 3L, 39L },
                    { 9L, 39L },
                    { 1L, 40L },
                    { 4L, 41L },
                    { 7L, 41L },
                    { 9L, 41L },
                    { 3L, 42L },
                    { 7L, 42L },
                    { 5L, 43L },
                    { 8L, 43L },
                    { 9L, 43L },
                    { 2L, 44L },
                    { 1L, 45L },
                    { 2L, 45L },
                    { 9L, 45L },
                    { 1L, 46L },
                    { 4L, 46L },
                    { 10L, 46L },
                    { 1L, 47L },
                    { 4L, 47L },
                    { 10L, 47L },
                    { 5L, 48L },
                    { 10L, 48L },
                    { 5L, 49L },
                    { 9L, 49L },
                    { 10L, 49L },
                    { 2L, 50L },
                    { 10L, 50L },
                    { 1L, 51L },
                    { 2L, 52L },
                    { 6L, 52L },
                    { 9L, 52L },
                    { 2L, 53L },
                    { 5L, 53L },
                    { 8L, 53L },
                    { 4L, 54L },
                    { 6L, 54L },
                    { 7L, 55L },
                    { 9L, 55L }
                });

            migrationBuilder.UpdateData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 3L, "6" },
                column: "DateCreated",
                value: new DateTime(2025, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 5L, "6" },
                column: "DateCreated",
                value: new DateTime(2025, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 9L, "7" },
                column: "DateCreated",
                value: new DateTime(2025, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 12L, "5" },
                column: "DateCreated",
                value: new DateTime(2025, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 19L, "7" },
                column: "DateCreated",
                value: new DateTime(2025, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 20L, "6" },
                column: "DateCreated",
                value: new DateTime(2025, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 26L, "5" },
                column: "DateCreated",
                value: new DateTime(2025, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 37L, "5" },
                column: "DateCreated",
                value: new DateTime(2025, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 49L, "6" },
                column: "DateCreated",
                value: new DateTime(2025, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 50L, "7" },
                column: "DateCreated",
                value: new DateTime(2025, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 52L, "6" },
                column: "DateCreated",
                value: new DateTime(2025, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 53L, "5" },
                column: "DateCreated",
                value: new DateTime(2025, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "CourseEnrollments",
                columns: new[] { "CourseId", "UserId", "DateCreated", "ModifiedDate" },
                values: new object[,]
                {
                    { 1L, "7", new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2L, "6", new DateTime(2025, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 5L, "5", new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 5L, "7", new DateTime(2025, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 8L, "5", new DateTime(2025, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 9L, "6", new DateTime(2025, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 10L, "5", new DateTime(2025, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 10L, "6", new DateTime(2025, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 11L, "5", new DateTime(2025, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 11L, "6", new DateTime(2025, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 12L, "7", new DateTime(2025, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 13L, "6", new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 13L, "7", new DateTime(2025, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 14L, "7", new DateTime(2025, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 21L, "6", new DateTime(2025, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 21L, "7", new DateTime(2025, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 22L, "7", new DateTime(2025, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 23L, "7", new DateTime(2025, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 26L, "6", new DateTime(2025, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 30L, "5", new DateTime(2025, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 32L, "6", new DateTime(2025, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 36L, "5", new DateTime(2025, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 36L, "6", new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 38L, "5", new DateTime(2025, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 38L, "7", new DateTime(2025, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 41L, "5", new DateTime(2025, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 43L, "5", new DateTime(2025, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 44L, "5", new DateTime(2025, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 45L, "6", new DateTime(2025, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 48L, "7", new DateTime(2025, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 52L, "5", new DateTime(2025, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 52L, "7", new DateTime(2025, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 55L, "7", new DateTime(2025, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 1L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "3", "11 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 2L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "4", "12 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 3L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "4", "3 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 5L,
                column: "StudyTime",
                value: "29 hours");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 6L,
                column: "StudyTime",
                value: "6 hours");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 7L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "3", "17 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 8L,
                column: "StudyTime",
                value: "4 hours");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 9L,
                column: "StudyTime",
                value: "13 hours");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 10L,
                column: "StudyTime",
                value: "27 hours");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 11L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "2", "18 hours" });

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
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "3", "3 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 14L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "3", "9 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 15L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "4", "22 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 16L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "3", "22 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 17L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "3", "6 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 18L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "4", "16 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 19L,
                column: "StudyTime",
                value: "27 hours");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 20L,
                column: "StudyTime",
                value: "23 hours");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 21L,
                column: "StudyTime",
                value: "6 hours");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 22L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "3", "3 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 23L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "2", "28 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 24L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "3", "14 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 25L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "4", "20 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 26L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "2", "27 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 27L,
                column: "StudyTime",
                value: "12 hours");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 28L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "2", "10 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 29L,
                column: "StudyTime",
                value: "27 hours");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 30L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "4", "4 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 31L,
                column: "MentorId",
                value: "2");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 32L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "4", "25 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 33L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "3", "5 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 34L,
                column: "StudyTime",
                value: "27 hours");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 35L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "2", "15 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 36L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "2", "14 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 37L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "3", "4 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 38L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "3", "12 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 39L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "4", "12 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 40L,
                column: "StudyTime",
                value: "16 hours");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 41L,
                column: "MentorId",
                value: "4");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 42L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "2", "23 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 43L,
                column: "StudyTime",
                value: "30 hours");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 44L,
                column: "StudyTime",
                value: "15 hours");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 45L,
                column: "MentorId",
                value: "4");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 46L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "4", "27 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 47L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "3", "22 hours" });

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
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "3", "24 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 50L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "2", "7 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 51L,
                column: "StudyTime",
                value: "19 hours");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 52L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "2", "17 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 53L,
                column: "StudyTime",
                value: "22 hours");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 54L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "3", "22 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 55L,
                column: "StudyTime",
                value: "21 hours");

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 1L,
                columns: new[] { "Content", "IsRead", "ReceiverId", "SenderId" },
                values: new object[] { "We have a new course on Advanced C# that you might be interested in. Check it out!", false, "53", "1" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 2L,
                columns: new[] { "Content", "IsRead", "ReceiverId", "SenderId" },
                values: new object[] { "A quick check-in to see how you are enjoying the platform. Any feedback is welcome!", true, "14", "3" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 3L,
                columns: new[] { "Content", "IsRead", "ReceiverId", "SenderId" },
                values: new object[] { "A quick check-in to see how you are enjoying the platform. Any feedback is welcome!", true, "23", "2" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 4L,
                columns: new[] { "Content", "IsRead", "ReceiverId", "SenderId" },
                values: new object[] { "Just a friendly reminder that a new module has been unlocked in your course.", false, "22", "2" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 5L,
                columns: new[] { "IsRead", "ReceiverId", "SenderId" },
                values: new object[] { false, "49", "1" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 6L,
                columns: new[] { "Content", "IsRead", "ReceiverId", "SenderId" },
                values: new object[] { "Did you know you can download course resources from the 'Materials' tab? Hope this helps!", true, "16", "1" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 7L,
                columns: new[] { "Content", "IsRead", "ReceiverId", "SenderId" },
                values: new object[] { "A quick check-in to see how you are enjoying the platform. Any feedback is welcome!", false, "43", "1" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 8L,
                columns: new[] { "Content", "IsRead", "ReceiverId", "SenderId" },
                values: new object[] { "Do you have any questions or need assistance with your current lesson? We're here to help.", false, "29", "4" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 9L,
                columns: new[] { "Content", "ReceiverId", "SenderId" },
                values: new object[] { "We have a new course on Advanced C# that you might be interested in. Check it out!", "5", "2" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 10L,
                columns: new[] { "Content", "IsRead", "ReceiverId", "SenderId" },
                values: new object[] { "We have a new course on Advanced C# that you might be interested in. Check it out!", true, "47", "4" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 11L,
                columns: new[] { "IsRead", "ReceiverId", "SenderId" },
                values: new object[] { true, "27", "3" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 12L,
                columns: new[] { "ReceiverId", "SenderId" },
                values: new object[] { "34", "4" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 13L,
                columns: new[] { "Content", "ReceiverId" },
                values: new object[] { "Just a friendly reminder that a new module has been unlocked in your course.", "16" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 14L,
                columns: new[] { "Content", "ReceiverId", "SenderId" },
                values: new object[] { "Your learning journey is inspiring! Don't hesitate to reach out to the community for discussions.", "45", "3" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 15L,
                columns: new[] { "Content", "ReceiverId", "SenderId" },
                values: new object[] { "Do you have any questions or need assistance with your current lesson? We're here to help.", "21", "4" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 16L,
                columns: new[] { "Content", "ReceiverId" },
                values: new object[] { "Did you know you can download course resources from the 'Materials' tab? Hope this helps!", "12" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 17L,
                columns: new[] { "IsRead", "ReceiverId" },
                values: new object[] { true, "36" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 18L,
                columns: new[] { "Content", "ReceiverId" },
                values: new object[] { "A quick check-in to see how you are enjoying the platform. Any feedback is welcome!", "23" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 19L,
                columns: new[] { "Content", "ReceiverId", "SenderId" },
                values: new object[] { "A quick check-in to see how you are enjoying the platform. Any feedback is welcome!", "39", "4" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 20L,
                columns: new[] { "Content", "IsRead", "ReceiverId", "SenderId" },
                values: new object[] { "Just a friendly reminder that a new module has been unlocked in your course.", false, "45", "2" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 21L,
                columns: new[] { "Content", "ReceiverId" },
                values: new object[] { "Just a friendly reminder that a new module has been unlocked in your course.", "13" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 22L,
                columns: new[] { "Content", "ReceiverId" },
                values: new object[] { "Your learning journey is inspiring! Don't hesitate to reach out to the community for discussions.", "39" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 23L,
                columns: new[] { "Content", "IsRead", "ReceiverId", "SenderId" },
                values: new object[] { "Your learning journey is inspiring! Don't hesitate to reach out to the community for discussions.", true, "49", "3" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 24L,
                columns: new[] { "Content", "ReceiverId", "SenderId" },
                values: new object[] { "Did you know you can download course resources from the 'Materials' tab? Hope this helps!", "44", "3" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 25L,
                columns: new[] { "Content", "IsRead", "ReceiverId", "SenderId" },
                values: new object[] { "A quick check-in to see how you are enjoying the platform. Any feedback is welcome!", false, "32", "3" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 26L,
                column: "Content",
                value: "Hello! We noticed you're making great progress in your course. Keep up the excellent work!");

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 27L,
                columns: new[] { "Content", "IsRead", "ReceiverId", "SenderId" },
                values: new object[] { "Welcome aboard! We're thrilled to have you as part of our learning community.", false, "7", "3" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 28L,
                columns: new[] { "Content", "ReceiverId", "SenderId" },
                values: new object[] { "Just a friendly reminder that a new module has been unlocked in your course.", "46", "2" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 29L,
                columns: new[] { "Content", "IsRead", "ReceiverId", "SenderId" },
                values: new object[] { "A quick check-in to see how you are enjoying the platform. Any feedback is welcome!", true, "29", "3" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 30L,
                columns: new[] { "Content", "ReceiverId", "SenderId" },
                values: new object[] { "Do you have any questions or need assistance with your current lesson? We're here to help.", "42", "4" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 31L,
                columns: new[] { "Content", "ReceiverId" },
                values: new object[] { "A quick check-in to see how you are enjoying the platform. Any feedback is welcome!", "38" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 32L,
                columns: new[] { "Content", "IsRead", "ReceiverId", "SenderId" },
                values: new object[] { "Just a friendly reminder that a new module has been unlocked in your course.", false, "34", "1" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 33L,
                columns: new[] { "Content", "IsRead", "ReceiverId", "SenderId" },
                values: new object[] { "Did you know you can download course resources from the 'Materials' tab? Hope this helps!", false, "30", "2" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 34L,
                columns: new[] { "Content", "IsRead", "ReceiverId", "SenderId" },
                values: new object[] { "A quick check-in to see how you are enjoying the platform. Any feedback is welcome!", true, "48", "4" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 35L,
                columns: new[] { "Content", "IsRead", "ReceiverId", "SenderId" },
                values: new object[] { "A quick check-in to see how you are enjoying the platform. Any feedback is welcome!", true, "31", "1" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 36L,
                columns: new[] { "Content", "ReceiverId", "SenderId" },
                values: new object[] { "Do you have any questions or need assistance with your current lesson? We're here to help.", "53", "2" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 37L,
                columns: new[] { "Content", "ReceiverId" },
                values: new object[] { "Welcome aboard! We're thrilled to have you as part of our learning community.", "38" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 38L,
                columns: new[] { "Content", "ReceiverId", "SenderId" },
                values: new object[] { "Just a friendly reminder that a new module has been unlocked in your course.", "47", "2" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 39L,
                columns: new[] { "IsRead", "ReceiverId", "SenderId" },
                values: new object[] { false, "11", "4" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 40L,
                columns: new[] { "Content", "IsRead", "ReceiverId", "SenderId" },
                values: new object[] { "Welcome aboard! We're thrilled to have you as part of our learning community.", false, "27", "3" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 41L,
                columns: new[] { "Content", "ReceiverId", "SenderId" },
                values: new object[] { "Your learning journey is inspiring! Don't hesitate to reach out to the community for discussions.", "26", "2" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 42L,
                columns: new[] { "Content", "IsRead", "ReceiverId", "SenderId" },
                values: new object[] { "Your learning journey is inspiring! Don't hesitate to reach out to the community for discussions.", true, "37", "3" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 43L,
                columns: new[] { "Content", "IsRead", "ReceiverId", "SenderId" },
                values: new object[] { "Your learning journey is inspiring! Don't hesitate to reach out to the community for discussions.", true, "6", "2" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 44L,
                columns: new[] { "Content", "IsRead", "ReceiverId", "SenderId" },
                values: new object[] { "A quick check-in to see how you are enjoying the platform. Any feedback is welcome!", true, "15", "4" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 45L,
                columns: new[] { "Content", "ReceiverId", "SenderId" },
                values: new object[] { "We have a new course on Advanced C# that you might be interested in. Check it out!", "6", "2" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 46L,
                columns: new[] { "Content", "IsRead", "ReceiverId", "SenderId" },
                values: new object[] { "We have a new course on Advanced C# that you might be interested in. Check it out!", true, "22", "1" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 47L,
                columns: new[] { "Content", "IsRead", "ReceiverId", "SenderId" },
                values: new object[] { "Do you have any questions or need assistance with your current lesson? We're here to help.", true, "7", "2" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 48L,
                columns: new[] { "Content", "IsRead", "ReceiverId", "SenderId" },
                values: new object[] { "A quick check-in to see how you are enjoying the platform. Any feedback is welcome!", false, "5", "2" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 49L,
                columns: new[] { "Content", "ReceiverId", "SenderId" },
                values: new object[] { "A quick check-in to see how you are enjoying the platform. Any feedback is welcome!", "23", "2" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 50L,
                columns: new[] { "Content", "ReceiverId" },
                values: new object[] { "Just a friendly reminder that a new module has been unlocked in your course.", "18" });

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 1L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8709));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 2L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8733));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 3L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8737));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 4L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8740));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 5L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8742));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 6L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8744));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 7L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8746));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 8L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8747));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 9L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8748));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 10L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8751));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 11L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8752));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 12L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8753));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 13L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8755));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 14L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8756));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 15L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8758));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 16L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8759));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 17L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8760));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 18L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8762));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 19L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8763));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 20L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8765));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 21L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8766));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 22L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8767));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 23L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8768));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 24L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8770));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 25L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8771));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 26L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8773));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 27L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8774));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 28L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8785));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 29L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8786));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 30L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8787));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 31L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8789));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 32L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8790));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 33L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8791));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 34L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8793));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 35L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8794));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 36L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8796));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 37L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8797));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 38L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8798));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 39L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8799));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 40L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8801));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 41L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8802));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 42L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8803));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 43L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8805));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 44L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8806));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 45L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8807));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 46L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8808));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 47L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8809));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 48L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8811));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 49L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8812));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 50L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8813));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 51L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8814));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 52L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8815));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 53L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8817));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 54L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8818));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 55L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8819));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 56L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8821));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 57L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8822));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 58L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8823));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 59L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8824));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 60L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8826));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 61L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8827));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 62L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8828));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 63L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8829));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 64L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8831));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 65L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8832));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 66L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8834));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 67L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8836));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 68L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8837));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 69L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8838));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 70L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8839));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 71L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8840));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 72L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8842));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 73L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8843));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 74L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8844));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 75L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8846));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 76L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8847));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 77L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8848));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 78L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8849));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 79L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8850));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 80L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8852));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 81L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8853));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 82L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8854));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 83L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8867));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 84L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8868));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 85L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8869));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 86L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8871));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 87L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8872));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 88L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8873));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 89L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8874));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 90L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8876));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 91L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8877));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 92L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8878));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 93L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8880));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 94L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8881));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 95L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8882));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 96L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8883));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 97L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8884));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 98L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8886));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 99L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8887));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 100L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8888));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 101L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8889));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 102L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8891));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 103L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8892));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 104L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8893));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 105L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8894));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 106L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8895));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 107L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8897));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 108L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8898));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 109L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8899));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 110L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8900));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 111L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8901));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 112L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8903));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 113L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8904));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 114L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8905));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 115L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8906));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 116L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8908));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 117L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8909));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 118L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8910));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 119L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8911));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 120L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8912));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 121L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8914));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 122L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8915));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 123L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8916));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 124L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8917));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 125L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8919));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 126L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8920));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 127L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8921));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 128L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8922));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 129L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8923));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 130L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8926));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 131L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8927));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 132L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8928));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 133L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8929));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 134L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8937));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 135L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8938));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 136L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8939));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 137L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8941));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 138L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8942));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 139L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8943));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 140L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8944));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 141L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8946));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 142L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8947));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 143L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8948));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 144L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8949));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 145L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8950));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 146L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 147L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8953));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 148L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8954));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 149L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8955));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 150L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8956));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 151L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8958));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 152L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8959));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 153L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8960));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 154L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8962));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 155L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8963));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 156L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8964));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 157L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8965));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 158L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8966));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 159L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8968));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 160L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8969));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 161L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8970));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 162L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8972));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 163L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8973));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 164L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8974));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 165L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8975));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 166L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8976));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 167L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8978));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 168L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8979));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 169L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8980));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 170L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8982));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 171L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8983));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 172L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8984));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 173L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8985));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 174L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8986));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 175L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8988));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 176L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8989));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 177L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8990));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 178L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8991));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 179L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8993));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 180L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8994));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 181L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8995));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 182L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8996));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 183L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8997));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 184L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(8999));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 185L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9000));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 186L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9001));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 187L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9002));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 188L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9003));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 189L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9005));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 190L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9006));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 191L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9007));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 192L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9009));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 193L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9010));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 194L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9011));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 195L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9012));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 196L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9013));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 197L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9015));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 198L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9016));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 199L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9017));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 200L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9018));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 201L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9019));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 202L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9030));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 203L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9032));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 204L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9033));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 205L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9034));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 206L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9036));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 207L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9037));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 208L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9038));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 209L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9039));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 210L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9040));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 211L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9042));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 212L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9043));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 213L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9044));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 214L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9045));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 215L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9046));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 216L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9048));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 217L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9049));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 218L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9050));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 219L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9051));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 220L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9053));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 221L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9054));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 222L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9055));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 223L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9057));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 224L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9058));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 225L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9059));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 226L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9060));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 227L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9062));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 228L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9063));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 229L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9064));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 230L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9065));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 231L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9067));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 232L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9068));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 233L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9069));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 234L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9070));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 235L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9071));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 236L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9073));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 237L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9074));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 238L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9075));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 239L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9077));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 240L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9078));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 241L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9079));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 242L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9080));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 243L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9081));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 244L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9083));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 245L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9084));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 246L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9085));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 247L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9086));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 248L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9088));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 249L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9089));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 250L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9090));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 251L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9091));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 252L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9092));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 253L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9094));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 254L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9095));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 255L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9096));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 256L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9098));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 257L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9099));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 258L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9108));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 259L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9109));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 260L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9110));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 261L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9112));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 262L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9113));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 263L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9114));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 264L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9115));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 265L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9116));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 266L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9118));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 267L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9119));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 268L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9120));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 269L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9121));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 270L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9122));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 271L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9124));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 272L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9125));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 273L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9126));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 274L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9128));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 275L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9129));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 276L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9130));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 277L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9131));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 278L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9133));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 279L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9134));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 280L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9135));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 281L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9136));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 282L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9137));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 283L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9139));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 284L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9140));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 285L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9141));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 286L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9142));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 287L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9143));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 288L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9145));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 289L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9146));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 290L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9148));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 291L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9149));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 292L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9150));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 293L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9151));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 294L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9152));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 295L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9154));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 296L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9155));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 297L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9156));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 298L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9157));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 299L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9159));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 300L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9160));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 301L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9161));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 302L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9162));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 303L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9164));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 304L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9165));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 305L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9173));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 306L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9174));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 307L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9175));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 308L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9176));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 309L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9177));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 310L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9179));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 311L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9180));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 312L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9181));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 313L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9182));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 314L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9184));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 315L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9185));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 316L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9186));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 317L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9188));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 318L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9189));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 319L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9190));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 320L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9191));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 321L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9192));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 322L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9194));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 323L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9195));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 324L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9196));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 325L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9197));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 326L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9199));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 327L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9200));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 328L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9201));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 329L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9202));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 330L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9203));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 331L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9205));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 332L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9206));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 333L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9207));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 334L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9208));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 335L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9209));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 336L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9211));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 337L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9212));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 338L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9213));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 339L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9215));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 340L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9216));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 341L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9217));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 342L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9218));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 343L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9220));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 344L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9221));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 345L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9222));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 346L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9223));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 347L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9224));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 348L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9226));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 349L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9227));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 350L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9228));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 351L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9230));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 352L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9231));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 353L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9232));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 354L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9233));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 355L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9234));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 356L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9236));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 357L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9237));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 358L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9238));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 359L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9239));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 360L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9240));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 361L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9242));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 362L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9243));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 363L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9244));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 364L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9246));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 365L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9247));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 366L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9248));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 367L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9249));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 368L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9251));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 369L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9252));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 370L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9253));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 371L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9254));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 372L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9255));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 373L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9263));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 374L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9265));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 375L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9266));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 376L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9268));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 377L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9269));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 378L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9270));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 379L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9271));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 380L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9273));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 381L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9274));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 382L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9275));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 383L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9276));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 384L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9277));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 385L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9279));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 386L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9280));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 387L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9281));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 388L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9282));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 389L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9283));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 390L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9285));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 391L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9286));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 392L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9287));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 393L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9288));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 394L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9290));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 395L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9291));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 396L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9292));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 397L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9293));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 398L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9295));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 399L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9296));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 400L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9297));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 401L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9298));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 402L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9299));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 403L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9301));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 404L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9302));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 405L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9303));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 406L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9304));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 407L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9306));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 408L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9307));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 409L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9308));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 410L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9309));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 411L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9310));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 412L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9312));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 413L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9313));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 414L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9314));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 415L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9316));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 416L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9317));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 417L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9318));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 418L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9319));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 419L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9320));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 420L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9322));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 421L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9323));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 422L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9324));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 423L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9325));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 424L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9327));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 425L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9328));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 426L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9329));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 427L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 428L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9331));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 429L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9333));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 430L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9334));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 431L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9335));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 432L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9336));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 433L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9338));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 434L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9339));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 435L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9340));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 436L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9341));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 437L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9343));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 438L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9344));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 439L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9345));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 440L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9346));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 441L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9354));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 442L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9356));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 443L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9357));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 444L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9358));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 445L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9360));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 446L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9361));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 447L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9362));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 448L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9363));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 449L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9364));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 450L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9366));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 451L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9367));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 452L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9368));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 453L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9369));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 454L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9371));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 455L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9372));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 456L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9373));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 457L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9374));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 458L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9375));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 459L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9377));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 460L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9378));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 461L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9379));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 462L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9380));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 463L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9382));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 464L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9383));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 465L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 38, 9, 568, DateTimeKind.Local).AddTicks(9384));

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 1L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 30.89m, 28L, "Purchase of course 28" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 2L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 54.96m, 27L, "Purchase of course 27" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 3L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 26.41m, 23L, "Purchase of course 23" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 4L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 89.02m, 30L, "Purchase of course 30" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 5L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 55.51m, 34L, "Purchase of course 34" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 6L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 96.19m, 13L, "Purchase of course 13" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 7L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 87.27m, 21L, "Purchase of course 21" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 8L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 35.16m, 42L, "Purchase of course 42" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 9L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 26.98m, 25L, "Purchase of course 25" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 10L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 84.03m, 22L, "Purchase of course 22" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 11L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 49.05m, 41L, "Purchase of course 41" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 12L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 87.00m, 26L, "Purchase of course 26" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 13L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 92.57m, 10L, "Purchase of course 10" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 14L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 22.50m, 50L, "Purchase of course 50" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 15L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 64.16m, 48L, "Purchase of course 48" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 16L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 53.72m, 37L, "Purchase of course 37" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 17L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 81.51m, 24L, "Purchase of course 24" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 18L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 24.38m, 27L, "Purchase of course 27" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 19L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 47.63m, 20L, "Purchase of course 20" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 20L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 26.38m, 3L, "Purchase of course 3" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 21L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 46.92m, 5L, "Purchase of course 5" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 22L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 78.32m, 30L, "Purchase of course 30" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 23L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 99.89m, 9L, "Purchase of course 9" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 24L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 99.39m, 11L, "Purchase of course 11" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 25L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 68.22m, 53L, "Purchase of course 53" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 26L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 27.93m, 34L, "Purchase of course 34" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 27L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 63.24m, 24L, "Purchase of course 24" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 28L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 33.51m, 20L, "Purchase of course 20" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 29L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 22.46m, 50L, "Purchase of course 50" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 30L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 88.02m, 27L, "Purchase of course 27" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "fcdc0978-de97-4ce0-ac1e-8ae9c80d7c3a", "AQAAAAIAAYagAAAAEIZfb6fd74/Zlnvl7v7XDx8Gok/ZYEvCqRZEYuSjUcVYWcCbDX9eKZnfjeNicjjNZQ==", "f0ecfd07-77bb-4df0-8ca2-6406f829a870", new DateTime(2025, 10, 18, 21, 38, 6, 329, DateTimeKind.Local).AddTicks(1702) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "9b2a4e75-f704-48d1-a463-91a9f81eefbb", "AQAAAAIAAYagAAAAEBLVrbAvoXOp1xbGoLgaVCmp9pRuUuQjC8xiszYyqqBXrH/KcpDMiFp/76BdB2fs8A==", "ceb31e18-42ae-4788-b784-fe38e9b727d9", new DateTime(2025, 10, 18, 21, 38, 6, 878, DateTimeKind.Local).AddTicks(6750) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "c5806daf-4577-485e-8e89-15d257394c11", "AQAAAAIAAYagAAAAENXX+lLCUGI7tkzlGHrZyh40ESNJD00vzpVUZQv2tnRnDX88M3lJVpKa3JfgckkZZA==", "1f03e79d-16e4-4ff2-8326-b37ff9d8beb0", new DateTime(2025, 10, 18, 21, 38, 6, 937, DateTimeKind.Local).AddTicks(3979) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "b659c74a-a941-459c-9c7a-1d93fedddcad", "AQAAAAIAAYagAAAAEP2Dgx5+7HyXMnmkZ2KI4cqDowlR2AlcOa8P4ZbjxCfEsxK9GciClzUR788rgjLfew==", "c52532dc-713c-4d8f-8059-95890328f1ef", new DateTime(2025, 10, 18, 21, 38, 7, 1, DateTimeKind.Local).AddTicks(6602) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "8e7a150e-e5bb-4c30-9c6d-132f5759971c", "AQAAAAIAAYagAAAAEC7Q3ishtv2+DcfefXzQJ/OdJFwV4PmsBak8Lj7+/m34NoH784H7m98UWDFlPUxP5g==", "c5c0e3e2-84a2-4eeb-89aa-ecae60b6f141", new DateTime(2025, 10, 18, 21, 38, 7, 59, DateTimeKind.Local).AddTicks(8359) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "499cb15b-2a02-4009-b0e6-d2724a1f5839", "AQAAAAIAAYagAAAAEPxpIASEKCqq4MicumbJ3WWAGGpQIxJqbUnUIPaXq55G4E8svQRUs24UPmJ7N6sXTA==", "a25b8860-43d8-4129-a460-b1222609411c", new DateTime(2025, 10, 18, 21, 38, 7, 118, DateTimeKind.Local).AddTicks(1721) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "28892de5-c481-4425-9545-c4b96f3468de", "AQAAAAIAAYagAAAAEEmKyXyysqrNpCkdb7k4DWTIWQvJpPN6mlI/I8lVH3NN7NlSpqLVTfaAlG0wtdYTuw==", "c90cee2f-c8a1-473f-a130-e05a5f782f78", new DateTime(2025, 10, 18, 21, 38, 7, 176, DateTimeKind.Local).AddTicks(4038) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "853a820b-954e-46e5-bb75-937cf9f2033f", "AQAAAAIAAYagAAAAEMpBctKOJm2lZ/b2iWb1NMDd5v8qwNBrdHxgpPT907FTl0u8HnGxzkOUtR6p3n1s7w==", "d0437274-3f04-431b-8ad2-78df6caaa448", new DateTime(2025, 10, 18, 21, 38, 7, 234, DateTimeKind.Local).AddTicks(7230) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "06c10ccc-3faa-4849-a439-bf9aaefb5616", "AQAAAAIAAYagAAAAEOEpYuATd+QF9u/Pc4BOigIayvisb6n4leiuVivT9nSMGcb0wibQpYAxSWWBV3mmaw==", "ce614cd4-a9e8-4977-a736-4e18e74daca4", new DateTime(2025, 10, 18, 21, 38, 7, 290, DateTimeKind.Local).AddTicks(8586) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "c25007dd-c33e-4bbe-a8e8-e3d0433919de", "AQAAAAIAAYagAAAAEBvxpDBHs6ZISf3eySttM+35JSX1V7Cn9LyBxvB4Qp0pFaSg+Ybq9L7amsY10X89Kw==", "54d7f0d3-638c-40a3-88a6-afe70d5bcff0", new DateTime(2025, 10, 18, 21, 38, 7, 348, DateTimeKind.Local).AddTicks(4309) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "2e94dd2b-2496-4948-9e96-b262ca817173", "AQAAAAIAAYagAAAAEMK8WhNUy0y1VlDtdCD8Qp+uuu9YtZf0XcjRxXk6CCsvS8Dkt4+Q0/RMlShap6gQew==", "0064fb93-5b25-4345-80d9-3a05e53b5b60", new DateTime(2025, 10, 18, 21, 38, 7, 409, DateTimeKind.Local).AddTicks(426) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "5ac546ba-7422-4e79-b07a-8dabab431108", "AQAAAAIAAYagAAAAEEZubzngWA802dA7Lp1IqQiDZxNvRiZ39sB6RIsXk+YonYCpHlRA+5DLOVJNhYrfjg==", "906dde5f-9f5b-431f-a3bc-f07b3b0fd84c", new DateTime(2025, 10, 18, 21, 38, 6, 389, DateTimeKind.Local).AddTicks(5476) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "3baa2dda-dbd1-416f-9612-6b3c12b9aaf9", "AQAAAAIAAYagAAAAEFBmyCKO1zE82k0S+NIDGzNJpg9v4LIJu6lS/7dQlW1BJhx+oCnYaszsZjar5/W3Gg==", "f5eb199d-77f3-45ca-86b2-012bbfec8186", new DateTime(2025, 10, 18, 21, 38, 7, 466, DateTimeKind.Local).AddTicks(7894) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "414758a8-b6a1-4b32-9915-37e06d4bf257", "AQAAAAIAAYagAAAAEIovU2az7B5xJPHEJf3tvqCaeZEZasiuPr0Q9dvHTZAJzQLr14VgMIsnkibeN+mBbw==", "68711941-9836-4b66-a395-3e9d15453b36", new DateTime(2025, 10, 18, 21, 38, 7, 524, DateTimeKind.Local).AddTicks(6872) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "3f1697d4-1610-4c69-b502-3d4894df722d", "AQAAAAIAAYagAAAAEHvnTg0nAtEXzD5bLui+uBGZtUjs7PFPHiDWgWA+YrAcpfNT05RmrkxsV7PtPJX/Lw==", "3cc9f6d6-e472-4f58-907e-e9085bed8345", new DateTime(2025, 10, 18, 21, 38, 7, 582, DateTimeKind.Local).AddTicks(9521) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "23",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "75049e14-5d51-43cb-af85-e6239486e2ed", "AQAAAAIAAYagAAAAECSwSlpFfYnK8A2BT+dZgh8fvtbwyBzRpw2n00kqLBbPHDNoGBYMxVmfxRzGzhe5Jg==", "3111a40c-ee6d-4934-b643-fd3bec9f0b4a", new DateTime(2025, 10, 18, 21, 38, 7, 640, DateTimeKind.Local).AddTicks(8360) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "24",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "1caa9979-edf1-43e9-a005-99d6f640525c", "AQAAAAIAAYagAAAAEKaUSuqGmlW6H4iywtUNRNepB2DwiFz/Sd5EDtWWnaOjzgypA3XMbl/9NNibyLZ4FA==", "1b824899-cd11-4f5a-958e-50c49709cfa1", new DateTime(2025, 10, 18, 21, 38, 7, 699, DateTimeKind.Local).AddTicks(1) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "25",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "f0f63cb5-8ae9-46b0-9629-83ef712d3e06", "AQAAAAIAAYagAAAAEHfrMSbnHn8CvzplRJDqbk+sJnPnLaILHpjmUcIRGGogFjC2e3kQQR71/lQVqH2ZfQ==", "31e1579c-684d-40d0-96ea-04ce8fbd2848", new DateTime(2025, 10, 18, 21, 38, 7, 759, DateTimeKind.Local).AddTicks(2026) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "26",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "d0d5d1c3-95d2-4183-b4f8-905ba08bd8b3", "AQAAAAIAAYagAAAAEGek1gtMtWQ4Wrxrrs7dMN5L+v17SuexlYaE+nwv35/7GW7IMiSgwQ6pQiwmSnvPRQ==", "c9247231-efdf-4feb-9661-6d13a7f1dab2", new DateTime(2025, 10, 18, 21, 38, 7, 816, DateTimeKind.Local).AddTicks(3602) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "eb0bfc1a-d918-4709-9ea1-72e34f6e4d6d", "AQAAAAIAAYagAAAAEPTlP7kHL2v2ynMvR5T6pl0sCrJDCfvVOOC8JpY2qhI85DJMtFyN4u5d0RURjOPcuA==", "86681898-cec9-41b3-b7b8-a2e23d6e0263", new DateTime(2025, 10, 18, 21, 38, 7, 874, DateTimeKind.Local).AddTicks(2550) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "28",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "c68e323f-963e-4ea6-80be-d11e3d735a39", "AQAAAAIAAYagAAAAEEDAENCW5J3N38z5yMR6Qcm0+f3nG3Ibv4+i1JdzW6Top6YgKuEZuJfx2t96m0fZyw==", "0aac0e09-adcf-4aed-b197-5181ff8b8a1a", new DateTime(2025, 10, 18, 21, 38, 7, 931, DateTimeKind.Local).AddTicks(1856) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "29",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "26199504-d8cc-4d41-91bc-8b666d8a5423", "AQAAAAIAAYagAAAAEMUL/gHOVJHhhjaUyekllxAzgW5RoZ/Cer8rOwwonp1zaaxZsV7gS7knHkBiBM3D5w==", "178de4ec-415a-4cca-a325-531f1b16e220", new DateTime(2025, 10, 18, 21, 38, 7, 992, DateTimeKind.Local).AddTicks(1742) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "a5ee4e1a-4cca-48ec-8127-02b35f533920", "AQAAAAIAAYagAAAAEF2GfhbHdet98FK7OwQmRHDz8kDcpGYBN3n6BQdE1FfW1/AB3sygPP/Mezwuxr2Xtg==", "a89db711-b034-4f12-af0e-3f3940d9c511", new DateTime(2025, 10, 18, 21, 38, 6, 452, DateTimeKind.Local).AddTicks(4573) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "30",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "ff82e5fb-ff2d-4235-8941-802d372197cf", "AQAAAAIAAYagAAAAENm8H2iAIj6KMg82P0zxDtzPUa9DqqjYvwOA3WmYbFAICCHidEaXl/rHsfj3LiBu0g==", "e2c8d359-51d1-4ac8-a945-346cb0fff55c", new DateTime(2025, 10, 18, 21, 38, 8, 50, DateTimeKind.Local).AddTicks(905) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "31",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "d54d05b5-2bb4-492f-b19c-7b48b54178f9", "AQAAAAIAAYagAAAAEFBV7nW/PBCGS+49dhn1aRy/ojFOeatheKkWdtpBEOeXlOfqU/T5R9ktLs5q1OpvNg==", "0231d7c6-1bea-4dc1-b7b1-90da0628a9bf", new DateTime(2025, 10, 18, 21, 38, 8, 108, DateTimeKind.Local).AddTicks(8867) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "32",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "794dae0b-71bb-4341-ad18-7bf80022925f", "AQAAAAIAAYagAAAAEDCnOPRuRA+5UY3Xz+UX2IokqR+bCiNQeLWsTW54vdcl48A0s3UYMSF6puKEB2Ap6w==", "ce72f310-d2b2-4e59-a9e1-0a96d02dd1cb", new DateTime(2025, 10, 18, 21, 38, 8, 165, DateTimeKind.Local).AddTicks(3862) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "33",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "0971ff20-ba43-413a-ae69-c0193dbcc92a", "AQAAAAIAAYagAAAAECPheYYJCtLLbg8PWC5vYZi+/Trg0eeU96fbxgmujiKb9NhcVdhJtVstfrkfF0xsow==", "0d8c5697-9781-4d4c-8009-daa06006935e", new DateTime(2025, 10, 18, 21, 38, 8, 223, DateTimeKind.Local).AddTicks(5419) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "34",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "7c53c474-06c9-460a-b8a4-b1c00c631f06", "AQAAAAIAAYagAAAAEJv0jcvRUFahlHWaUFs6AumIEVuR5cwHk0nuXfiutK9GwC2vxTmebD93BpR3hulQUA==", "b454410c-2386-46e9-8f31-d97f69f9ecef", new DateTime(2025, 10, 18, 21, 38, 8, 282, DateTimeKind.Local).AddTicks(3864) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "35",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "1f12e260-4ba1-415e-b7ff-298c03093d3d", "AQAAAAIAAYagAAAAEGcWhSlY3LIdYO5x2SHU9D/VCwk0UfRgY2Eyzap6LzcBQx0wsx5WmxqBIS2/VKAlrg==", "8d98c793-44cd-4cb2-8f93-5bff950efd23", new DateTime(2025, 10, 18, 21, 38, 8, 342, DateTimeKind.Local).AddTicks(1914) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "36",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "5f53bdf0-9799-4b03-a99b-9744b419631f", "AQAAAAIAAYagAAAAEMtiXVgUdFpQehtsza2D/w0xknhoIYHWzn4aBKMILR5Xav4gQT3MqX9YEfdRL1KhnQ==", "11cccff0-56cd-4be0-b34a-43327ca57d89", new DateTime(2025, 10, 18, 21, 38, 8, 401, DateTimeKind.Local).AddTicks(8673) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "37",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "926f15e2-bbd8-416f-922c-dc180f7e1fe0", "AQAAAAIAAYagAAAAEG9cAtaCVSc5gTvs9ZQ9ZY5lfrb5FwBLkXsFRmw0IfV1M6+uE9b1xqGtBhkFfGA/sw==", "1bd6dcd8-e0c1-4302-ad5a-06b50d4b254d", new DateTime(2025, 10, 18, 21, 38, 8, 459, DateTimeKind.Local).AddTicks(4448) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "38",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "9b2748ea-4eb2-42c0-b8ae-6c15bccdf362", "AQAAAAIAAYagAAAAEBsRP9AEiu0KREe2o1feoonGuuycS/pbqyoo9gBFWc0tivevrpTDXPHTZrpO++4MTw==", "c00d18f4-9bfa-4e0c-a0ff-9aad1b3eb859", new DateTime(2025, 10, 18, 21, 38, 8, 515, DateTimeKind.Local).AddTicks(8531) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "39",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "4e81bdfa-a34b-4e85-b0b1-3b7cf94a2c55", "AQAAAAIAAYagAAAAEK40vgPiy45r3+yTJkPRYzonZwzTycfVdtYSCvZhcfHlmpfdf0jtdbSrAFyU4mR1Dg==", "693e6a71-e2c4-4658-8b84-a102431b9500", new DateTime(2025, 10, 18, 21, 38, 8, 573, DateTimeKind.Local).AddTicks(8105) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "fd2ab18a-5747-493c-b5c0-454d8e9bd079", "AQAAAAIAAYagAAAAEGwTZSeH5ElZoeAPT8GHAkOFAu5v64gx3Xcsp4ND3rhn674ypWw9Yc4FTslcv8FsVA==", "a4720fae-5f0a-435e-932b-c17379397fe0", new DateTime(2025, 10, 18, 21, 38, 6, 512, DateTimeKind.Local).AddTicks(9525) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "40",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "344eaa18-2752-4996-986f-bf5a333a9776", "AQAAAAIAAYagAAAAEH2iuDICvdB/rQfdxVGjLIeP3Jz49diBCo7ELyFYuJKwfhW8345pyBeJ+3CaSJLwzA==", "2987cbd0-1b25-4702-8a26-f6cfdc163146", new DateTime(2025, 10, 18, 21, 38, 8, 633, DateTimeKind.Local).AddTicks(3022) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "41",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "dee6c316-9933-44c7-819c-eaff32342b67", "AQAAAAIAAYagAAAAEF86JJkncCAUkiXFrIHoqlVI80i4/5Aov95bgphXPHoi+dshX3yCdU+StTfVRYiBhg==", "88929b53-c06b-4bcd-8524-b0dc5803a009", new DateTime(2025, 10, 18, 21, 38, 8, 691, DateTimeKind.Local).AddTicks(3795) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "42",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "05064aaf-c475-4ff2-810f-d0bb778b1d1f", "AQAAAAIAAYagAAAAEM10Rm89MJtF4q9+F/Q39SiKvfuGzxms65EI3yU+eemJCpq8Ikb3sOG1Ph0erFMJZw==", "099a65e0-d082-4516-b5fd-e507b30c1d5d", new DateTime(2025, 10, 18, 21, 38, 8, 750, DateTimeKind.Local).AddTicks(6250) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "43",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "6414d3af-e19a-4ac5-9182-414992af6cdd", "AQAAAAIAAYagAAAAEJ4urGU4Gr5EEJMyGNpg75Ry3lnu771LNEGeYhvJ4oM5syR2mOQ9TQUE7WrvSFa5TQ==", "a7b898c9-c878-4044-835e-348dff61617a", new DateTime(2025, 10, 18, 21, 38, 8, 808, DateTimeKind.Local).AddTicks(8788) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "44",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "5ac713e3-183a-4e3d-bc3a-e0884cd47c54", "AQAAAAIAAYagAAAAEEpXheuUMl9kQF3x6Zlu0Q7g15kYz7QsbpqHUoZUaN/QQuyfvCmbO9oQQbcO1rhFZQ==", "21103905-7e61-4fca-8697-04033d219113", new DateTime(2025, 10, 18, 21, 38, 8, 867, DateTimeKind.Local).AddTicks(368) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "45",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "f4416ce4-d78c-4799-b653-092d8064a700", "AQAAAAIAAYagAAAAEP/riD6Y6bo7saEqzMkuKjjsJyoBXecTRQzZPUMbNrtl7dvN0OfQacfYCwAd0EVZpw==", "cecc4c74-ca15-475b-8799-bf368ed6a0e0", new DateTime(2025, 10, 18, 21, 38, 8, 924, DateTimeKind.Local).AddTicks(2714) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "46",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "0c6ca65c-0c5e-4686-b766-794529524c5a", "AQAAAAIAAYagAAAAEC63Rmt1s08Ha0I7HmfjlBHRs9zrkWvyKZ3ZsgDH+bFlp+9sZUrUbZU8SZppMnUI7A==", "7e3e3a5d-9ca7-4713-83ef-3866d4213dd8", new DateTime(2025, 10, 18, 21, 38, 8, 981, DateTimeKind.Local).AddTicks(2483) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "47",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "342d25bb-be72-4613-b8aa-ba18a731b22d", "AQAAAAIAAYagAAAAEKYcuuIkx9caM1pGcMN2j6KFzl/kfPyf12FeduM0Dc8Whx14kC5njcYWKkGnUtcw9Q==", "317d2957-dc5c-46b7-b485-85dfdece0cbb", new DateTime(2025, 10, 18, 21, 38, 9, 37, DateTimeKind.Local).AddTicks(3164) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "48",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "7a93465e-83c8-4ca8-aff4-cc3b2ec36344", "AQAAAAIAAYagAAAAEOkS8RS9YskChv2AJNgkMOci5NdKQ8t8Rafvhl/DwUssIF8D6gaoOc+4Ub1ju45cCQ==", "e9d68d22-697f-4d06-ba1d-0b637ed53bfe", new DateTime(2025, 10, 18, 21, 38, 9, 97, DateTimeKind.Local).AddTicks(6101) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "49",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "a9dc0bdb-e8be-49f0-a3f2-83f772d4f6cb", "AQAAAAIAAYagAAAAEDYYBGSX67IoZYynuYrKzl7NNKCAw1mgQJZA/cI94T1Qzm5Mwg5Dop7BzmD3/9xyWA==", "e2d0cec9-777f-4513-9ff7-4d37af85eae6", new DateTime(2025, 10, 18, 21, 38, 9, 157, DateTimeKind.Local).AddTicks(6528) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "deeb31d4-e573-4770-b2ba-c42c47c78143", "AQAAAAIAAYagAAAAEDiAvboW903QWCYoUkUEJZZm/EkajHIgcFC9sIsIYRMPBtbrtRCO4wI4v90i674arw==", "9258a17c-b7b2-43c1-b634-1ec03c8949f1", new DateTime(2025, 10, 18, 21, 38, 6, 586, DateTimeKind.Local).AddTicks(1704) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "50",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "42b98179-e182-4686-97d8-df37ae2747a1", "AQAAAAIAAYagAAAAEM1S6rv54xTrPyrI3wR2PF4NEtltstTT8pf02JXEI64MmS3fhL86nXBzJvvkq0XSVg==", "9449c6cd-f03a-43cb-bee2-08e9c7b565b4", new DateTime(2025, 10, 18, 21, 38, 9, 217, DateTimeKind.Local).AddTicks(3098) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "51",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "7f11b428-1db6-4086-8e3e-f66507c75300", "AQAAAAIAAYagAAAAEBeLuvI6A/WZtJ3R02R/LSy39hZ/+lKlTo55APrkbY9v9G6VGwlCodLOaN7AS1Y5jA==", "906b82cd-e529-4bec-9910-28c38817b12e", new DateTime(2025, 10, 18, 21, 38, 9, 277, DateTimeKind.Local).AddTicks(6215) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "52",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "67dfe65c-1fbc-4332-bc5d-333514bcd8d0", "AQAAAAIAAYagAAAAEOrVcRXc+z/F6MHPr4YJVHzRmKPB9wx5QDzPnoe+9zfd3pcfween5KnKrdhpgZ5rpA==", "de0ce23e-dc56-44ff-a893-600e68f8fbc5", new DateTime(2025, 10, 18, 21, 38, 9, 335, DateTimeKind.Local).AddTicks(6731) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "53",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "ee51c70f-fd2a-4ee2-930f-c4b117643af2", "AQAAAAIAAYagAAAAEGgp8gpHEZKkSy0zATBI0+crZZ4qW3KlBZrjATXa4xMDNMq2zX4shSE/9vSAc/R9TA==", "0706c8c1-b82b-4e32-a056-2f65cf50c575", new DateTime(2025, 10, 18, 21, 38, 9, 392, DateTimeKind.Local).AddTicks(8586) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "54",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "14afeca9-2edf-4d6c-b942-b46ee12fb990", "AQAAAAIAAYagAAAAEAGrSoacQw2kZqhwOm8j4S+nGSFAvljjwBlOeTFItTO7yvTNzTvOopZp6WHXpA7LMg==", "f7ede164-8196-48cd-9057-c4f72c550cd8", new DateTime(2025, 10, 18, 21, 38, 9, 450, DateTimeKind.Local).AddTicks(5028) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "55",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "26d4047b-46a2-422f-9dd9-df99f11854a6", "AQAAAAIAAYagAAAAEOuA282NHLRjFRyJGroqmoM9VVYmBxw76v7kBuYmUpN8NgSL+oacG4jPNR9n3IzHqg==", "608e7a49-4d1f-4e47-9140-6be6111090f7", new DateTime(2025, 10, 18, 21, 38, 9, 506, DateTimeKind.Local).AddTicks(7284) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "0a7d004b-ccac-491b-96c8-af28c951d9b4", "AQAAAAIAAYagAAAAEMEYmaJeUZAObhD+enSl0uSTaoy6BQfL5dOFVyki2QntCBtsNgxW/BZs5RlXHnoYbw==", "85ea980d-acb9-4803-9f6f-c354ec7cdf44", new DateTime(2025, 10, 18, 21, 38, 6, 643, DateTimeKind.Local).AddTicks(4241) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "ee1700f5-e3fd-4fdd-b1f6-11dcbed601b2", "AQAAAAIAAYagAAAAEPRB9MmNjKsQCjpHskzsvw10dIDzdYN8QzS8XMruk1+8ONZ2awfwssoAdEuWJcUGrw==", "b4d42c29-b5eb-41e6-990f-24858e8b7e9c", new DateTime(2025, 10, 18, 21, 38, 6, 702, DateTimeKind.Local).AddTicks(3899) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "ba67243e-1ee8-40ef-b094-a03e0a5613d4", "AQAAAAIAAYagAAAAECFBBDTn1PwgRqcYzqPnfxbKDfE4RUYgHhZzqsvYHXavbU/hY5p1VydGrusEz8cWUA==", "8847dcea-1ae6-43cd-b0ed-6e849318591a", new DateTime(2025, 10, 18, 21, 38, 6, 764, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "4b188695-f666-4ad7-ba5d-bb7cc6420887", "AQAAAAIAAYagAAAAEI4Fm1Bkh2fwPsBILgQgzuLchlOXFBtyr0S1FyKzBz1G9TgJgxm34g/sbruiSP9kvw==", "7be90cc9-c267-4dd9-8712-b14502f6cb5c", new DateTime(2025, 10, 18, 21, 38, 6, 821, DateTimeKind.Local).AddTicks(7421) });

            migrationBuilder.UpdateData(
                table: "WishLists",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 20L, "5" },
                column: "CreatedAt",
                value: new DateTime(2025, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "WishLists",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 24L, "5" },
                column: "CreatedAt",
                value: new DateTime(2025, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "WishLists",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 43L, "5" },
                column: "CreatedAt",
                value: new DateTime(2025, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "WishLists",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 27L, "6" },
                column: "CreatedAt",
                value: new DateTime(2025, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "WishLists",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 28L, "7" },
                column: "CreatedAt",
                value: new DateTime(2025, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "WishLists",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 33L, "7" },
                column: "CreatedAt",
                value: new DateTime(2025, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "WishLists",
                columns: new[] { "CourseId", "UserId", "CreatedAt" },
                values: new object[,]
                {
                    { 17L, "5", new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 29L, "5", new DateTime(2025, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 32L, "5", new DateTime(2025, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 50L, "5", new DateTime(2025, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4L, "6", new DateTime(2025, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 23L, "6", new DateTime(2025, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 25L, "6", new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 29L, "6", new DateTime(2025, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 31L, "6", new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 43L, "6", new DateTime(2025, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2L, "7", new DateTime(2025, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 22L, "7", new DateTime(2025, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 23L, "7", new DateTime(2025, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 29L, "7", new DateTime(2025, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 49L, "7", new DateTime(2025, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 10L, 1L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 2L, 3L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 6L, 3L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 8L, 3L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 6L, 4L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 1L, 5L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 2L, 6L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 5L, 6L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 8L, 6L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 10L, 7L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 6L, 8L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 5L, 9L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 1L, 10L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 6L, 10L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 5L, 11L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 8L, 11L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 9L, 11L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 4L, 12L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 1L, 13L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 2L, 13L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 7L, 13L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 8L, 14L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 2L, 15L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 7L, 15L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 7L, 16L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 2L, 17L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 3L, 17L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 5L, 17L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 4L, 18L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 4L, 19L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 7L, 19L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 4L, 20L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 5L, 20L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 2L, 21L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 6L, 21L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 2L, 22L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 1L, 23L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 4L, 23L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 9L, 23L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 1L, 24L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 2L, 24L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 8L, 24L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 3L, 25L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 4L, 25L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 8L, 25L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 7L, 26L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 10L, 26L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 2L, 27L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 6L, 27L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 8L, 27L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 9L, 28L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 3L, 29L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 4L, 29L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 1L, 30L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 2L, 30L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 5L, 30L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 4L, 31L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 8L, 31L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 6L, 32L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 7L, 33L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 2L, 34L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 3L, 34L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 9L, 34L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 1L, 35L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 2L, 35L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 4L, 35L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 2L, 36L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 4L, 36L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 9L, 36L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 10L, 37L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 4L, 38L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 10L, 38L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 3L, 39L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 9L, 39L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 1L, 40L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 4L, 41L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 7L, 41L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 9L, 41L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 3L, 42L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 7L, 42L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 5L, 43L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 8L, 43L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 9L, 43L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 2L, 44L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 1L, 45L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 2L, 45L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 9L, 45L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 1L, 46L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 4L, 46L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 10L, 46L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 1L, 47L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 4L, 47L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 10L, 47L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 5L, 48L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 10L, 48L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 5L, 49L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 9L, 49L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 10L, 49L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 2L, 50L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 10L, 50L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 1L, 51L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 2L, 52L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 6L, 52L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 9L, 52L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 2L, 53L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 5L, 53L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 8L, 53L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 4L, 54L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 6L, 54L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 7L, 55L });

            migrationBuilder.DeleteData(
                table: "CourseCategories",
                keyColumns: new[] { "CategoryId", "CourseId" },
                keyValues: new object[] { 9L, 55L });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 1L, "7" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 2L, "6" });

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
                keyValues: new object[] { 8L, "5" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 9L, "6" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 10L, "5" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 10L, "6" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 11L, "5" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 11L, "6" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 12L, "7" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 13L, "6" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 13L, "7" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 14L, "7" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 21L, "6" });

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
                keyValues: new object[] { 23L, "7" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 26L, "6" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 30L, "5" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 32L, "6" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 36L, "5" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 36L, "6" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 38L, "5" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 38L, "7" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 41L, "5" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 43L, "5" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 44L, "5" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 45L, "6" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 48L, "7" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 52L, "5" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 52L, "7" });

            migrationBuilder.DeleteData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 55L, "7" });

            migrationBuilder.DeleteData(
                table: "WishLists",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 17L, "5" });

            migrationBuilder.DeleteData(
                table: "WishLists",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 29L, "5" });

            migrationBuilder.DeleteData(
                table: "WishLists",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 32L, "5" });

            migrationBuilder.DeleteData(
                table: "WishLists",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 50L, "5" });

            migrationBuilder.DeleteData(
                table: "WishLists",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 4L, "6" });

            migrationBuilder.DeleteData(
                table: "WishLists",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 23L, "6" });

            migrationBuilder.DeleteData(
                table: "WishLists",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 25L, "6" });

            migrationBuilder.DeleteData(
                table: "WishLists",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 29L, "6" });

            migrationBuilder.DeleteData(
                table: "WishLists",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 31L, "6" });

            migrationBuilder.DeleteData(
                table: "WishLists",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 43L, "6" });

            migrationBuilder.DeleteData(
                table: "WishLists",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 2L, "7" });

            migrationBuilder.DeleteData(
                table: "WishLists",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 22L, "7" });

            migrationBuilder.DeleteData(
                table: "WishLists",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 23L, "7" });

            migrationBuilder.DeleteData(
                table: "WishLists",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 29L, "7" });

            migrationBuilder.DeleteData(
                table: "WishLists",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 49L, "7" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "IsDeleted" },
                values: new object[,]
                {
                    { 11L, "Cybersecurity", false },
                    { 12L, "Cloud Computing", false },
                    { 13L, "DevOps", false },
                    { 14L, "Blockchain", false },
                    { 15L, "Game Development", false },
                    { 16L, "UI/UX Design", false },
                    { 17L, "Digital Marketing", false },
                    { 18L, "SEO (Search Engine Optimization)", false },
                    { 19L, "Content Marketing", false },
                    { 20L, "Social Media Marketing", false },
                    { 21L, "Finance", false },
                    { 22L, "Accounting", false },
                    { 23L, "Entrepreneurship", false },
                    { 24L, "Project Management", false },
                    { 25L, "Leadership", false },
                    { 26L, "Personal Development", false },
                    { 27L, "Health & Fitness", false },
                    { 28L, "Music", false },
                    { 29L, "Language Learning", false },
                    { 30L, "History", false },
                    { 31L, "Science", false },
                    { 32L, "Mathematics", false },
                    { 33L, "Writing", false },
                    { 34L, "Public Speaking", false },
                    { 35L, "Graphic Design", false },
                    { 36L, "Video Production", false },
                    { 37L, "Animation", false },
                    { 38L, "Architecture", false },
                    { 39L, "Cooking & Culinary Arts", false },
                    { 40L, "Crafts & DIY", false },
                    { 41L, "Yoga & Meditation", false },
                    { 42L, "Personal Finance & Investing", false },
                    { 43L, "Real Estate", false },
                    { 44L, "Data Analysis", false },
                    { 45L, "Software Testing (QA)", false },
                    { 46L, "IT & Networking", false },
                    { 47L, "Human Resources", false },
                    { 48L, "Sales & Persuasion", false },
                    { 49L, "Philosophy", false },
                    { 50L, "Psychology", false },
                    { 51L, "Creative Writing", false },
                    { 52L, "Music Production", false },
                    { 53L, "Game Design", false },
                    { 54L, "Copywriting", false },
                    { 55L, "Stock Trading", false }
                });

            migrationBuilder.InsertData(
                table: "CourseCategories",
                columns: new[] { "CategoryId", "CourseId" },
                values: new object[,]
                {
                    { 4L, 1L },
                    { 4L, 4L },
                    { 6L, 6L },
                    { 10L, 8L },
                    { 7L, 9L },
                    { 2L, 12L },
                    { 9L, 13L },
                    { 9L, 17L },
                    { 8L, 18L },
                    { 5L, 19L },
                    { 7L, 20L },
                    { 3L, 21L },
                    { 2L, 28L },
                    { 3L, 31L },
                    { 5L, 31L },
                    { 4L, 32L },
                    { 2L, 37L },
                    { 1L, 38L },
                    { 2L, 39L },
                    { 3L, 49L },
                    { 5L, 52L },
                    { 3L, 54L }
                });

            migrationBuilder.UpdateData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 3L, "6" },
                column: "DateCreated",
                value: new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 5L, "6" },
                column: "DateCreated",
                value: new DateTime(2025, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 9L, "7" },
                column: "DateCreated",
                value: new DateTime(2025, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 12L, "5" },
                column: "DateCreated",
                value: new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 19L, "7" },
                column: "DateCreated",
                value: new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 20L, "6" },
                column: "DateCreated",
                value: new DateTime(2025, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 26L, "5" },
                column: "DateCreated",
                value: new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 37L, "5" },
                column: "DateCreated",
                value: new DateTime(2025, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 49L, "6" },
                column: "DateCreated",
                value: new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 50L, "7" },
                column: "DateCreated",
                value: new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 52L, "6" },
                column: "DateCreated",
                value: new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "CourseEnrollments",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 53L, "5" },
                column: "DateCreated",
                value: new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "CourseEnrollments",
                columns: new[] { "CourseId", "UserId", "DateCreated", "ModifiedDate" },
                values: new object[,]
                {
                    { 2L, "7", new DateTime(2025, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 3L, "7", new DateTime(2025, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 4L, "7", new DateTime(2025, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 6L, "7", new DateTime(2025, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 8L, "7", new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 12L, "6", new DateTime(2025, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 14L, "5", new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 15L, "7", new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 17L, "7", new DateTime(2025, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 18L, "5", new DateTime(2025, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 19L, "6", new DateTime(2025, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 23L, "6", new DateTime(2025, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 25L, "5", new DateTime(2025, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 26L, "7", new DateTime(2025, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 31L, "5", new DateTime(2025, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 31L, "6", new DateTime(2025, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 33L, "5", new DateTime(2025, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 34L, "5", new DateTime(2025, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 35L, "6", new DateTime(2025, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 39L, "6", new DateTime(2025, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 40L, "5", new DateTime(2025, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 41L, "7", new DateTime(2025, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 42L, "5", new DateTime(2025, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 42L, "6", new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 43L, "6", new DateTime(2025, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 44L, "7", new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 46L, "5", new DateTime(2025, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 46L, "7", new DateTime(2025, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 49L, "7", new DateTime(2025, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 50L, "5", new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 51L, "5", new DateTime(2025, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 54L, "6", new DateTime(2025, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 55L, "6", new DateTime(2025, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 1L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "4", "21 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 2L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "3", "20 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 3L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "2", "5 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 5L,
                column: "StudyTime",
                value: "18 hours");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 6L,
                column: "StudyTime",
                value: "12 hours");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 7L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "4", "28 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 8L,
                column: "StudyTime",
                value: "7 hours");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 9L,
                column: "StudyTime",
                value: "5 hours");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 10L,
                column: "StudyTime",
                value: "13 hours");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 11L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "4", "14 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 12L,
                column: "StudyTime",
                value: "8 hours");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 13L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "2", "19 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 14L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "4", "25 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 15L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "2", "5 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 16L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "2", "27 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 17L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "2", "24 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 18L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "3", "22 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 19L,
                column: "StudyTime",
                value: "30 hours");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 20L,
                column: "StudyTime",
                value: "16 hours");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 21L,
                column: "StudyTime",
                value: "24 hours");

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
                values: new object[] { "4", "21 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 24L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "2", "30 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 25L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "3", "28 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 26L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "3", "10 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 27L,
                column: "StudyTime",
                value: "4 hours");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 28L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "3", "15 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 29L,
                column: "StudyTime",
                value: "7 hours");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 30L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "2", "24 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 31L,
                column: "MentorId",
                value: "3");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 32L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "2", "9 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 33L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "2", "26 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 34L,
                column: "StudyTime",
                value: "12 hours");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 35L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "3", "29 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 36L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "3", "13 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 37L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "2", "11 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 38L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "2", "27 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 39L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "2", "29 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 40L,
                column: "StudyTime",
                value: "24 hours");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 41L,
                column: "MentorId",
                value: "3");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 42L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "4", "4 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 43L,
                column: "StudyTime",
                value: "17 hours");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 44L,
                column: "StudyTime",
                value: "14 hours");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 45L,
                column: "MentorId",
                value: "3");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 46L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "2", "19 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 47L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "2", "24 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 48L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "2", "4 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 49L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "2", "18 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 50L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "4", "19 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 51L,
                column: "StudyTime",
                value: "26 hours");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 52L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "3", "8 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 53L,
                column: "StudyTime",
                value: "30 hours");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 54L,
                columns: new[] { "MentorId", "StudyTime" },
                values: new object[] { "4", "14 hours" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 55L,
                column: "StudyTime",
                value: "12 hours");

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 1L,
                columns: new[] { "Content", "IsRead", "ReceiverId", "SenderId" },
                values: new object[] { "Welcome aboard! We're thrilled to have you as part of our learning community.", true, "25", "2" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 2L,
                columns: new[] { "Content", "IsRead", "ReceiverId", "SenderId" },
                values: new object[] { "Welcome aboard! We're thrilled to have you as part of our learning community.", false, "32", "2" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 3L,
                columns: new[] { "Content", "IsRead", "ReceiverId", "SenderId" },
                values: new object[] { "We have a new course on Advanced C# that you might be interested in. Check it out!", false, "30", "4" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 4L,
                columns: new[] { "Content", "IsRead", "ReceiverId", "SenderId" },
                values: new object[] { "A quick check-in to see how you are enjoying the platform. Any feedback is welcome!", true, "39", "4" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 5L,
                columns: new[] { "IsRead", "ReceiverId", "SenderId" },
                values: new object[] { true, "32", "3" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 6L,
                columns: new[] { "Content", "IsRead", "ReceiverId", "SenderId" },
                values: new object[] { "Welcome aboard! We're thrilled to have you as part of our learning community.", false, "7", "3" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 7L,
                columns: new[] { "Content", "IsRead", "ReceiverId", "SenderId" },
                values: new object[] { "Do you have any questions or need assistance with your current lesson? We're here to help.", true, "50", "3" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 8L,
                columns: new[] { "Content", "IsRead", "ReceiverId", "SenderId" },
                values: new object[] { "Hello! We noticed you're making great progress in your course. Keep up the excellent work!", true, "26", "1" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 9L,
                columns: new[] { "Content", "ReceiverId", "SenderId" },
                values: new object[] { "Did you know you can download course resources from the 'Materials' tab? Hope this helps!", "13", "3" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 10L,
                columns: new[] { "Content", "IsRead", "ReceiverId", "SenderId" },
                values: new object[] { "Welcome aboard! We're thrilled to have you as part of our learning community.", false, "7", "1" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 11L,
                columns: new[] { "IsRead", "ReceiverId", "SenderId" },
                values: new object[] { false, "19", "2" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 12L,
                columns: new[] { "ReceiverId", "SenderId" },
                values: new object[] { "30", "2" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 13L,
                columns: new[] { "Content", "ReceiverId" },
                values: new object[] { "Welcome aboard! We're thrilled to have you as part of our learning community.", "47" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 14L,
                columns: new[] { "Content", "ReceiverId", "SenderId" },
                values: new object[] { "Just a friendly reminder that a new module has been unlocked in your course.", "8", "2" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 15L,
                columns: new[] { "Content", "ReceiverId", "SenderId" },
                values: new object[] { "Just a friendly reminder that a new module has been unlocked in your course.", "15", "1" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 16L,
                columns: new[] { "Content", "ReceiverId" },
                values: new object[] { "Your learning journey is inspiring! Don't hesitate to reach out to the community for discussions.", "23" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 17L,
                columns: new[] { "IsRead", "ReceiverId" },
                values: new object[] { false, "8" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 18L,
                columns: new[] { "Content", "ReceiverId" },
                values: new object[] { "Just a friendly reminder that a new module has been unlocked in your course.", "20" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 19L,
                columns: new[] { "Content", "ReceiverId", "SenderId" },
                values: new object[] { "Did you know you can download course resources from the 'Materials' tab? Hope this helps!", "20", "1" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 20L,
                columns: new[] { "Content", "IsRead", "ReceiverId", "SenderId" },
                values: new object[] { "Your learning journey is inspiring! Don't hesitate to reach out to the community for discussions.", true, "33", "1" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 21L,
                columns: new[] { "Content", "ReceiverId" },
                values: new object[] { "Do you have any questions or need assistance with your current lesson? We're here to help.", "14" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 22L,
                columns: new[] { "Content", "ReceiverId" },
                values: new object[] { "A quick check-in to see how you are enjoying the platform. Any feedback is welcome!", "54" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 23L,
                columns: new[] { "Content", "IsRead", "ReceiverId", "SenderId" },
                values: new object[] { "A quick check-in to see how you are enjoying the platform. Any feedback is welcome!", false, "17", "4" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 24L,
                columns: new[] { "Content", "ReceiverId", "SenderId" },
                values: new object[] { "We have a new course on Advanced C# that you might be interested in. Check it out!", "40", "1" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 25L,
                columns: new[] { "Content", "IsRead", "ReceiverId", "SenderId" },
                values: new object[] { "We have a new course on Advanced C# that you might be interested in. Check it out!", true, "22", "4" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 26L,
                column: "Content",
                value: "A quick check-in to see how you are enjoying the platform. Any feedback is welcome!");

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 27L,
                columns: new[] { "Content", "IsRead", "ReceiverId", "SenderId" },
                values: new object[] { "Do you have any questions or need assistance with your current lesson? We're here to help.", true, "47", "2" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 28L,
                columns: new[] { "Content", "ReceiverId", "SenderId" },
                values: new object[] { "We have a new course on Advanced C# that you might be interested in. Check it out!", "55", "1" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 29L,
                columns: new[] { "Content", "IsRead", "ReceiverId", "SenderId" },
                values: new object[] { "Did you know you can download course resources from the 'Materials' tab? Hope this helps!", false, "45", "4" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 30L,
                columns: new[] { "Content", "ReceiverId", "SenderId" },
                values: new object[] { "Did you know you can download course resources from the 'Materials' tab? Hope this helps!", "6", "3" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 31L,
                columns: new[] { "Content", "ReceiverId" },
                values: new object[] { "Do you have any questions or need assistance with your current lesson? We're here to help.", "18" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 32L,
                columns: new[] { "Content", "IsRead", "ReceiverId", "SenderId" },
                values: new object[] { "We have a new course on Advanced C# that you might be interested in. Check it out!", true, "20", "4" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 33L,
                columns: new[] { "Content", "IsRead", "ReceiverId", "SenderId" },
                values: new object[] { "We have a new course on Advanced C# that you might be interested in. Check it out!", true, "46", "3" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 34L,
                columns: new[] { "Content", "IsRead", "ReceiverId", "SenderId" },
                values: new object[] { "We have a new course on Advanced C# that you might be interested in. Check it out!", false, "43", "2" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 35L,
                columns: new[] { "Content", "IsRead", "ReceiverId", "SenderId" },
                values: new object[] { "Do you have any questions or need assistance with your current lesson? We're here to help.", false, "41", "3" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 36L,
                columns: new[] { "Content", "ReceiverId", "SenderId" },
                values: new object[] { "Hello! We noticed you're making great progress in your course. Keep up the excellent work!", "26", "4" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 37L,
                columns: new[] { "Content", "ReceiverId" },
                values: new object[] { "Hello! We noticed you're making great progress in your course. Keep up the excellent work!", "7" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 38L,
                columns: new[] { "Content", "ReceiverId", "SenderId" },
                values: new object[] { "Your learning journey is inspiring! Don't hesitate to reach out to the community for discussions.", "43", "1" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 39L,
                columns: new[] { "IsRead", "ReceiverId", "SenderId" },
                values: new object[] { true, "34", "2" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 40L,
                columns: new[] { "Content", "IsRead", "ReceiverId", "SenderId" },
                values: new object[] { "A quick check-in to see how you are enjoying the platform. Any feedback is welcome!", true, "21", "4" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 41L,
                columns: new[] { "Content", "ReceiverId", "SenderId" },
                values: new object[] { "Do you have any questions or need assistance with your current lesson? We're here to help.", "33", "1" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 42L,
                columns: new[] { "Content", "IsRead", "ReceiverId", "SenderId" },
                values: new object[] { "We have a new course on Advanced C# that you might be interested in. Check it out!", false, "55", "4" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 43L,
                columns: new[] { "Content", "IsRead", "ReceiverId", "SenderId" },
                values: new object[] { "A quick check-in to see how you are enjoying the platform. Any feedback is welcome!", false, "50", "4" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 44L,
                columns: new[] { "Content", "IsRead", "ReceiverId", "SenderId" },
                values: new object[] { "Welcome aboard! We're thrilled to have you as part of our learning community.", false, "22", "3" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 45L,
                columns: new[] { "Content", "ReceiverId", "SenderId" },
                values: new object[] { "Hello! We noticed you're making great progress in your course. Keep up the excellent work!", "9", "3" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 46L,
                columns: new[] { "Content", "IsRead", "ReceiverId", "SenderId" },
                values: new object[] { "A quick check-in to see how you are enjoying the platform. Any feedback is welcome!", false, "31", "4" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 47L,
                columns: new[] { "Content", "IsRead", "ReceiverId", "SenderId" },
                values: new object[] { "Did you know you can download course resources from the 'Materials' tab? Hope this helps!", false, "55", "3" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 48L,
                columns: new[] { "Content", "IsRead", "ReceiverId", "SenderId" },
                values: new object[] { "Did you know you can download course resources from the 'Materials' tab? Hope this helps!", true, "53", "4" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 49L,
                columns: new[] { "Content", "ReceiverId", "SenderId" },
                values: new object[] { "Welcome aboard! We're thrilled to have you as part of our learning community.", "10", "4" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 50L,
                columns: new[] { "Content", "ReceiverId" },
                values: new object[] { "A quick check-in to see how you are enjoying the platform. Any feedback is welcome!", "30" });

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 1L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2251));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 2L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2283));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 3L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2287));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 4L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2289));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 5L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2290));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 6L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2294));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 7L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2295));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 8L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2296));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 9L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2297));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 10L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2299));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 11L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2300));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 12L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2301));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 13L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2302));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 14L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2303));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 15L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2304));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 16L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2305));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 17L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2306));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 18L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2308));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 19L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2309));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 20L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2310));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 21L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2311));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 22L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2321));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 23L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2322));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 24L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2323));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 25L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2324));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 26L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2325));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 27L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2327));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 28L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2328));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 29L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2329));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 30L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2330));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 31L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2331));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 32L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2332));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 33L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2333));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 34L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2335));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 35L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2336));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 36L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2337));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 37L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2338));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 38L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2339));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 39L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2340));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 40L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2341));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 41L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2342));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 42L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2343));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 43L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2344));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 44L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2345));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 45L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2346));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 46L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2347));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 47L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2348));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 48L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2349));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 49L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2350));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 50L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2351));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 51L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2352));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 52L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2353));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 53L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2354));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 54L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2355));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 55L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2356));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 56L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2358));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 57L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2359));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 58L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2360));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 59L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2361));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 60L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2362));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 61L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2363));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 62L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2364));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 63L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2365));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 64L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2366));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 65L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2367));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 66L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2369));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 67L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2370));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 68L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2371));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 69L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2372));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 70L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2373));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 71L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2374));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 72L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2375));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 73L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2376));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 74L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2377));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 75L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2378));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 76L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2379));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 77L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2387));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 78L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2388));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 79L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2389));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 80L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2390));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 81L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2391));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 82L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2392));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 83L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2393));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 84L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2394));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 85L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2395));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 86L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2396));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 87L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2397));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 88L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2398));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 89L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2399));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 90L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2400));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 91L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2401));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 92L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2402));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 93L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2403));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 94L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2404));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 95L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2405));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 96L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2406));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 97L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2407));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 98L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2408));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 99L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2409));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 100L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2410));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 101L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2411));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 102L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2412));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 103L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2413));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 104L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2414));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 105L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2415));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 106L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2416));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 107L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2418));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 108L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2419));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 109L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2420));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 110L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2421));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 111L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2422));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 112L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2423));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 113L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2424));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 114L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2425));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 115L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2426));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 116L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2427));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 117L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2428));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 118L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2429));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 119L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2430));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 120L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2431));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 121L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2432));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 122L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2433));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 123L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2434));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 124L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2435));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 125L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2436));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 126L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2437));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 127L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2438));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 128L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2439));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 129L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2440));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 130L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2448));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 131L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2449));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 132L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2450));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 133L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2451));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 134L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2452));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 135L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2453));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 136L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2454));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 137L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2455));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 138L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2456));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 139L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2457));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 140L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2458));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 141L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2459));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 142L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2460));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 143L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2461));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 144L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2462));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 145L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2463));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 146L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2464));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 147L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2465));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 148L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2466));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 149L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2467));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 150L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2469));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 151L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2470));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 152L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2471));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 153L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2472));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 154L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2473));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 155L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2474));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 156L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2475));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 157L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2476));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 158L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2477));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 159L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2478));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 160L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2479));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 161L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2480));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 162L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2481));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 163L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2482));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 164L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2483));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 165L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2484));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 166L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2485));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 167L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2486));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 168L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2487));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 169L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2488));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 170L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2489));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 171L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2490));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 172L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2491));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 173L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2492));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 174L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2493));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 175L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2494));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 176L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2495));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 177L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2496));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 178L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2497));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 179L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2499));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 180L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2500));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 181L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2501));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 182L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2502));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 183L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2503));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 184L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2504));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 185L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2505));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 186L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2506));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 187L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2507));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 188L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2508));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 189L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2509));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 190L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2510));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 191L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2511));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 192L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2512));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 193L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2513));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 194L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2514));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 195L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2515));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 196L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2522));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 197L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2523));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 198L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2525));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 199L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2526));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 200L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2527));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 201L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2528));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 202L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2529));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 203L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2530));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 204L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2531));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 205L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2532));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 206L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2533));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 207L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2534));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 208L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2535));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 209L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2536));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 210L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2537));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 211L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2538));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 212L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2539));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 213L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2540));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 214L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2541));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 215L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2542));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 216L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2543));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 217L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2544));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 218L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2545));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 219L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2546));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 220L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2547));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 221L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2548));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 222L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2549));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 223L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2550));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 224L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2551));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 225L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2552));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 226L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2553));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 227L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2554));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 228L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2555));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 229L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2556));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 230L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2558));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 231L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2559));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 232L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2560));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 233L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2561));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 234L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2562));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 235L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2563));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 236L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2564));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 237L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2565));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 238L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2566));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 239L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2567));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 240L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2568));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 241L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2569));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 242L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2570));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 243L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2571));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 244L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2572));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 245L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2573));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 246L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2574));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 247L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2575));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 248L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2576));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 249L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2577));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 250L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2578));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 251L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2579));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 252L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2580));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 253L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2581));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 254L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2582));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 255L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2583));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 256L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2584));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 257L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2585));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 258L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2593));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 259L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2594));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 260L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2596));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 261L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2597));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 262L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2598));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 263L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2599));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 264L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2600));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 265L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2601));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 266L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2602));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 267L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2603));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 268L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2604));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 269L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2605));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 270L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2606));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 271L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2607));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 272L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2608));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 273L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2609));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 274L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2610));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 275L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2611));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 276L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2612));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 277L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2613));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 278L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2614));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 279L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2615));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 280L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2616));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 281L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2617));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 282L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2618));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 283L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2619));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 284L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2620));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 285L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2621));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 286L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2623));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 287L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2624));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 288L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2625));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 289L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2626));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 290L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2627));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 291L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2628));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 292L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2629));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 293L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2630));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 294L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2631));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 295L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2632));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 296L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2633));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 297L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2634));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 298L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2635));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 299L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2642));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 300L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2643));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 301L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2644));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 302L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2646));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 303L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2647));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 304L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2648));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 305L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2649));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 306L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2650));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 307L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2651));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 308L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2652));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 309L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2653));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 310L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2654));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 311L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2655));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 312L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2656));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 313L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2657));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 314L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2658));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 315L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2659));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 316L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2660));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 317L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2661));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 318L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2662));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 319L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2663));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 320L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2664));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 321L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2665));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 322L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2666));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 323L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2667));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 324L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2668));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 325L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2669));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 326L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2670));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 327L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2671));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 328L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2672));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 329L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2673));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 330L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2674));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 331L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2675));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 332L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2676));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 333L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2677));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 334L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2678));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 335L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2679));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 336L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2680));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 337L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2681));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 338L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2682));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 339L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2683));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 340L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2684));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 341L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2685));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 342L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2686));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 343L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2687));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 344L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2688));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 345L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2689));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 346L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2691));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 347L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2692));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 348L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2693));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 349L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2694));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 350L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2695));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 351L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2696));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 352L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2697));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 353L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2698));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 354L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2699));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 355L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2700));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 356L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2701));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 357L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2702));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 358L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2703));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 359L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2704));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 360L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2705));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 361L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2706));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 362L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2707));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 363L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2708));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 364L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2709));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 365L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2710));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 366L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2711));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 367L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2755));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 368L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2756));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 369L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2758));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 370L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2759));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 371L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2760));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 372L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2761));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 373L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2762));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 374L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2763));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 375L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2764));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 376L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2765));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 377L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2766));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 378L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2768));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 379L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2769));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 380L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2770));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 381L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2771));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 382L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2772));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 383L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2773));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 384L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2774));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 385L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2775));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 386L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2776));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 387L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2777));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 388L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 389L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2779));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 390L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2780));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 391L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2781));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 392L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2782));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 393L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2783));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 394L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2784));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 395L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2785));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 396L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2786));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 397L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2787));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 398L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2788));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 399L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2789));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 400L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2790));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 401L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2791));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 402L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2792));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 403L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2793));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 404L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2794));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 405L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2795));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 406L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2796));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 407L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2797));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 408L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2798));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 409L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2800));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 410L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2801));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 411L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2802));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 412L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2803));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 413L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2804));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 414L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2805));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 415L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2806));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 416L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2807));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 417L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2808));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 418L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2809));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 419L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2810));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 420L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2811));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 421L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2812));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 422L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2813));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 423L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2814));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 424L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2815));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 425L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2816));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 426L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2817));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 427L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2819));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 428L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2820));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 429L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2821));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 430L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2822));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 431L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2823));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 432L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2824));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 433L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2825));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 434L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2826));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 435L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2838));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 436L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2839));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 437L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2840));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 438L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2841));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 439L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2842));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 440L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2843));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 441L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2844));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 442L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2845));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 443L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2846));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 444L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2847));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 445L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2848));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 446L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2849));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 447L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2851));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 448L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2852));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 449L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2853));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 450L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2854));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 451L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2855));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 452L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2856));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 453L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2857));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 454L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2858));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 455L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2859));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 456L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2860));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 457L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2861));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 458L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2862));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 459L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2863));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 460L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2864));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 461L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2865));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 462L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2866));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 463L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2867));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 464L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2868));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 465L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 21, 4, 3, 19, DateTimeKind.Local).AddTicks(2869));

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 1L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 64.85m, 27L, "Purchase of course 27" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 2L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 92.02m, 43L, "Purchase of course 43" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 3L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 30.55m, 50L, "Purchase of course 50" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 4L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 89.76m, 46L, "Purchase of course 46" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 5L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 92.08m, 39L, "Purchase of course 39" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 6L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 61.49m, 17L, "Purchase of course 17" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 7L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 43.16m, 52L, "Purchase of course 52" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 8L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 55.50m, 8L, "Purchase of course 8" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 9L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 30.17m, 20L, "Purchase of course 20" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 10L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 49.01m, 15L, "Purchase of course 15" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 11L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 95.19m, 54L, "Purchase of course 54" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 12L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 39.69m, 22L, "Purchase of course 22" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 13L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 74.47m, 32L, "Purchase of course 32" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 14L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 42.10m, 51L, "Purchase of course 51" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 15L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 61.30m, 43L, "Purchase of course 43" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 16L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 48.48m, 50L, "Purchase of course 50" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 17L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 51.16m, 46L, "Purchase of course 46" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 18L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 24.54m, 25L, "Purchase of course 25" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 19L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 44.90m, 33L, "Purchase of course 33" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 20L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 59.09m, 1L, "Purchase of course 1" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 21L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 58.02m, 43L, "Purchase of course 43" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 22L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 91.16m, 39L, "Purchase of course 39" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 23L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 88.02m, 12L, "Purchase of course 12" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 24L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 94.64m, 40L, "Purchase of course 40" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 25L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 27.22m, 29L, "Purchase of course 29" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 26L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 38.16m, 14L, "Purchase of course 14" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 27L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 75.64m, 49L, "Purchase of course 49" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 28L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 75.45m, 33L, "Purchase of course 33" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 29L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 51.51m, 13L, "Purchase of course 13" });

            migrationBuilder.UpdateData(
                table: "TransactionHistories",
                keyColumn: "TransactionId",
                keyValue: 30L,
                columns: new[] { "Amount", "CourseId", "Description" },
                values: new object[] { 63.65m, 16L, "Purchase of course 16" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "89583daf-057f-4d81-abde-9adb250886e1", "AQAAAAIAAYagAAAAEMAG1JGOpXskoM9idkDrrJey30jaMVWTANxNKHngYN65nX1gpylkFt/CnaGIlhTefg==", "9cb11ba4-f19a-4a76-99a2-eee2e101f435", new DateTime(2025, 10, 18, 21, 4, 0, 302, DateTimeKind.Local).AddTicks(4983) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "5e049dd4-898c-482d-ba69-bdb9c980a000", "AQAAAAIAAYagAAAAEN+morgDWeM4qqK35GH6GeS/zNQkaHuShriGwY70nVkBmzIoftDMxZ1K50WCBpcTIg==", "7c9e5e1d-687d-414b-a2c4-4a25dd406de9", new DateTime(2025, 10, 18, 21, 4, 0, 740, DateTimeKind.Local).AddTicks(5672) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "ca1f4969-ad08-477b-8f13-5c212e816f63", "AQAAAAIAAYagAAAAEON446AOu8ynKzAuhpFwOlwc2biGOutu/GzLrmi4ksjgO0sxmApAYrjHXV7Tsjptzg==", "387c732e-5c0a-4911-84c6-e664bcf04092", new DateTime(2025, 10, 18, 21, 4, 0, 788, DateTimeKind.Local).AddTicks(4716) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "19180f32-1a95-4820-bec3-58ccbf1c8ec1", "AQAAAAIAAYagAAAAEHFl/9KO6vGh4X/VvPqMLge4L9YH4zjWnAGWgWzJK0NfGTSysnGHGohOe9E/a01nKw==", "d22c9216-8a30-4185-a6ca-9a030c30fc01", new DateTime(2025, 10, 18, 21, 4, 0, 836, DateTimeKind.Local).AddTicks(1075) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "4ce6649c-7926-4609-889c-a03de73ec7fd", "AQAAAAIAAYagAAAAEET1QeCtlMTOVqo1tbWtQuKDMShW14B/GT2wCQm12HYkuJucW2UKyXmifhZBiW8Tsw==", "4ab9c63c-8fcf-4e7a-9331-228b8a418205", new DateTime(2025, 10, 18, 21, 4, 0, 882, DateTimeKind.Local).AddTicks(5093) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "19ec6144-79bc-499d-b679-0742a0611151", "AQAAAAIAAYagAAAAEIe+ohdeDA+akPXo24HkqCZqNtOo8nwszjX1L7eH2YumWkIbs7L9Jr93DI1pk+hctg==", "1d990eeb-15f0-45f1-ad42-06aa27a5034f", new DateTime(2025, 10, 18, 21, 4, 0, 928, DateTimeKind.Local).AddTicks(7047) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "850c7478-ffdd-4b62-b38c-085819b5f47e", "AQAAAAIAAYagAAAAEOE9ZQFFegZFgwAMNM25uHBdXmIysZDOLJy5A/vtu7zPfKLSIGu+BjjnmA3ZH7iuMQ==", "50cbfe89-da6b-42c8-ab46-d2f72ddeb82a", new DateTime(2025, 10, 18, 21, 4, 0, 974, DateTimeKind.Local).AddTicks(7958) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "84a39403-b5c4-4012-a6bf-55fda646e6c9", "AQAAAAIAAYagAAAAENNkmzpWHJBkUjlDX2XOhknphgFj8d03j8bnJlkRlvCTXlOm9E0Bg9wyuT2F4JLUJw==", "b401a0f8-20a3-4467-affa-df8c739e5e94", new DateTime(2025, 10, 18, 21, 4, 1, 21, DateTimeKind.Local).AddTicks(5895) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "756fdd46-a959-489b-a8c0-d792e4e64ef0", "AQAAAAIAAYagAAAAEH3iGCAJiUsM2T+cki74Z5ybqvaA/qkIzoca/gaI3a/5Q0b4KYTQhQBSv/T7sJx7gA==", "f7b7f050-4a4c-4498-9bc5-f6680c3d4398", new DateTime(2025, 10, 18, 21, 4, 1, 68, DateTimeKind.Local).AddTicks(7567) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "d2e8f53e-f07d-4c6a-84f1-a3ab250450d9", "AQAAAAIAAYagAAAAECSVdKCs6x0r1FnGxITVbQrLbvxZ4MZRipEyK8c6QxxneEO5fBQxLD/AkPJK/haX9Q==", "a16068b6-5b40-4139-ab3a-d8ff6b688aaa", new DateTime(2025, 10, 18, 21, 4, 1, 114, DateTimeKind.Local).AddTicks(8878) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "e8590493-0ef0-4087-8c90-2045bea3adab", "AQAAAAIAAYagAAAAEKNqz0cYBNEsCGOzFTSuc4W7jvh8x4FpEANRUYMrZxfSgvK/DpqpIWMIOLRczuN0Ow==", "36ba2fcc-1372-446c-bee2-a5bcb7f2449e", new DateTime(2025, 10, 18, 21, 4, 1, 165, DateTimeKind.Local).AddTicks(6092) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "40bbed82-0ecb-424f-9090-65a33eb36a76", "AQAAAAIAAYagAAAAELx8nZ8WIYPtFQHkOrOtNc0gDrkwP4n8yvPinBOw1MVSzqoOqHzKEGzAMVV59dH2eg==", "d9ab279d-4402-4bb9-91d3-40605ce2c22f", new DateTime(2025, 10, 18, 21, 4, 0, 348, DateTimeKind.Local).AddTicks(9054) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "0b3f34a2-d2c3-4aff-990e-c50075f78e7b", "AQAAAAIAAYagAAAAEO7t8O5HMTCq4f+3gqTIWOZ9v9kg7UfNXSnbaNGyBwoBZ1kBk/gQYAAPXGoJ3eUoVQ==", "7383977f-7369-437d-88a1-6dfe688c00fa", new DateTime(2025, 10, 18, 21, 4, 1, 216, DateTimeKind.Local).AddTicks(401) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "f22d6a63-9000-4da8-a34d-1cb26386aef5", "AQAAAAIAAYagAAAAENEcznbkV9WjnW3x85MFGTEgz6SIrhjhxmSuGnwlcF1widtdGCtVP4uX/RPtKz0X2g==", "3c2a1414-e4cb-487c-af1b-8629e6296f34", new DateTime(2025, 10, 18, 21, 4, 1, 266, DateTimeKind.Local).AddTicks(1551) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "976070c0-83ce-42d7-878c-516329b8d29c", "AQAAAAIAAYagAAAAEPnhVsGA2w79LsWVLju1aCkLn7SANc2t0Wz3jRmapPuS2vjhwAnxUTKCQVMUzZxviA==", "bd38349f-85e9-44ad-8cf3-fe7d328eb524", new DateTime(2025, 10, 18, 21, 4, 1, 315, DateTimeKind.Local).AddTicks(7787) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "23",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "13b6e432-7b79-4243-98b2-ddbce009db76", "AQAAAAIAAYagAAAAEFMtCb+RZSYjuGouVQl9cXS+1H1Q+QBo6JGdkMA5nESiTT3t2BFgv2w3LlmtCNX2xg==", "d37f3e85-e138-487d-be77-810ed0edbed0", new DateTime(2025, 10, 18, 21, 4, 1, 368, DateTimeKind.Local).AddTicks(5839) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "24",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "6e615979-5c14-49f2-bc0d-cec0083f7655", "AQAAAAIAAYagAAAAEBUdnpHT7XhalPeW0PcZgbqkVCY5QYkoLEiweW0t2sa2C296ac+yIq9aVSEvSsgG5w==", "db20d4a3-0627-4fb7-9cc2-c69f25919941", new DateTime(2025, 10, 18, 21, 4, 1, 417, DateTimeKind.Local).AddTicks(9204) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "25",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "b9cf38fc-c1a1-44b8-bfeb-b83e32120d41", "AQAAAAIAAYagAAAAEDRrD55ug/E6T9kcD5JF50/ywFu8Lz4KXVYDv11eL4oyGflNMru4qLV8KL+kHGD+VQ==", "4a43394e-4e46-4871-a079-5fae7a9105e3", new DateTime(2025, 10, 18, 21, 4, 1, 466, DateTimeKind.Local).AddTicks(9141) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "26",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "94447274-4855-4357-91cb-fd19b2390c39", "AQAAAAIAAYagAAAAEDt4FFvTmBPULsZkiqAXwvrGv2TYi9+wLEP05voiSsyuOuhQMM2Scr/aFrLqwb4KLA==", "0d8141b8-97c6-4b0c-aaf5-9ce181838823", new DateTime(2025, 10, 18, 21, 4, 1, 516, DateTimeKind.Local).AddTicks(1994) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "e37e1151-9126-402d-a8e2-7a28bd2d0771", "AQAAAAIAAYagAAAAEIzHH91rn2Kz/0GL+gwCn2qsM7/6ohGJtH5ZziZf077qVxLitkR2DY5h45/U9LmvAw==", "1b0f0504-f996-434d-ae6b-cc29e79f0975", new DateTime(2025, 10, 18, 21, 4, 1, 568, DateTimeKind.Local).AddTicks(1978) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "28",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "d830c9bd-c9a3-44af-879d-23f4f18d6f31", "AQAAAAIAAYagAAAAED5KugcmxgGjTl1c4/1OJvQM6n+KGNfARc49Afja34G3QpNb9k4/kn526ePMQI3JmA==", "01305c30-b1b0-4ba5-b909-ca41b836a875", new DateTime(2025, 10, 18, 21, 4, 1, 617, DateTimeKind.Local).AddTicks(5883) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "29",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "8a74366d-f6ef-468e-a751-c6f5a4b76161", "AQAAAAIAAYagAAAAEM6HUn146kEqtCUlCfkjn64zyYAqCAfbLWdY9IyeoMrfeuJBFH2D1ddXyqCaYLUuUQ==", "2b327c41-915c-4d7b-8dcf-477b0f73bc5c", new DateTime(2025, 10, 18, 21, 4, 1, 667, DateTimeKind.Local).AddTicks(7958) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "8ac1bfcd-2bf8-4e45-a807-d6faa9729bd9", "AQAAAAIAAYagAAAAEE2jJkqVpJ0weDzHZxVNVlaWHLzs5y38OQl/L3icE1bQpWzzLE6+QRXZmKS/alguSw==", "7c2f7abc-dc8e-444b-815b-83383fb01577", new DateTime(2025, 10, 18, 21, 4, 0, 395, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "30",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "a969ab49-6f0b-4b2b-876f-23d4d6332adf", "AQAAAAIAAYagAAAAEN6a+rc0qQUlZRnNmi6C1xM1HQdVOuqn6njJxtLXmj312ml7YNmmRltD95jTkLRToQ==", "a0a3134d-0f6d-4131-9ee5-60d0421f3697", new DateTime(2025, 10, 18, 21, 4, 1, 718, DateTimeKind.Local).AddTicks(2558) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "31",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "ef0447ce-fa35-466b-b907-7b467c5c8bd0", "AQAAAAIAAYagAAAAEE5wvXr9MK5jLs1paY8ZkN9SGRGJ5l7dGOrNKumHf7RfZu+JWoMLIIOCCFqcihHKeg==", "38e399f4-6ee9-4005-a9e0-874120475a99", new DateTime(2025, 10, 18, 21, 4, 1, 766, DateTimeKind.Local).AddTicks(4097) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "32",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "ed541630-9c76-47de-b1cd-2e1afd4ccc4b", "AQAAAAIAAYagAAAAECegAiik3720m/XCroASI2ZQeNkJ6kB2g7pPbn91BF/Dc0VyNlq/PKkLIvsuGlQWng==", "63094bbe-b912-4dd2-aebc-722f07426c12", new DateTime(2025, 10, 18, 21, 4, 1, 813, DateTimeKind.Local).AddTicks(4892) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "33",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "f3e73cb8-c774-4b2a-a200-da4d42ed0248", "AQAAAAIAAYagAAAAEOcFne9ENRayh0UQaYcFYR/fk2o+wG2p//6csVZkmNrfO8t0BPoDAGeBMusrkSTGfw==", "9b6f66dc-8fe4-4be4-86ae-ca256083c266", new DateTime(2025, 10, 18, 21, 4, 1, 859, DateTimeKind.Local).AddTicks(7282) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "34",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "c67b2b98-a685-461c-aa58-6106ad0635a1", "AQAAAAIAAYagAAAAEEzKacLjcKWmXybMYPaH+F90X6t2u56bxngUIBfHHIgo37QEKOsO9ZJl2xpXMRQxaw==", "8a24174c-c6ba-4d6b-8c68-4f43f8de1d91", new DateTime(2025, 10, 18, 21, 4, 1, 907, DateTimeKind.Local).AddTicks(1185) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "35",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "052665b8-49fa-470b-82e6-003cf8505d11", "AQAAAAIAAYagAAAAEExOr/BwR7rjSHX6+TRlVMb55kbCujCDXr04uoBf6AlonX8uW1enDdomvG1pbKcUiQ==", "698c0089-e101-4b7c-969e-cf20eb0003c8", new DateTime(2025, 10, 18, 21, 4, 1, 953, DateTimeKind.Local).AddTicks(1709) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "36",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "1c4d6366-af88-41c3-a9e6-dde88bc57e97", "AQAAAAIAAYagAAAAEKlWMKkp3ZZcAxKwfG0SvAs6Se/HZ0Z4plyJzcBKg62auqwzmTte/mWgZXnEcXN9Xg==", "292e818c-e9f2-45a8-879f-d48330b994f4", new DateTime(2025, 10, 18, 21, 4, 1, 999, DateTimeKind.Local).AddTicks(8786) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "37",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "9326a535-c322-4efd-bc20-19b2ab3ce858", "AQAAAAIAAYagAAAAEMhpgfwnIkTg4mHAmhdOjhoEz5sBCaoBKngdXy2meMz/6YsBNk/Hxf0l41+9uW7kIw==", "80b4f39e-f813-4afd-8c74-844f96e73be7", new DateTime(2025, 10, 18, 21, 4, 2, 47, DateTimeKind.Local).AddTicks(2351) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "38",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "bc0f46f1-cf5f-4612-a949-290b811133e6", "AQAAAAIAAYagAAAAEA7aZIaXbWNrBWmaGgyJh0xJqTGjbzLRf5E5aKs5GBXb7O0pHMslJgTeNmrhXmjzSQ==", "80065993-9232-4f19-aee8-b9d227552dc1", new DateTime(2025, 10, 18, 21, 4, 2, 93, DateTimeKind.Local).AddTicks(3078) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "39",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "d459ab9a-719a-4778-9ead-e6ad3165605f", "AQAAAAIAAYagAAAAEOmkzs3cLJb5WFcDPAXbpkNHckzXozhMwsPZPqOfgORgmQi8h3jM/MgHjW/KcidNMw==", "0612583d-b84f-4178-aed9-38f50446cbf7", new DateTime(2025, 10, 18, 21, 4, 2, 161, DateTimeKind.Local).AddTicks(8971) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "b5659580-ae3c-4cec-83a4-1eb39b7cd954", "AQAAAAIAAYagAAAAEHWaDPJhjwLz7PeEuj9iTPYjycl/SkIg00rT35m1mpQ64wsyqAPktGD9jdn+fiv4IA==", "0442a1da-037c-4bab-b7dc-d26e95d34da3", new DateTime(2025, 10, 18, 21, 4, 0, 451, DateTimeKind.Local).AddTicks(2422) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "40",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "ff1a6f9d-e2d2-4fcd-ad9d-c98abbb5eaa4", "AQAAAAIAAYagAAAAEBXMzHq4w1Le+uvQAHuMHxMLYSAH6Gurj2rgg0JfVjKdPYt0zUijxhszcqe+C33qNA==", "fa5c1fd1-6ae7-49b5-85dc-ec2d612de4cb", new DateTime(2025, 10, 18, 21, 4, 2, 212, DateTimeKind.Local).AddTicks(2609) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "41",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "9ecf7444-092b-4d22-86d0-34fb746120ce", "AQAAAAIAAYagAAAAEPXvwSwp8KdBHCxPEyvokHUTPRA6BQm5m1aySAzy4HP3ihV/wOaGwXL5aeTptr/r6w==", "604b6b65-e409-4d7c-b286-64d7c082b1ed", new DateTime(2025, 10, 18, 21, 4, 2, 257, DateTimeKind.Local).AddTicks(9837) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "42",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "9d869fc6-db65-4666-b0be-b2cdbdd8e992", "AQAAAAIAAYagAAAAEAAGnovlQNA6vMyS4kdXvNuMYuTTG1Ri2LpkiqoM+dA1xVq7NqnOJ8/uVTudNk/OgQ==", "f5a203c1-d582-48d4-b53b-1b50e5b09325", new DateTime(2025, 10, 18, 21, 4, 2, 308, DateTimeKind.Local).AddTicks(6000) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "43",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "16baa8e1-7f71-4390-aeb3-17d7f9f987c3", "AQAAAAIAAYagAAAAEEbKlC6ARGUroehhDWQdA/0DXNpHBqzzK+C7+sExzAvBvKkFy6fRitny9h+qY7Tydg==", "3bcd1775-9857-4b08-b4e5-21c8aff0b90e", new DateTime(2025, 10, 18, 21, 4, 2, 361, DateTimeKind.Local).AddTicks(5389) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "44",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "12cb378a-9d4e-434f-94c6-72e49afceaea", "AQAAAAIAAYagAAAAEDailgBWrPnYixReG06bqDX+HU+bFZj4yJ23SsJIucjAJ/LddTFJla4v+xSeryptGw==", "bd52ea73-959f-4b89-9872-7498181fc1b5", new DateTime(2025, 10, 18, 21, 4, 2, 410, DateTimeKind.Local).AddTicks(3790) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "45",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "891ba6e4-95ea-4fe1-b732-fc0d78651afa", "AQAAAAIAAYagAAAAEK99MuLW/hTpJG3nneJ55AO7IqFq18CN06oKgL9Ashzyex03YOSdcdDOVTG+Xvm87g==", "f39ad678-d1f6-482f-a1d8-dd96528829ad", new DateTime(2025, 10, 18, 21, 4, 2, 458, DateTimeKind.Local).AddTicks(206) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "46",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "8246808b-b23b-45a5-9f64-05ae710263d5", "AQAAAAIAAYagAAAAEGX0BDxT+LBnrfP8Zllz14Q3nfMFub64/V3+rQNj3leyyiX8DYnpF5Oo0yT7yVgqeg==", "786003fd-8864-4b01-b113-7c482f8da8a6", new DateTime(2025, 10, 18, 21, 4, 2, 506, DateTimeKind.Local).AddTicks(1037) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "47",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "dfd6b17d-d2db-4624-8944-bcd3082a4e30", "AQAAAAIAAYagAAAAEJiInUwcJL5LRHhFnW/MN978dtlvEuk+ql5hkQFaWpFFERCWnbGK1v9u3a3gubvI6g==", "a8cdde1c-53d6-4e93-9736-fed4a817ba8c", new DateTime(2025, 10, 18, 21, 4, 2, 566, DateTimeKind.Local).AddTicks(2103) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "48",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "3bba5369-67e1-4b3e-a227-fc71ff4fde7a", "AQAAAAIAAYagAAAAENqcThdRdt5f+lCR7oYMQU+R/jnQqlNcOB8w0xumT80pGC4U+7p1yD/ibV7xWu8VjA==", "9672e31e-c846-4c1f-822a-95e860cdadfc", new DateTime(2025, 10, 18, 21, 4, 2, 613, DateTimeKind.Local).AddTicks(2913) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "49",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "28de507c-9372-4a63-932c-de62e8c2ba26", "AQAAAAIAAYagAAAAEGVg08a7MmY1mxVwHBmmu/zSh33QAd7GfYEO+j3FoILfslvDbjLJD46/Zc6bO+ICsA==", "e6095553-5e38-48c3-ae64-0ec94d165b8f", new DateTime(2025, 10, 18, 21, 4, 2, 661, DateTimeKind.Local).AddTicks(8104) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "59aba209-5dbe-437d-a021-07a08d356874", "AQAAAAIAAYagAAAAECSy0JvV81rW+f2d6fiAe8rE5LEfdZM8ZBruKqo4qPkXIoGSdemOvNBDPEZGpKX+CA==", "a36b4b7d-4b64-49f3-a502-0d3079bd1ac2", new DateTime(2025, 10, 18, 21, 4, 0, 505, DateTimeKind.Local).AddTicks(4774) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "50",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "e9014ca3-3956-4f6c-997b-3b205e83ae03", "AQAAAAIAAYagAAAAEAxOFQP0IiaF3nUlHqo2fUanrGh+GPrw1/3ZBcrBd71KakDyM5Zh1l5nKWYoyJpXAQ==", "9c69b318-e1cd-4645-a618-ebcba081dadb", new DateTime(2025, 10, 18, 21, 4, 2, 719, DateTimeKind.Local).AddTicks(4940) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "51",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "a3cba5ea-e56b-4542-aa61-bd4147342dff", "AQAAAAIAAYagAAAAEDH1CSfB1aHICGnYo15e2D9vC2KrlrKOuaAIJ75pPuElFa9PnN3SFTSyAxrmsFaArw==", "51cfd1e7-d879-400e-831b-26404cf22663", new DateTime(2025, 10, 18, 21, 4, 2, 771, DateTimeKind.Local).AddTicks(1775) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "52",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "d6664ea6-389c-4210-96fd-780de9678d88", "AQAAAAIAAYagAAAAEGZXq3S+JmS7XTrQH/+0+BpV8It2njDgSH6dTWKKYT47aYnF+bXb1NdsX/goeXjMGg==", "599cbc88-1ef6-43d8-9e29-81dc28624f65", new DateTime(2025, 10, 18, 21, 4, 2, 822, DateTimeKind.Local).AddTicks(7556) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "53",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "53436a2f-2820-4bb1-bad5-589d5430e17a", "AQAAAAIAAYagAAAAELKwShZvESJy2HjTloYi8k1slmXSdX6UsJ/DuBTj0QuolgSzZNgN4Lvb4L8+hjdgkg==", "ff4de99e-07c9-4b8c-bd9b-4be151cde5b0", new DateTime(2025, 10, 18, 21, 4, 2, 872, DateTimeKind.Local).AddTicks(8540) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "54",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "bc7afc98-b244-49e6-9509-6d77cc2d855a", "AQAAAAIAAYagAAAAEGG3BJXpkZTv0xCQx0QIGzr6tQod/ZHjq4LpytWISR3S+dcT5a4EIGgsRYbuu8koAA==", "a782a174-14d3-4bcd-b987-0376ed4e4463", new DateTime(2025, 10, 18, 21, 4, 2, 920, DateTimeKind.Local).AddTicks(1176) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "55",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "3f4f4794-b947-400b-930f-1861a52412d5", "AQAAAAIAAYagAAAAEGQYrn4YGfNMLq+JpogaQvh8qAnoZgXsSFA2q5e2HlCA1z0rFBIvmtxPkCOWIwRx4Q==", "4cb6a9d8-ba3b-4d15-b05a-065eec6083e2", new DateTime(2025, 10, 18, 21, 4, 2, 969, DateTimeKind.Local).AddTicks(2356) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "6ff58f27-ba6b-455e-a69d-8ef08140bc04", "AQAAAAIAAYagAAAAEBKXZtTFitrld8J+BEu0/QhiLoF6JtKrtThArk/ZSFs0ed7qxCUDOG4UuXLnh4hxxA==", "79a1562f-5234-45ac-b3f4-d2acbd02fb6c", new DateTime(2025, 10, 18, 21, 4, 0, 553, DateTimeKind.Local).AddTicks(6954) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "f7111c66-7e9f-4634-824e-d45b0e44e512", "AQAAAAIAAYagAAAAEMtJIPX6meoGF/mu/Z8iZ/M1kXEDQzm0Yy8zALvBD4uq9IwC2atB0DgObeZ14NYS6g==", "14b54171-3c41-44d5-a0fa-4ff9a2e5c280", new DateTime(2025, 10, 18, 21, 4, 0, 600, DateTimeKind.Local).AddTicks(2331) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "9bb940a7-ebf0-4c02-8742-8fef1ba838f3", "AQAAAAIAAYagAAAAED9cjoL3S8eJui5Lvq9Ubv9HRcjmO4VU+1cb25IIVJ8P04akagTLQGVWSJEekiaKdA==", "fe9de5e9-8d11-484e-8d85-757e83fb1206", new DateTime(2025, 10, 18, 21, 4, 0, 647, DateTimeKind.Local).AddTicks(57) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "950f7791-3248-4733-bbbd-0fd719d5134b", "AQAAAAIAAYagAAAAEJEtA59Q+OaEGIJyqPbyAISajy9JiKaVBbLoVt9Nnaks6xtW/Rs7S5Z8SqeVUiMOXg==", "3679a6a2-748f-4631-b231-c91de097671b", new DateTime(2025, 10, 18, 21, 4, 0, 694, DateTimeKind.Local).AddTicks(1218) });

            migrationBuilder.UpdateData(
                table: "WishLists",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 20L, "5" },
                column: "CreatedAt",
                value: new DateTime(2025, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "WishLists",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 24L, "5" },
                column: "CreatedAt",
                value: new DateTime(2025, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "WishLists",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 43L, "5" },
                column: "CreatedAt",
                value: new DateTime(2025, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "WishLists",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 27L, "6" },
                column: "CreatedAt",
                value: new DateTime(2025, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "WishLists",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 28L, "7" },
                column: "CreatedAt",
                value: new DateTime(2025, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "WishLists",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 33L, "7" },
                column: "CreatedAt",
                value: new DateTime(2025, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "WishLists",
                columns: new[] { "CourseId", "UserId", "CreatedAt" },
                values: new object[,]
                {
                    { 4L, "5", new DateTime(2025, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 23L, "5", new DateTime(2025, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 44L, "5", new DateTime(2025, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 49L, "5", new DateTime(2025, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1L, "6", new DateTime(2025, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19L, "6", new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 30L, "6", new DateTime(2025, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 34L, "6", new DateTime(2025, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 42L, "6", new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 52L, "6", new DateTime(2025, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7L, "7", new DateTime(2025, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8L, "7", new DateTime(2025, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12L, "7", new DateTime(2025, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17L, "7", new DateTime(2025, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 44L, "7", new DateTime(2025, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "CourseCategories",
                columns: new[] { "CategoryId", "CourseId" },
                values: new object[,]
                {
                    { 40L, 1L },
                    { 36L, 2L },
                    { 45L, 2L },
                    { 18L, 3L },
                    { 38L, 3L },
                    { 44L, 3L },
                    { 12L, 4L },
                    { 36L, 4L },
                    { 20L, 5L },
                    { 18L, 6L },
                    { 30L, 7L },
                    { 38L, 8L },
                    { 14L, 9L },
                    { 12L, 10L },
                    { 26L, 11L },
                    { 54L, 11L },
                    { 54L, 12L },
                    { 21L, 13L },
                    { 29L, 13L },
                    { 33L, 14L },
                    { 47L, 14L },
                    { 53L, 14L },
                    { 55L, 15L },
                    { 18L, 16L },
                    { 52L, 19L },
                    { 26L, 20L },
                    { 52L, 20L },
                    { 48L, 21L },
                    { 33L, 22L },
                    { 38L, 22L },
                    { 28L, 23L },
                    { 47L, 23L },
                    { 21L, 24L },
                    { 55L, 25L },
                    { 46L, 26L },
                    { 26L, 27L },
                    { 49L, 27L },
                    { 55L, 27L },
                    { 14L, 29L },
                    { 35L, 29L },
                    { 52L, 29L },
                    { 51L, 30L },
                    { 15L, 33L },
                    { 27L, 33L },
                    { 29L, 33L },
                    { 46L, 34L },
                    { 11L, 35L },
                    { 33L, 35L },
                    { 45L, 35L },
                    { 52L, 36L },
                    { 17L, 37L },
                    { 17L, 38L },
                    { 37L, 39L },
                    { 33L, 40L },
                    { 16L, 41L },
                    { 30L, 42L },
                    { 40L, 42L },
                    { 15L, 43L },
                    { 18L, 43L },
                    { 55L, 43L },
                    { 47L, 44L },
                    { 40L, 45L },
                    { 48L, 45L },
                    { 51L, 45L },
                    { 26L, 46L },
                    { 44L, 46L },
                    { 26L, 47L },
                    { 39L, 47L },
                    { 12L, 48L },
                    { 29L, 49L },
                    { 37L, 50L },
                    { 45L, 50L },
                    { 48L, 50L },
                    { 47L, 51L },
                    { 15L, 53L },
                    { 36L, 53L },
                    { 54L, 54L },
                    { 55L, 55L }
                });
        }
    }
}
