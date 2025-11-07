using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OnlineLearningPlatform.Data.Migrations
{
    /// <inheritdoc />
    public partial class FixSeedLan3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 2L,
                column: "Status",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 3L,
                column: "Status",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 4L,
                column: "DateCreated",
                value: new DateTime(2025, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 5L,
                columns: new[] { "DateCreated", "Status" },
                values: new object[] { new DateTime(2025, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 6L,
                columns: new[] { "DateCreated", "Status" },
                values: new object[] { new DateTime(2025, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 7L,
                column: "DateCreated",
                value: new DateTime(2025, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 8L,
                columns: new[] { "DateCreated", "Status" },
                values: new object[] { new DateTime(2025, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 9L,
                columns: new[] { "DateCreated", "Status" },
                values: new object[] { new DateTime(2025, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 10L,
                column: "DateCreated",
                value: new DateTime(2025, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 11L,
                columns: new[] { "DateCreated", "Status" },
                values: new object[] { new DateTime(2025, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 12L,
                columns: new[] { "DateCreated", "Status" },
                values: new object[] { new DateTime(2025, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 13L,
                column: "DateCreated",
                value: new DateTime(2025, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 14L,
                columns: new[] { "DateCreated", "Status" },
                values: new object[] { new DateTime(2025, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 15L,
                columns: new[] { "DateCreated", "Status" },
                values: new object[] { new DateTime(2025, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 16L,
                column: "DateCreated",
                value: new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 17L,
                columns: new[] { "DateCreated", "Status" },
                values: new object[] { new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 18L,
                columns: new[] { "DateCreated", "Status" },
                values: new object[] { new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 19L,
                column: "DateCreated",
                value: new DateTime(2025, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 20L,
                columns: new[] { "DateCreated", "Status" },
                values: new object[] { new DateTime(2025, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 21L,
                columns: new[] { "DateCreated", "Status" },
                values: new object[] { new DateTime(2025, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 22L,
                column: "DateCreated",
                value: new DateTime(2025, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 23L,
                columns: new[] { "DateCreated", "Status" },
                values: new object[] { new DateTime(2025, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 24L,
                columns: new[] { "DateCreated", "Status" },
                values: new object[] { new DateTime(2025, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 25L,
                column: "DateCreated",
                value: new DateTime(2025, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 26L,
                columns: new[] { "DateCreated", "Status" },
                values: new object[] { new DateTime(2025, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 27L,
                columns: new[] { "DateCreated", "Status" },
                values: new object[] { new DateTime(2025, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 28L,
                column: "DateCreated",
                value: new DateTime(2025, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 29L,
                columns: new[] { "DateCreated", "Status" },
                values: new object[] { new DateTime(2025, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 30L,
                columns: new[] { "DateCreated", "Status" },
                values: new object[] { new DateTime(2025, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 31L,
                column: "DateCreated",
                value: new DateTime(2025, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 32L,
                columns: new[] { "DateCreated", "Status" },
                values: new object[] { new DateTime(2025, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 33L,
                columns: new[] { "DateCreated", "Status" },
                values: new object[] { new DateTime(2025, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 34L,
                column: "DateCreated",
                value: new DateTime(2025, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 35L,
                columns: new[] { "DateCreated", "Status" },
                values: new object[] { new DateTime(2025, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 36L,
                columns: new[] { "DateCreated", "Status" },
                values: new object[] { new DateTime(2025, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.InsertData(
                table: "Modules",
                columns: new[] { "ModuleId", "CourseId", "DateCreated", "ModifiedDate", "ModuleName", "ModuleNumber", "Status" },
                values: new object[,]
                {
                    { 37L, 13L, new DateTime(2025, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 1 of Course 13", 1, 0 },
                    { 38L, 13L, new DateTime(2025, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 2 of Course 13", 2, 0 },
                    { 39L, 13L, new DateTime(2025, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 3 of Course 13", 3, 0 },
                    { 40L, 14L, new DateTime(2025, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 1 of Course 14", 1, 0 },
                    { 41L, 14L, new DateTime(2025, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 2 of Course 14", 2, 0 },
                    { 42L, 14L, new DateTime(2025, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 3 of Course 14", 3, 0 },
                    { 43L, 15L, new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 1 of Course 15", 1, 0 },
                    { 44L, 15L, new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 2 of Course 15", 2, 0 },
                    { 45L, 15L, new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 3 of Course 15", 3, 0 },
                    { 46L, 16L, new DateTime(2025, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 1 of Course 16", 1, 0 },
                    { 47L, 16L, new DateTime(2025, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 2 of Course 16", 2, 0 },
                    { 48L, 16L, new DateTime(2025, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 3 of Course 16", 3, 0 },
                    { 49L, 17L, new DateTime(2025, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 1 of Course 17", 1, 0 },
                    { 50L, 17L, new DateTime(2025, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 2 of Course 17", 2, 0 },
                    { 51L, 17L, new DateTime(2025, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 3 of Course 17", 3, 0 },
                    { 52L, 18L, new DateTime(2025, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 1 of Course 18", 1, 0 },
                    { 53L, 18L, new DateTime(2025, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 2 of Course 18", 2, 0 },
                    { 54L, 18L, new DateTime(2025, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 3 of Course 18", 3, 0 },
                    { 55L, 19L, new DateTime(2025, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 1 of Course 19", 1, 0 },
                    { 56L, 19L, new DateTime(2025, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 2 of Course 19", 2, 0 },
                    { 57L, 19L, new DateTime(2025, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 3 of Course 19", 3, 0 },
                    { 58L, 20L, new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 1 of Course 20", 1, 0 },
                    { 59L, 20L, new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 2 of Course 20", 2, 0 },
                    { 60L, 20L, new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 3 of Course 20", 3, 0 },
                    { 61L, 21L, new DateTime(2025, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 1 of Course 21", 1, 0 },
                    { 62L, 21L, new DateTime(2025, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 2 of Course 21", 2, 0 },
                    { 63L, 21L, new DateTime(2025, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 3 of Course 21", 3, 0 },
                    { 64L, 22L, new DateTime(2025, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 1 of Course 22", 1, 0 },
                    { 65L, 22L, new DateTime(2025, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 2 of Course 22", 2, 0 },
                    { 66L, 22L, new DateTime(2025, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 3 of Course 22", 3, 0 },
                    { 67L, 23L, new DateTime(2025, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 1 of Course 23", 1, 0 },
                    { 68L, 23L, new DateTime(2025, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 2 of Course 23", 2, 0 },
                    { 69L, 23L, new DateTime(2025, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 3 of Course 23", 3, 0 },
                    { 70L, 24L, new DateTime(2025, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 1 of Course 24", 1, 0 },
                    { 71L, 24L, new DateTime(2025, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 2 of Course 24", 2, 0 },
                    { 72L, 24L, new DateTime(2025, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 3 of Course 24", 3, 0 },
                    { 73L, 25L, new DateTime(2025, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 1 of Course 25", 1, 0 },
                    { 74L, 25L, new DateTime(2025, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 2 of Course 25", 2, 0 },
                    { 75L, 25L, new DateTime(2025, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 3 of Course 25", 3, 0 },
                    { 76L, 26L, new DateTime(2025, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 1 of Course 26", 1, 0 },
                    { 77L, 26L, new DateTime(2025, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 2 of Course 26", 2, 0 },
                    { 78L, 26L, new DateTime(2025, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 3 of Course 26", 3, 0 },
                    { 79L, 27L, new DateTime(2025, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 1 of Course 27", 1, 0 },
                    { 80L, 27L, new DateTime(2025, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 2 of Course 27", 2, 0 },
                    { 81L, 27L, new DateTime(2025, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 3 of Course 27", 3, 0 },
                    { 82L, 28L, new DateTime(2025, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 1 of Course 28", 1, 0 },
                    { 83L, 28L, new DateTime(2025, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 2 of Course 28", 2, 0 },
                    { 84L, 28L, new DateTime(2025, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 3 of Course 28", 3, 0 },
                    { 85L, 29L, new DateTime(2025, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 1 of Course 29", 1, 0 },
                    { 86L, 29L, new DateTime(2025, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 2 of Course 29", 2, 0 },
                    { 87L, 29L, new DateTime(2025, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 3 of Course 29", 3, 0 },
                    { 88L, 30L, new DateTime(2025, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 1 of Course 30", 1, 0 },
                    { 89L, 30L, new DateTime(2025, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 2 of Course 30", 2, 0 },
                    { 90L, 30L, new DateTime(2025, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 3 of Course 30", 3, 0 },
                    { 91L, 31L, new DateTime(2025, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 1 of Course 31", 1, 0 },
                    { 92L, 31L, new DateTime(2025, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 2 of Course 31", 2, 0 },
                    { 93L, 31L, new DateTime(2025, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 3 of Course 31", 3, 0 },
                    { 94L, 32L, new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 1 of Course 32", 1, 0 },
                    { 95L, 32L, new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 2 of Course 32", 2, 0 },
                    { 96L, 32L, new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 3 of Course 32", 3, 0 },
                    { 97L, 33L, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 1 of Course 33", 1, 0 },
                    { 98L, 33L, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 2 of Course 33", 2, 0 },
                    { 99L, 33L, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 3 of Course 33", 3, 0 },
                    { 100L, 34L, new DateTime(2025, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 1 of Course 34", 1, 0 },
                    { 101L, 34L, new DateTime(2025, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 2 of Course 34", 2, 0 },
                    { 102L, 34L, new DateTime(2025, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 3 of Course 34", 3, 0 },
                    { 103L, 35L, new DateTime(2025, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 1 of Course 35", 1, 0 },
                    { 104L, 35L, new DateTime(2025, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 2 of Course 35", 2, 0 },
                    { 105L, 35L, new DateTime(2025, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 3 of Course 35", 3, 0 },
                    { 106L, 36L, new DateTime(2025, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 1 of Course 36", 1, 0 },
                    { 107L, 36L, new DateTime(2025, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 2 of Course 36", 2, 0 },
                    { 108L, 36L, new DateTime(2025, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 3 of Course 36", 3, 0 },
                    { 109L, 37L, new DateTime(2025, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 1 of Course 37", 1, 0 },
                    { 110L, 37L, new DateTime(2025, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 2 of Course 37", 2, 0 },
                    { 111L, 37L, new DateTime(2025, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 3 of Course 37", 3, 0 },
                    { 112L, 38L, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 1 of Course 38", 1, 0 },
                    { 113L, 38L, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 2 of Course 38", 2, 0 },
                    { 114L, 38L, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 3 of Course 38", 3, 0 },
                    { 115L, 39L, new DateTime(2025, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 1 of Course 39", 1, 0 },
                    { 116L, 39L, new DateTime(2025, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 2 of Course 39", 2, 0 },
                    { 117L, 39L, new DateTime(2025, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 3 of Course 39", 3, 0 },
                    { 118L, 40L, new DateTime(2025, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 1 of Course 40", 1, 0 },
                    { 119L, 40L, new DateTime(2025, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 2 of Course 40", 2, 0 },
                    { 120L, 40L, new DateTime(2025, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 3 of Course 40", 3, 0 },
                    { 121L, 41L, new DateTime(2025, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 1 of Course 41", 1, 0 },
                    { 122L, 41L, new DateTime(2025, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 2 of Course 41", 2, 0 },
                    { 123L, 41L, new DateTime(2025, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 3 of Course 41", 3, 0 },
                    { 124L, 42L, new DateTime(2025, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 1 of Course 42", 1, 0 },
                    { 125L, 42L, new DateTime(2025, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 2 of Course 42", 2, 0 },
                    { 126L, 42L, new DateTime(2025, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 3 of Course 42", 3, 0 },
                    { 127L, 43L, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 1 of Course 43", 1, 0 },
                    { 128L, 43L, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 2 of Course 43", 2, 0 },
                    { 129L, 43L, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 3 of Course 43", 3, 0 },
                    { 130L, 44L, new DateTime(2025, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 1 of Course 44", 1, 0 },
                    { 131L, 44L, new DateTime(2025, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 2 of Course 44", 2, 0 },
                    { 132L, 44L, new DateTime(2025, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 3 of Course 44", 3, 0 },
                    { 133L, 45L, new DateTime(2025, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 1 of Course 45", 1, 0 },
                    { 134L, 45L, new DateTime(2025, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 2 of Course 45", 2, 0 },
                    { 135L, 45L, new DateTime(2025, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 3 of Course 45", 3, 0 },
                    { 136L, 46L, new DateTime(2025, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 1 of Course 46", 1, 0 },
                    { 137L, 46L, new DateTime(2025, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 2 of Course 46", 2, 0 },
                    { 138L, 46L, new DateTime(2025, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 3 of Course 46", 3, 0 },
                    { 139L, 47L, new DateTime(2025, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 1 of Course 47", 1, 0 },
                    { 140L, 47L, new DateTime(2025, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 2 of Course 47", 2, 0 },
                    { 141L, 47L, new DateTime(2025, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 3 of Course 47", 3, 0 },
                    { 142L, 48L, new DateTime(2025, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 1 of Course 48", 1, 0 },
                    { 143L, 48L, new DateTime(2025, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 2 of Course 48", 2, 0 },
                    { 144L, 48L, new DateTime(2025, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 3 of Course 48", 3, 0 },
                    { 145L, 49L, new DateTime(2025, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 1 of Course 49", 1, 0 },
                    { 146L, 49L, new DateTime(2025, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 2 of Course 49", 2, 0 },
                    { 147L, 49L, new DateTime(2025, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 3 of Course 49", 3, 0 },
                    { 148L, 50L, new DateTime(2025, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 1 of Course 50", 1, 0 },
                    { 149L, 50L, new DateTime(2025, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 2 of Course 50", 2, 0 },
                    { 150L, 50L, new DateTime(2025, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Module 3 of Course 50", 3, 0 }
                });

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 1L,
                column: "UpdatedAt",
                value: new DateTime(2025, 11, 7, 17, 10, 3, 611, DateTimeKind.Local).AddTicks(5602));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 2L,
                column: "UpdatedAt",
                value: new DateTime(2025, 11, 7, 17, 10, 3, 611, DateTimeKind.Local).AddTicks(5613));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 3L,
                column: "UpdatedAt",
                value: new DateTime(2025, 11, 7, 17, 10, 3, 611, DateTimeKind.Local).AddTicks(5616));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 4L,
                column: "UpdatedAt",
                value: new DateTime(2025, 11, 7, 17, 10, 3, 611, DateTimeKind.Local).AddTicks(5617));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 5L,
                column: "UpdatedAt",
                value: new DateTime(2025, 11, 7, 17, 10, 3, 611, DateTimeKind.Local).AddTicks(5618));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 6L,
                column: "UpdatedAt",
                value: new DateTime(2025, 11, 7, 17, 10, 3, 611, DateTimeKind.Local).AddTicks(5620));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 7L,
                column: "UpdatedAt",
                value: new DateTime(2025, 11, 7, 17, 10, 3, 611, DateTimeKind.Local).AddTicks(5621));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 8L,
                column: "UpdatedAt",
                value: new DateTime(2025, 11, 7, 17, 10, 3, 611, DateTimeKind.Local).AddTicks(5622));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 9L,
                column: "UpdatedAt",
                value: new DateTime(2025, 11, 7, 17, 10, 3, 611, DateTimeKind.Local).AddTicks(5623));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 10L,
                column: "UpdatedAt",
                value: new DateTime(2025, 11, 7, 17, 10, 3, 611, DateTimeKind.Local).AddTicks(5625));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 11L,
                column: "UpdatedAt",
                value: new DateTime(2025, 11, 7, 17, 10, 3, 611, DateTimeKind.Local).AddTicks(5626));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 12L,
                column: "UpdatedAt",
                value: new DateTime(2025, 11, 7, 17, 10, 3, 611, DateTimeKind.Local).AddTicks(5627));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 13L,
                column: "UpdatedAt",
                value: new DateTime(2025, 11, 7, 17, 10, 3, 611, DateTimeKind.Local).AddTicks(5627));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 14L,
                column: "UpdatedAt",
                value: new DateTime(2025, 11, 7, 17, 10, 3, 611, DateTimeKind.Local).AddTicks(5628));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 15L,
                column: "UpdatedAt",
                value: new DateTime(2025, 11, 7, 17, 10, 3, 611, DateTimeKind.Local).AddTicks(5629));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 16L,
                column: "UpdatedAt",
                value: new DateTime(2025, 11, 7, 17, 10, 3, 611, DateTimeKind.Local).AddTicks(5630));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 17L,
                column: "UpdatedAt",
                value: new DateTime(2025, 11, 7, 17, 10, 3, 611, DateTimeKind.Local).AddTicks(5631));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 18L,
                column: "UpdatedAt",
                value: new DateTime(2025, 11, 7, 17, 10, 3, 611, DateTimeKind.Local).AddTicks(5633));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 19L,
                column: "UpdatedAt",
                value: new DateTime(2025, 11, 7, 17, 10, 3, 611, DateTimeKind.Local).AddTicks(5634));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 20L,
                column: "UpdatedAt",
                value: new DateTime(2025, 11, 7, 17, 10, 3, 611, DateTimeKind.Local).AddTicks(5635));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 21L,
                column: "UpdatedAt",
                value: new DateTime(2025, 11, 7, 17, 10, 3, 611, DateTimeKind.Local).AddTicks(5662));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 22L,
                column: "UpdatedAt",
                value: new DateTime(2025, 11, 7, 17, 10, 3, 611, DateTimeKind.Local).AddTicks(5664));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 23L,
                column: "UpdatedAt",
                value: new DateTime(2025, 11, 7, 17, 10, 3, 611, DateTimeKind.Local).AddTicks(5665));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 24L,
                column: "UpdatedAt",
                value: new DateTime(2025, 11, 7, 17, 10, 3, 611, DateTimeKind.Local).AddTicks(5666));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "e17afad7-6a8a-4551-b331-912fad1df2fe", "AQAAAAIAAYagAAAAEL56n6RJv3siZv1w2ZNmf56IIWbmUG6YqwIlypZrg0zmyaeeGNTIk5Zte7qST2pYFg==", "80f295e4-8376-4657-9fb7-750a0299df1c", new DateTime(2025, 11, 7, 17, 10, 3, 611, DateTimeKind.Local).AddTicks(9774) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "96753b3c-2b1d-4544-ba03-14e960dcdc90", "AQAAAAIAAYagAAAAEP9yVnnEJWG0iUBwkkW3iB3GSlOa+NuTX5J8enOlA3WF5CSkSMSOgAokIjIagXPfuA==", "d9767441-5c5d-4a8c-b8f7-1a6fdc24222a", new DateTime(2025, 11, 7, 17, 10, 3, 986, DateTimeKind.Local).AddTicks(4150) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "1dec32c5-39c5-4f21-9ea1-d94e333e5486", "AQAAAAIAAYagAAAAEENLMdh+y1yK1Bc4K8yhey0Cz9AMNFjas8a8+JGX7W8MpqJVMzMWZ34beQKjp9nKIA==", "a5148e3d-078a-4797-8391-c6aee16ff360", new DateTime(2025, 11, 7, 17, 10, 4, 25, DateTimeKind.Local).AddTicks(4801) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "d50cd1e0-f05e-4f8a-90ef-a63014548d1e", "AQAAAAIAAYagAAAAEM8JUFTTb2xpQ53c48t0zaQMnaJF8bPzJhtz2BcOXukuZw1paMkS/k/unKeD1xLYxg==", "ce24da09-348f-4ce7-bdba-8fb4b2ffe730", new DateTime(2025, 11, 7, 17, 10, 4, 69, DateTimeKind.Local).AddTicks(5561) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "55acf748-4084-4dc3-8790-87b166d7b001", "AQAAAAIAAYagAAAAEMBV5xa6WGErjI5MY68bfT/kTxtqUX2eGvyVJ4VtwqI2fR1IP3UTn1/IvcNuqnXCdA==", "0f320f14-b87a-48dc-a049-117e4cdc85e2", new DateTime(2025, 11, 7, 17, 10, 4, 110, DateTimeKind.Local).AddTicks(5595) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "37ba7fb0-6137-410d-9513-eba626758f69", "AQAAAAIAAYagAAAAEL2uciFkqWNL3ienX16c4IJwM8UC4JcySGctaEasUL/e5hZsh1Jh7DaeKJx6peimfQ==", "1d3c853c-b853-4ccf-ba8a-b467e2e2ff0e", new DateTime(2025, 11, 7, 17, 10, 4, 149, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "6f4a9b51-3dbd-47f6-887f-72bc2951ab2c", "AQAAAAIAAYagAAAAEAjfwweyWI4qCqw43iRFgtjekk6g2jLfJhwcyz++dh/xIKiM8q2sbIpXSWGoJKW4UQ==", "0b55e674-e0b4-48bc-b573-0a9339aa7d7d", new DateTime(2025, 11, 7, 17, 10, 4, 190, DateTimeKind.Local).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "cc4a5c27-0d03-472f-a2a0-03223e9e02bc", "AQAAAAIAAYagAAAAEEKATlhbmPFDtCO1GQEQlzLql4BNDiA5hgCsaJbJNjwWm9l0Fuuwx0Cs6EIDoFSzOg==", "c8ae84fa-fe21-4bc0-9f21-f7d4bb265cec", new DateTime(2025, 11, 7, 17, 10, 4, 231, DateTimeKind.Local).AddTicks(839) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "076e15d5-f8cb-47c3-9eac-1149af2af985", "AQAAAAIAAYagAAAAEDXUgOCDtc8DDdWFEpRbDtSa1Hi2ZSjXkH1YA2eC6302yepCDpe68jIhJYKtZB6HmQ==", "be062aa4-cef9-4bcf-a16b-5974644f2bba", new DateTime(2025, 11, 7, 17, 10, 4, 269, DateTimeKind.Local).AddTicks(5780) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "42af72bf-78ee-48ac-a36d-1228e55f3a28", "AQAAAAIAAYagAAAAEPhw4YF33Llw2edRpPS+KtTPBs2ND6uB0KrJdE//9Gzj7bCme92sgkZOUVNkg033Tw==", "0510966e-0eca-4cfb-8c85-d40473419010", new DateTime(2025, 11, 7, 17, 10, 4, 309, DateTimeKind.Local).AddTicks(9995) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "54365f36-d47e-4f59-8224-3b2f1cc917b1", "AQAAAAIAAYagAAAAEG8QcYtg18/XqHZhV585asjFy7c97v/dn54kRvav0+j/RTblL6NiK5lL+FOtLqWl9A==", "71263947-44a6-4eba-96c0-5106571f70f7", new DateTime(2025, 11, 7, 17, 10, 4, 349, DateTimeKind.Local).AddTicks(5351) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "7467a1ad-58a6-48cc-8aee-9ec8385e4e0e", "AQAAAAIAAYagAAAAEB3BxHXAdcllErBe59EYGW8y9RN2lvZ0k+yvlwzHC+3wXrlQD3uaNoONHFeODq8Z3Q==", "f77e8b8a-946e-4b98-b7f5-7cba09f5c6f7", new DateTime(2025, 11, 7, 17, 10, 3, 653, DateTimeKind.Local).AddTicks(9780) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "140cb195-6c9a-41a4-9976-438220d4ca21", "AQAAAAIAAYagAAAAEENNPk6pAz0S+udOqN0E0c59Z3pGwQHz/zxXoBNIQ1+GSE5zxvia+HXiHAe/Zu88Jw==", "a4906804-2b5f-408d-96aa-77afe63d92d5", new DateTime(2025, 11, 7, 17, 10, 4, 389, DateTimeKind.Local).AddTicks(520) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "f0af6b09-2cdd-430a-b927-5c5f1eb26419", "AQAAAAIAAYagAAAAEDhCHXyYERYsdvjFuMvxX6ES6KROFPWE89Z+QilF6R2T7BrFNKrBzaoZyyWj7f/NEw==", "64490b8a-d27e-4e94-a854-f336751eca5b", new DateTime(2025, 11, 7, 17, 10, 4, 430, DateTimeKind.Local).AddTicks(6353) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "7ba1670d-7978-44e8-88a6-b88fa32ae228", "AQAAAAIAAYagAAAAEPPg9bEqKBw3CC4Hb+KBdykpC16jrHWp+M0w2LfiOMUcKJHo2IT3zaSsYKcg+fBHUw==", "d3c01ea2-28bb-4516-84cd-c6dfd0b3b242", new DateTime(2025, 11, 7, 17, 10, 4, 471, DateTimeKind.Local).AddTicks(476) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "23",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "2f0d5c18-4a37-4669-83e2-229df2f662ea", "AQAAAAIAAYagAAAAEAt9tNlkFt9ub3Rq2jwvCq+zWpNcBUEb0QRF3f1PeH6sIFtn1NZvXOFz/jGi9iBycQ==", "84ebbaf5-ed5b-4950-96f1-f29fe4cdb466", new DateTime(2025, 11, 7, 17, 10, 4, 511, DateTimeKind.Local).AddTicks(2302) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "24",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "98f610ec-11d9-4192-9de5-1743ffe254f8", "AQAAAAIAAYagAAAAEK3mzA2Px4tkZKEACtc39k6Od/uZOqY5jF8IWONJesG+zj/EcD8hUn5eAjWrDI/n+w==", "f2cbb0f5-dd83-45fc-938f-eb7578b9f91b", new DateTime(2025, 11, 7, 17, 10, 4, 550, DateTimeKind.Local).AddTicks(4175) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "25",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "757bf270-083d-4f2c-9b73-15b4fd5a89aa", "AQAAAAIAAYagAAAAEIjSNDHYbq4ropicioKuhq8p105ptpZogREj+XO7d0UR2PM1MsbLvIHLjK6vcoGhJg==", "ab075a0d-6bd3-400f-b965-07b5a2b1d9f8", new DateTime(2025, 11, 7, 17, 10, 4, 590, DateTimeKind.Local).AddTicks(151) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "26",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "ed718ca6-2de2-4bc6-8e14-26c8f1b32716", "AQAAAAIAAYagAAAAEL05bgGqH9oLar7L1VVuXplyIyk4j8pW0SUIXalMsByImA6dMedeHRm65g7kveLSUQ==", "e644941b-449f-4a66-aa0e-ee6cc0628c58", new DateTime(2025, 11, 7, 17, 10, 4, 630, DateTimeKind.Local).AddTicks(3758) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "befcfef2-b88c-45a7-b163-da90b597458d", "AQAAAAIAAYagAAAAEDIllJi5XA4aSX+SuDDYxUO0q0D4jMV+z8bbaDiDrqINk+i71kNIbjjI5NHVCVL6pw==", "4d0e8dd4-3fb2-43d5-94f6-eccd9ea458d2", new DateTime(2025, 11, 7, 17, 10, 4, 677, DateTimeKind.Local).AddTicks(1999) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "28",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "ccf1d518-ef48-41b6-b52b-1b952500719a", "AQAAAAIAAYagAAAAEImsuqbO6HuWaNDKwONQzWu8DFaQFe1UUyGhsv4PtivKd7njY/YeRtbULjnrRf9eBw==", "a663fd0b-faa6-4da5-ae5f-bf2558c5051b", new DateTime(2025, 11, 7, 17, 10, 4, 720, DateTimeKind.Local).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "29",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "c51aefc2-6155-40a5-8766-d50bd9535a2e", "AQAAAAIAAYagAAAAEJ2T58dpzECIHYhrjHweYFmmmQ+mjY7G+HsZC1MuzFY8hdPLnd/xk+evoiZRGNbeuA==", "5e610ea4-7bc1-4a68-a302-1a27e56f7176", new DateTime(2025, 11, 7, 17, 10, 4, 763, DateTimeKind.Local).AddTicks(5520) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "f79840df-ac33-4021-86f9-d997568739c4", "AQAAAAIAAYagAAAAEIDocTzWaK0Z4ckgQPjytqmeOXgcTcr18H2/6kvtnEpP+VUEQ1jwlpwLdyUrgRQ3fA==", "e8eaa377-a3b3-48d5-9d96-fed6a04a33a0", new DateTime(2025, 11, 7, 17, 10, 3, 693, DateTimeKind.Local).AddTicks(9279) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "30",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "61db3961-175f-46e9-bb2f-ede814ebbaf8", "AQAAAAIAAYagAAAAEO3zkxpn6ECLs1mBnwVeO8utGoAYvjY0eSskP1oqoZHOKzMFe9Y6jDNJWqZbEJdNJQ==", "51f5dcb2-1a0d-42a7-a87f-7e0ff311c1bb", new DateTime(2025, 11, 7, 17, 10, 4, 804, DateTimeKind.Local).AddTicks(5186) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "31",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "215ee829-a8a2-489b-a554-5cbff30937bd", "AQAAAAIAAYagAAAAEOlADYS/V68/+A45FSyhbMlot7YZDncV6TDOreF+V5tjYy5o60oMPGT7z3GDRxc03w==", "e38ef75d-8ec6-4f20-aaa2-e3c35efeb424", new DateTime(2025, 11, 7, 17, 10, 4, 845, DateTimeKind.Local).AddTicks(3648) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "32",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "de483fd5-1fc8-4ca0-a5f4-045e34d340d8", "AQAAAAIAAYagAAAAEFpp/Tp6+ErHcChakvB38hCxuB5FR1v3GEtWeg2nw0GA4OOYxUYVvm0Urz8VMpWqxg==", "ee5294d5-e35c-4aa3-937d-9bca7aa31817", new DateTime(2025, 11, 7, 17, 10, 4, 886, DateTimeKind.Local).AddTicks(7992) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "33",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "0e6d7f3e-0bbe-445a-95b0-8366358d014f", "AQAAAAIAAYagAAAAEHODc7UPTj3qr8JxDlQrnrWP3Easnid6KVRlLVmzmfnM7PizaBkgYW8aNYKO+z9Emw==", "2b8b8fd1-be18-4c2d-aa01-0394094f7367", new DateTime(2025, 11, 7, 17, 10, 4, 928, DateTimeKind.Local).AddTicks(1223) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "34",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "94631287-a63f-4af9-9d9e-6b205f82365e", "AQAAAAIAAYagAAAAEKmYvnFuGKQb/GxrtFMktS4Ta3HIy7cUcGLEH22H7RnXu218uEgpdJyz3dOKpOz67g==", "3a7b05b3-e76a-4646-8d2d-ce94d37b5379", new DateTime(2025, 11, 7, 17, 10, 4, 969, DateTimeKind.Local).AddTicks(1990) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "35",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "b2d00b33-e2e1-4c80-9cd1-e5f16c1d08e9", "AQAAAAIAAYagAAAAEFRWZ3umXtl4eMwQDM8S0Eyj0dsaw2ScwSPeKiKVsbVXYxHrkCxKNq7YmMEm0T8kpQ==", "82bfe265-655d-40de-9d8b-e49ac08d8a2d", new DateTime(2025, 11, 7, 17, 10, 5, 10, DateTimeKind.Local).AddTicks(7864) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "36",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "4b5373f8-a52d-460c-b75d-e431c0a1d737", "AQAAAAIAAYagAAAAEDWQCFc7kXbRay2CiCdQe0FIauReFasyRP8HIiWOMt6iG83ms7/rNvBWV9g7B8OfMg==", "d53d5a6d-7aaa-434c-86e7-b887d3ab2fb7", new DateTime(2025, 11, 7, 17, 10, 5, 51, DateTimeKind.Local).AddTicks(8319) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "37",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "a30e54bd-728b-46ec-ad4f-2eb4cad75346", "AQAAAAIAAYagAAAAEBcDKw1WGPzHGQmDa6gpJMkQOvOHe6aS5UXM4lF8fEiWSYXY6jK00qzeoq+GnG08gw==", "4a4301a3-b90c-4902-82d4-965b087a5c7c", new DateTime(2025, 11, 7, 17, 10, 5, 93, DateTimeKind.Local).AddTicks(1917) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "38",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "d76dcd1e-4136-4fab-8f3c-3d8fabd98071", "AQAAAAIAAYagAAAAEDrh/z0WM6QyqDSOyP1S5wfOEs2cixwffa5gICSsP+iyFcV49mNJeQL/oBbY438C1g==", "b4f3a5e3-225c-4838-9455-74ee004b06c8", new DateTime(2025, 11, 7, 17, 10, 5, 133, DateTimeKind.Local).AddTicks(6402) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "39",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "a3f6d681-d358-4b13-a37b-1d2b0ebcc12d", "AQAAAAIAAYagAAAAEGNg754bCJIOP/+6YaOLOmkJ1j0Sv/NU0vmiXvT0g99gVjlLWBT6+44v3J++p6bB/Q==", "831bb60f-e8da-4a7d-bfa9-aa3ec2cd1706", new DateTime(2025, 11, 7, 17, 10, 5, 171, DateTimeKind.Local).AddTicks(7640) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "7f8baaeb-f613-48e9-8a26-96e2f6c999d8", "AQAAAAIAAYagAAAAEOe9r6Y+2SQCkdkyaOdzy4shz5jLBe1bOQWyhhycRRTJiKxICHLEPS/yW+Wq2tqU5w==", "57b85f77-5414-41e3-95cd-c0a0f6add5a7", new DateTime(2025, 11, 7, 17, 10, 3, 737, DateTimeKind.Local).AddTicks(2100) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "40",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "67b93485-77ac-4a3e-83bd-640b82d4e088", "AQAAAAIAAYagAAAAEFbPyGq7ef3q9S3Ps96DjBwUnRJkJbu5i1+U92pRNRv+/HY+gc+oBccRmkg2T44Lmg==", "a7235158-72af-4d68-aba0-7006d6d09c9d", new DateTime(2025, 11, 7, 17, 10, 5, 211, DateTimeKind.Local).AddTicks(1968) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "41",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "f9ff335e-435a-4204-84ad-88d2a1e3d3e9", "AQAAAAIAAYagAAAAEAbykF0Ed5ppdpY9WtLAAOxey52lvJz9ot9jC8wJCef+vlh8179HszRYah/za4wFkg==", "37ffef7d-5625-46e7-a3ef-e479249085df", new DateTime(2025, 11, 7, 17, 10, 5, 251, DateTimeKind.Local).AddTicks(2930) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "42",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "3c8ae1ee-45e1-4ddc-aaa4-bae36f8e97b1", "AQAAAAIAAYagAAAAEA4yFT3xvuBDS1k/kdP7nPHQruX4AyX2JMKOy1V0OdoegcAxIgRFWXA5yxiiD/PEZg==", "14ee4bbc-d048-413c-b38c-e986fab13022", new DateTime(2025, 11, 7, 17, 10, 5, 291, DateTimeKind.Local).AddTicks(2134) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "43",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "598cd393-128f-4a65-a51c-b4e1317d50ea", "AQAAAAIAAYagAAAAEOXxbM8yX2gAhdOT8k6bX/lEvt3Izl5UkAIsHGw+bHY+KOVTyX6C21/yQr+QGrlTUw==", "3e1dfe7b-898d-46aa-a30b-d01e05e945e7", new DateTime(2025, 11, 7, 17, 10, 5, 331, DateTimeKind.Local).AddTicks(3238) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "44",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "bfdee269-5abc-4a3e-a699-e93fafc927b8", "AQAAAAIAAYagAAAAEBGLuXO3qQgK3XEGGKbT/5/xvGR8SyPXIJV78sNA2SQNdWzPt5xOGqAHNHUIq6hShA==", "8934ac04-560f-416d-92ad-a25e81e07414", new DateTime(2025, 11, 7, 17, 10, 5, 371, DateTimeKind.Local).AddTicks(3566) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "45",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "8b9d84ec-37f2-44ae-9b45-78a84df8e157", "AQAAAAIAAYagAAAAEPNtXfNBUPkL4N5vStIFhOKw2CkdRmD22BM/MWnGfCkkUhI8OdObgIPJZ76O81ezyw==", "63a84b0e-72ec-4801-9233-b5e51f640fa9", new DateTime(2025, 11, 7, 17, 10, 5, 411, DateTimeKind.Local).AddTicks(4644) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "46",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "550e6f59-f025-4379-97c9-cc007cb2a076", "AQAAAAIAAYagAAAAEPhzrRshpezxR/8+jKOQKPec/+nqHLYX8F3yse6HStu29UEQg3MPKTnoj4kTYKQHTw==", "20c322fc-5a0b-430d-a301-342c54a6e874", new DateTime(2025, 11, 7, 17, 10, 5, 451, DateTimeKind.Local).AddTicks(4544) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "47",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "464974d2-0a49-4d5e-a3b8-b1c8abc20208", "AQAAAAIAAYagAAAAEKE+sT7ot3Gy6wPxrW0jfRmyclrBaRxpKLrKDLTKD2gbDjtc9YtoUgArE6MuypqGzw==", "9f4a35ce-6b56-484f-9d29-c0aa90a1a3ed", new DateTime(2025, 11, 7, 17, 10, 5, 491, DateTimeKind.Local).AddTicks(8970) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "48",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "1012b4ba-327e-4873-b07b-4cdf34308a19", "AQAAAAIAAYagAAAAEEYrKvdlEdMS5q/46J3jXWsBAsAciHDd97VQL6Si8zRgVltr0PU7TnavkCm3duoxuA==", "ce602325-99f9-4fd4-9dd1-838db752df0d", new DateTime(2025, 11, 7, 17, 10, 5, 532, DateTimeKind.Local).AddTicks(3283) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "49",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "985db3b6-207e-4915-85fb-4d03a671d403", "AQAAAAIAAYagAAAAEJKaAfuo5REt6mFej/rClRnBm27rW1NjCI+gLCGO/aF1CeTye5f52M8Wxfpj6Wr+nA==", "eeb7d593-45eb-4ab0-837e-8ad209e368f4", new DateTime(2025, 11, 7, 17, 10, 5, 573, DateTimeKind.Local).AddTicks(3956) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "cfa4daf5-03fa-4d37-8a37-2a04c1f3b559", "AQAAAAIAAYagAAAAEMiFsHX93tOhmvs64um31h/IesZPdkftdxsy8lnumJFEhD+CMU0mBKK02+Zvcs/ZAQ==", "93e48d3d-1da2-46ee-9374-8f78f697b1c6", new DateTime(2025, 11, 7, 17, 10, 3, 780, DateTimeKind.Local).AddTicks(5776) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "50",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "face16a3-6fdd-4b07-995c-3524f0973fcf", "AQAAAAIAAYagAAAAELPSB+rz93krGauDZadrs+2oq6Yo6UrFK5PmLV7uMZbaaa/f3ZAcMX5G9292a8c0kA==", "5240ce56-10bf-4164-996f-114386d4260c", new DateTime(2025, 11, 7, 17, 10, 5, 613, DateTimeKind.Local).AddTicks(5876) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "c86ef4d1-4894-4f8f-b9cb-76cd06896884", "AQAAAAIAAYagAAAAEEJR/XxdxuImQSKdAHqmB82N0iWinhToR13O8Du+QzcXMeVC5C4/T+cblbFGY4yjGQ==", "82d8c3c7-b515-4f48-b789-8ed634a04f73", new DateTime(2025, 11, 7, 17, 10, 3, 821, DateTimeKind.Local).AddTicks(924) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "167986a3-7948-4e1f-a942-dc7579aee4d0", "AQAAAAIAAYagAAAAEJSa+oRejVtPTydXdZ9ohTIzV9iw3+oLiZKBJpJ4CByAkZYVRwUi47OzRdtRqZJdDQ==", "f47c7206-0363-4a6f-a099-1cffa1ab5626", new DateTime(2025, 11, 7, 17, 10, 3, 862, DateTimeKind.Local).AddTicks(2795) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "bfd283fc-bfe7-4c84-b4c9-0ac063b67bac", "AQAAAAIAAYagAAAAEBW7h8RTJn+evzw6EaJu4H3LQ5IpM8eq9HjRjSs2TYqXwe7MIpWBOSUG1DXUDwmvwg==", "f92eb2a0-5f93-4322-bc6f-7feb893e9b96", new DateTime(2025, 11, 7, 17, 10, 3, 904, DateTimeKind.Local).AddTicks(3553) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "9e74bea5-b000-4bc9-ac3c-821deaf7c2ec", "AQAAAAIAAYagAAAAEKCkWuw/O07dipKbjhhqZ+1l3+DU5tzSfBTsK8MyJHHBbavfV55GsdA1IObOejcIlg==", "97b8808e-2470-49da-b7bc-cd0d3a3fb62b", new DateTime(2025, 11, 7, 17, 10, 3, 946, DateTimeKind.Local).AddTicks(2320) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 37L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 38L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 39L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 40L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 41L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 42L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 43L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 44L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 45L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 46L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 47L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 48L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 49L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 50L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 51L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 52L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 53L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 54L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 55L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 56L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 57L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 58L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 59L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 60L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 61L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 62L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 63L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 64L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 65L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 66L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 67L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 68L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 69L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 70L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 71L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 72L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 73L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 74L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 75L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 76L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 77L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 78L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 79L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 80L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 81L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 82L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 83L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 84L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 85L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 86L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 87L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 88L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 89L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 90L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 91L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 92L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 93L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 94L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 95L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 96L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 97L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 98L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 99L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 100L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 101L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 102L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 103L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 104L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 105L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 106L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 107L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 108L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 109L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 110L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 111L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 112L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 113L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 114L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 115L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 116L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 117L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 118L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 119L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 120L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 121L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 122L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 123L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 124L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 125L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 126L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 127L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 128L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 129L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 130L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 131L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 132L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 133L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 134L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 135L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 136L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 137L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 138L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 139L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 140L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 141L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 142L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 143L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 144L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 145L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 146L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 147L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 148L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 149L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 150L);

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 2L,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 3L,
                column: "Status",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 4L,
                column: "DateCreated",
                value: new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 5L,
                columns: new[] { "DateCreated", "Status" },
                values: new object[] { new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 6L,
                columns: new[] { "DateCreated", "Status" },
                values: new object[] { new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 7L,
                column: "DateCreated",
                value: new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 8L,
                columns: new[] { "DateCreated", "Status" },
                values: new object[] { new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 9L,
                columns: new[] { "DateCreated", "Status" },
                values: new object[] { new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 10L,
                column: "DateCreated",
                value: new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 11L,
                columns: new[] { "DateCreated", "Status" },
                values: new object[] { new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 12L,
                columns: new[] { "DateCreated", "Status" },
                values: new object[] { new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 13L,
                column: "DateCreated",
                value: new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 14L,
                columns: new[] { "DateCreated", "Status" },
                values: new object[] { new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 15L,
                columns: new[] { "DateCreated", "Status" },
                values: new object[] { new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 16L,
                column: "DateCreated",
                value: new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 17L,
                columns: new[] { "DateCreated", "Status" },
                values: new object[] { new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 18L,
                columns: new[] { "DateCreated", "Status" },
                values: new object[] { new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 19L,
                column: "DateCreated",
                value: new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 20L,
                columns: new[] { "DateCreated", "Status" },
                values: new object[] { new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 21L,
                columns: new[] { "DateCreated", "Status" },
                values: new object[] { new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 22L,
                column: "DateCreated",
                value: new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 23L,
                columns: new[] { "DateCreated", "Status" },
                values: new object[] { new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 24L,
                columns: new[] { "DateCreated", "Status" },
                values: new object[] { new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 25L,
                column: "DateCreated",
                value: new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 26L,
                columns: new[] { "DateCreated", "Status" },
                values: new object[] { new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 27L,
                columns: new[] { "DateCreated", "Status" },
                values: new object[] { new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 28L,
                column: "DateCreated",
                value: new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 29L,
                columns: new[] { "DateCreated", "Status" },
                values: new object[] { new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 30L,
                columns: new[] { "DateCreated", "Status" },
                values: new object[] { new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 31L,
                column: "DateCreated",
                value: new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 32L,
                columns: new[] { "DateCreated", "Status" },
                values: new object[] { new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 33L,
                columns: new[] { "DateCreated", "Status" },
                values: new object[] { new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 34L,
                column: "DateCreated",
                value: new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 35L,
                columns: new[] { "DateCreated", "Status" },
                values: new object[] { new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 36L,
                columns: new[] { "DateCreated", "Status" },
                values: new object[] { new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 1L,
                column: "UpdatedAt",
                value: new DateTime(2025, 11, 7, 17, 4, 51, 166, DateTimeKind.Local).AddTicks(2786));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 2L,
                column: "UpdatedAt",
                value: new DateTime(2025, 11, 7, 17, 4, 51, 166, DateTimeKind.Local).AddTicks(2795));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 3L,
                column: "UpdatedAt",
                value: new DateTime(2025, 11, 7, 17, 4, 51, 166, DateTimeKind.Local).AddTicks(2798));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 4L,
                column: "UpdatedAt",
                value: new DateTime(2025, 11, 7, 17, 4, 51, 166, DateTimeKind.Local).AddTicks(2799));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 5L,
                column: "UpdatedAt",
                value: new DateTime(2025, 11, 7, 17, 4, 51, 166, DateTimeKind.Local).AddTicks(2800));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 6L,
                column: "UpdatedAt",
                value: new DateTime(2025, 11, 7, 17, 4, 51, 166, DateTimeKind.Local).AddTicks(2802));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 7L,
                column: "UpdatedAt",
                value: new DateTime(2025, 11, 7, 17, 4, 51, 166, DateTimeKind.Local).AddTicks(2803));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 8L,
                column: "UpdatedAt",
                value: new DateTime(2025, 11, 7, 17, 4, 51, 166, DateTimeKind.Local).AddTicks(2804));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 9L,
                column: "UpdatedAt",
                value: new DateTime(2025, 11, 7, 17, 4, 51, 166, DateTimeKind.Local).AddTicks(2805));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 10L,
                column: "UpdatedAt",
                value: new DateTime(2025, 11, 7, 17, 4, 51, 166, DateTimeKind.Local).AddTicks(2807));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 11L,
                column: "UpdatedAt",
                value: new DateTime(2025, 11, 7, 17, 4, 51, 166, DateTimeKind.Local).AddTicks(2807));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 12L,
                column: "UpdatedAt",
                value: new DateTime(2025, 11, 7, 17, 4, 51, 166, DateTimeKind.Local).AddTicks(2808));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 13L,
                column: "UpdatedAt",
                value: new DateTime(2025, 11, 7, 17, 4, 51, 166, DateTimeKind.Local).AddTicks(2809));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 14L,
                column: "UpdatedAt",
                value: new DateTime(2025, 11, 7, 17, 4, 51, 166, DateTimeKind.Local).AddTicks(2810));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 15L,
                column: "UpdatedAt",
                value: new DateTime(2025, 11, 7, 17, 4, 51, 166, DateTimeKind.Local).AddTicks(2811));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 16L,
                column: "UpdatedAt",
                value: new DateTime(2025, 11, 7, 17, 4, 51, 166, DateTimeKind.Local).AddTicks(2812));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 17L,
                column: "UpdatedAt",
                value: new DateTime(2025, 11, 7, 17, 4, 51, 166, DateTimeKind.Local).AddTicks(2813));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 18L,
                column: "UpdatedAt",
                value: new DateTime(2025, 11, 7, 17, 4, 51, 166, DateTimeKind.Local).AddTicks(2815));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 19L,
                column: "UpdatedAt",
                value: new DateTime(2025, 11, 7, 17, 4, 51, 166, DateTimeKind.Local).AddTicks(2815));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 20L,
                column: "UpdatedAt",
                value: new DateTime(2025, 11, 7, 17, 4, 51, 166, DateTimeKind.Local).AddTicks(2816));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 21L,
                column: "UpdatedAt",
                value: new DateTime(2025, 11, 7, 17, 4, 51, 166, DateTimeKind.Local).AddTicks(2817));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 22L,
                column: "UpdatedAt",
                value: new DateTime(2025, 11, 7, 17, 4, 51, 166, DateTimeKind.Local).AddTicks(2818));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 23L,
                column: "UpdatedAt",
                value: new DateTime(2025, 11, 7, 17, 4, 51, 166, DateTimeKind.Local).AddTicks(2819));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 24L,
                column: "UpdatedAt",
                value: new DateTime(2025, 11, 7, 17, 4, 51, 166, DateTimeKind.Local).AddTicks(2820));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "4b636209-8113-45ed-b0cb-e55fa32a3db4", "AQAAAAIAAYagAAAAEGGxDhj35T7007Bt4A8SjvntvDtmnAglvUty0qIRtZQBzLsKWfSJDumltqkQ2qtfig==", "9e2377ed-07ef-4a5f-a420-b4c0496964d8", new DateTime(2025, 11, 7, 17, 4, 51, 166, DateTimeKind.Local).AddTicks(6329) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "b3594d53-ac35-4ffd-a124-eef92aa5a1f2", "AQAAAAIAAYagAAAAEOShF3Okl1ejoHPqNlJDh1PAuOro1s+mplrTQOkZXsz6Luf/8yiwvxqC9o2rO4kaTQ==", "8e9bfdc0-5581-4d0c-9766-28bf9953a915", new DateTime(2025, 11, 7, 17, 4, 51, 536, DateTimeKind.Local).AddTicks(1865) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "bd4b6315-9be4-4d96-b07d-bbaf3d67cb45", "AQAAAAIAAYagAAAAEHYUj/xrJ/aWZzrV8lH1Yk2zwEapnWjsKgoBazsA1gefE1hGi9FLdjwA/kFd5IyZ0Q==", "a9ecbff6-80d1-40b7-97d4-af873d03ed8f", new DateTime(2025, 11, 7, 17, 4, 51, 576, DateTimeKind.Local).AddTicks(6471) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "3ad387f6-0be3-4b11-b0a1-4a482791e73e", "AQAAAAIAAYagAAAAEEgxtZKeU/m+joZDh5CZgm7a5Kvz24r/26y6B8YbC4HkBgR1y9rZpVaadboIMtz54A==", "e4898f3a-0d8d-4b99-9d27-04754eb92449", new DateTime(2025, 11, 7, 17, 4, 51, 617, DateTimeKind.Local).AddTicks(1106) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "a619c6c8-50dc-4b0f-bb70-93b538d84f51", "AQAAAAIAAYagAAAAENJ49rVivwFwdmfcn2bwUTXn3eyqQIAX/dkGBH8Ssc6/0wSLt7SxKTNEUNEq0AnGpg==", "0a6929ae-0a61-4e62-a405-205d521e4238", new DateTime(2025, 11, 7, 17, 4, 51, 659, DateTimeKind.Local).AddTicks(4967) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "e14b9285-2d49-4f65-bca0-8e2a206369c3", "AQAAAAIAAYagAAAAEJDvvwYzmCn2sPwrQKfVKWcybN80dfHsZsI+rpSkaTTz4n45qbzYL4RyPrAqTDyo7g==", "17359f79-bc15-424c-8be5-61714bacb72e", new DateTime(2025, 11, 7, 17, 4, 51, 700, DateTimeKind.Local).AddTicks(2905) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "a9a3500a-9ea2-4391-bec6-c409e963b00d", "AQAAAAIAAYagAAAAEA1rYpmIid0RIpZb9AnMo5uLsuHP8d+K7Zkt+D1CuZVNmLAaeeX2OwD122vYjEOVzg==", "6c3120c7-6f83-4bae-8d3e-b95c223142ba", new DateTime(2025, 11, 7, 17, 4, 51, 741, DateTimeKind.Local).AddTicks(1692) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "fcced67d-9792-4303-999a-83ada1e7bc8c", "AQAAAAIAAYagAAAAENdVK9ns7RZ9NmlGY8LJacfpa3AGdUoBiTsqYyxxafUX8eZiYRI/MbDvb+z3v39YKA==", "079a63d7-0536-4b7d-8b16-133e6656ca12", new DateTime(2025, 11, 7, 17, 4, 51, 781, DateTimeKind.Local).AddTicks(7510) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "9ea1f14c-baef-437c-9b6f-506136ffb60a", "AQAAAAIAAYagAAAAEL6jrvPRZ8s3brOW6Fw0P5LRW7mGHvITPR7gtzqKJGiG/HjsstyeqXRidM56KyJTcQ==", "c0b9d800-a187-4d90-aa6a-da8123441382", new DateTime(2025, 11, 7, 17, 4, 51, 822, DateTimeKind.Local).AddTicks(6566) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "7d5e76c5-ae54-4be0-88f3-188ac47e4492", "AQAAAAIAAYagAAAAEBikMpFaBs+a+Ctk2+1q66g9XyxqLm4TX04hODXz0WituVLjAfNFf01tFmYdEfOiFA==", "f3773a2f-17aa-44d2-acc3-1715628bdc07", new DateTime(2025, 11, 7, 17, 4, 51, 861, DateTimeKind.Local).AddTicks(1070) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "814ad285-5258-4dd9-b35f-7f3780dce765", "AQAAAAIAAYagAAAAEMNtQNgBUgANZZzzX7hJXVt0+FUfAnRSuKCIRpVoSdHc9DS0BmMHUSSUonug0COJCg==", "91eee0d2-fb64-46de-9c39-c35514a39a98", new DateTime(2025, 11, 7, 17, 4, 51, 900, DateTimeKind.Local).AddTicks(4744) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "0a72eb2b-bd0c-44d4-8698-9e07d93866d3", "AQAAAAIAAYagAAAAEGnIIVRdbdpX7Qz5j12itUHWBeXYyUUEub/o/hrUqp7uvoEdBsEmT7xZt8T87/poow==", "154ed329-d9f8-4e41-be81-8e90d7a01013", new DateTime(2025, 11, 7, 17, 4, 51, 209, DateTimeKind.Local).AddTicks(4612) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "042233cb-2b2e-4086-89f0-5f4411f50b3a", "AQAAAAIAAYagAAAAEHG66l73wq5VLbRsnjnfuDFyvBwDpNqzi1SQIBtmeq7TFbK9fKgFq8+JVpJ8dkLtQg==", "0b9cb08b-97fa-4932-81a6-ae71344dc1c9", new DateTime(2025, 11, 7, 17, 4, 51, 939, DateTimeKind.Local).AddTicks(6399) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "dfe83569-80da-4db1-84f6-e763d7d76ddf", "AQAAAAIAAYagAAAAEGyqzpbX7OFvShRlCij5maJHGnR3QIuNSIxvkEXXXu3RtyQim5juhQSB07AY3DDRhg==", "d7dc7d93-b3e8-4871-9cb0-d32ea0e67aa6", new DateTime(2025, 11, 7, 17, 4, 51, 979, DateTimeKind.Local).AddTicks(3866) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "ec9edeb4-a995-4606-939f-8ea7b7476d81", "AQAAAAIAAYagAAAAEHEuNka0FTAfD6it4UQUwus7LEx6gkIFSCdhyqrg6abD9wutnHUoambF8XcAJDvunA==", "cd4f246e-72ad-47ea-9546-e5024b178b63", new DateTime(2025, 11, 7, 17, 4, 52, 21, DateTimeKind.Local).AddTicks(988) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "23",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "a83db2d9-d42d-4dbe-b817-3e92ae078b9e", "AQAAAAIAAYagAAAAEEtdowAFH/F1Hlkd4a0o+k4KFKzOeJu1WofZyRT8mD/5xP5B6qsq3D/F6Xt8yBgP9g==", "4cfca961-9521-4e00-9ece-0be40915f0d3", new DateTime(2025, 11, 7, 17, 4, 52, 61, DateTimeKind.Local).AddTicks(7996) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "24",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "3dfa8b44-c48c-4c51-b222-4ed30b64f932", "AQAAAAIAAYagAAAAEJbI07CkjbYlhrZRTg/OHutrR+D8Y4KZOjaydDD+KxMeRrIjbUrclBV3F2p0n9gs9A==", "73f22c3b-be55-4e1a-9a71-774dd750d276", new DateTime(2025, 11, 7, 17, 4, 52, 103, DateTimeKind.Local).AddTicks(4232) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "25",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "ae405221-1a49-4f7f-8176-c9528622ecb5", "AQAAAAIAAYagAAAAEPth9n2SgPlkFwpTeZbV2HUGSjBeQ5Qf57hTEPekpez2j1ONcm+2dXwYs7uNcX3y0g==", "abe38ed0-10df-4e65-a925-2c20ca740c73", new DateTime(2025, 11, 7, 17, 4, 52, 145, DateTimeKind.Local).AddTicks(6851) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "26",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "e1491b68-2485-491c-871c-4efc965fd9d8", "AQAAAAIAAYagAAAAEL4TkfzG8DUHasQJ6R+3gzJpaGVHUR/sbZTTcec0kfeciPwCpEAEeSt8g2qu9edRLA==", "1e78ff3e-5c7c-45e1-ac77-b14c5ac676d3", new DateTime(2025, 11, 7, 17, 4, 52, 190, DateTimeKind.Local).AddTicks(4850) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "ee7990a9-25c6-4fc8-8ca7-edc0aeb47deb", "AQAAAAIAAYagAAAAEE2Q3cEYRWcXVIi5esEDtLl5+wZglB7R3JwZKlPpb3O+9MVJDZWAW181Bk7xwGi+Zg==", "09c2a397-5d59-4a64-bdf5-cc6941850899", new DateTime(2025, 11, 7, 17, 4, 52, 232, DateTimeKind.Local).AddTicks(371) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "28",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "d6335f6f-9aa3-4380-be4e-56e9b1a144bb", "AQAAAAIAAYagAAAAEFJYzscDVYJu+fHVuLcMgyYryvFsgYloATm4LGUGy3xQviVvePM+SGlJs//k2OsOlg==", "14be59fd-2df3-4cac-9f64-85fd4340ca29", new DateTime(2025, 11, 7, 17, 4, 52, 272, DateTimeKind.Local).AddTicks(5505) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "29",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "6b377ea6-e600-4076-8664-5fccadf080b1", "AQAAAAIAAYagAAAAEMxhi6DTgCITTAmBfi/J72Hhv+Bi/Y9fIJV0wXgBr+7VoYQ15DSzNHN8wCL+q29SgA==", "b1c58378-d0a5-45e9-b4ef-3a9ebec452c6", new DateTime(2025, 11, 7, 17, 4, 52, 310, DateTimeKind.Local).AddTicks(8581) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "07a7adac-32b7-417d-8bb0-b96bf071ab73", "AQAAAAIAAYagAAAAEEeN97yMg5s6vdGw+4ScS41vLtAJ9TK9sH6EE4sItIIuoHSdC04d9dP3upSZwoIwyg==", "ca75643e-4395-435a-a34f-afe93275a7a1", new DateTime(2025, 11, 7, 17, 4, 51, 248, DateTimeKind.Local).AddTicks(9341) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "30",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "5dfb11ff-3e05-4364-8b9e-65c6c16e1bf2", "AQAAAAIAAYagAAAAEC4nIUNIPAvSMMp9ZDraJqoQJPsviPn6ZgM6X+8HxSZ25lE3mFUOYJKOmJc8rmUdmA==", "327b6db8-c8f1-4d7b-892b-157615c52bc5", new DateTime(2025, 11, 7, 17, 4, 52, 350, DateTimeKind.Local).AddTicks(1513) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "31",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "976b2f21-8326-400a-b9da-292bffe40f20", "AQAAAAIAAYagAAAAEFOMT7xwRlZru0xwnp7eGEtl9xHqRqsIA1hvRPjNMgEKWn9qS8RTmn9Hdu/1yOnk5A==", "3ddcd77f-ea3e-43fa-9632-81dd892ca264", new DateTime(2025, 11, 7, 17, 4, 52, 390, DateTimeKind.Local).AddTicks(1249) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "32",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "1a19cf43-b209-4f68-8482-bfc8b8666e0d", "AQAAAAIAAYagAAAAEIipZeL0v9qTJb5M0rq38/WnOg5fwmIb7Eq8tnAD6G00E89WxFeIugc4aWiuO0gUcA==", "f7196a2d-964e-428b-b515-eea98fe7e5b4", new DateTime(2025, 11, 7, 17, 4, 52, 430, DateTimeKind.Local).AddTicks(8279) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "33",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "c78a3335-a796-4dd4-9814-12026a42ec8e", "AQAAAAIAAYagAAAAEETIajillgrpxamYK7A69cFFcxlh3fO1hrISetHqnGPIyebQLr8JKu2+g1WWvDYWCA==", "a9501c2f-1609-4553-a244-99c99b56de0b", new DateTime(2025, 11, 7, 17, 4, 52, 471, DateTimeKind.Local).AddTicks(266) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "34",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "db1071ab-773a-43a1-a57f-9e7b2063b40e", "AQAAAAIAAYagAAAAEDfyYljEIZWtmohtx+jbD9JWOROQLd5APZtaPLZUXc4/IvAxPoi9L0z76LbDG9XOkg==", "b3068fbe-d617-4637-be68-d455d07b32a2", new DateTime(2025, 11, 7, 17, 4, 52, 511, DateTimeKind.Local).AddTicks(2943) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "35",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "62b41839-97e7-4ee5-ac11-d3594322454c", "AQAAAAIAAYagAAAAEMxEFwGduJoRXYYwjitx6hzJJpM56XY71F9H7pyBvCfs7pV+FY+NtC/4rfbzSA+Few==", "2dc2e068-4854-4143-954c-0d01e8104d9d", new DateTime(2025, 11, 7, 17, 4, 52, 552, DateTimeKind.Local).AddTicks(1163) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "36",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "dac95709-7088-4a19-bea2-38e5a3dcf60e", "AQAAAAIAAYagAAAAEP/VuxoybF2s0C968lBwlNh2y+zbg+wALYDx17fEgzRNItND3MYSPJzDz6cCY10ztg==", "b61a912a-b7f8-4414-97cb-35a5767311c5", new DateTime(2025, 11, 7, 17, 4, 52, 592, DateTimeKind.Local).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "37",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "0c08db48-b332-40fd-b460-dd6e7005cb0d", "AQAAAAIAAYagAAAAEH3mV/ko5dD2deZEuUli/73kz1Cqb+Uz+fgKEJCSi6LbeLUVQ80TqY3cY8DXypXQGw==", "e8abd741-1c78-4656-b45c-87d4b4de8799", new DateTime(2025, 11, 7, 17, 4, 52, 631, DateTimeKind.Local).AddTicks(5427) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "38",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "4d15b3fd-f9ab-4fde-8de8-13c23d5345e8", "AQAAAAIAAYagAAAAEJCfA1wbIB95qxcuWB4ud0WRjSxVs6A49xCFwsylWGx290tGpBzZ/4/F5DYyUwlvfw==", "f726e308-e104-4038-9e69-f26ca0a1d863", new DateTime(2025, 11, 7, 17, 4, 52, 671, DateTimeKind.Local).AddTicks(68) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "39",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "edfd6dce-ffd5-4055-924c-c460381e9089", "AQAAAAIAAYagAAAAEPYdWg+NY+PJuj1QgPRCVmIKs/xGKi60Y8wzrWkz8p2+3UTxtsHbGY64Bj7sWrKK7Q==", "b88f7750-ce81-4240-b677-2582fad0326e", new DateTime(2025, 11, 7, 17, 4, 52, 712, DateTimeKind.Local).AddTicks(579) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "9c77a5d1-10af-441e-a58e-57e695c997a2", "AQAAAAIAAYagAAAAEJVMV3/SXaGa41V9MTxXZUY3PC+/J6YRqJ+QpsX3EeLIHyMTiSupHC1dsH2niiWHBQ==", "212fee24-1190-488e-8dbc-e18b419e33a9", new DateTime(2025, 11, 7, 17, 4, 51, 291, DateTimeKind.Local).AddTicks(9686) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "40",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "5f020bae-cec1-4cbb-8753-4f8463f1af10", "AQAAAAIAAYagAAAAEIurJ5MDvU+b7ZCfxDaIE7zV1E5cyg+XlJcS0wYCZ9rGUCUEfId+wAR8VaEKfNtDWg==", "be3f3664-383f-449f-9ebb-dc279121ef93", new DateTime(2025, 11, 7, 17, 4, 52, 752, DateTimeKind.Local).AddTicks(9740) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "41",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "f6c99d94-20c2-4d3b-b123-c35cbd00cce1", "AQAAAAIAAYagAAAAELPPMjDIcFMW5mh304Q7sM0Qy7T9sfzG0X0krzgaUHRYmhvpjkSnK8lIDYU3ElEwVw==", "238a8d26-cdff-4b0f-94f1-16d5a2918e5a", new DateTime(2025, 11, 7, 17, 4, 52, 794, DateTimeKind.Local).AddTicks(6771) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "42",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "a0c1bc10-4609-4cec-be1d-93cf260041e5", "AQAAAAIAAYagAAAAEGWBTmu2ZRg5LOGgkQhXZMk14S/OMhNiBKkIECBykIPrppzmyq0WjrSy/rGovQfYow==", "9e7e0c1b-0744-4b41-94f4-53c6d4bb96c8", new DateTime(2025, 11, 7, 17, 4, 52, 836, DateTimeKind.Local).AddTicks(4218) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "43",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "5bf7f698-beec-42df-b11f-559413d71fde", "AQAAAAIAAYagAAAAEJhr4FWNwTAlYmQ2hJgPlSUhHvHTHgzRfgGwBWdgUvaLEH7Q1atXKL/5ElBfYsGOYw==", "2f7bf9cb-a6b9-4072-aef2-9b4d09ae3d19", new DateTime(2025, 11, 7, 17, 4, 52, 877, DateTimeKind.Local).AddTicks(6132) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "44",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "cd18d218-574d-49e4-98c7-86a90cbf3efd", "AQAAAAIAAYagAAAAEKApuYZ89DRTUY1S139/gGYLBI531jAy7DCIYeofkfUy3VqalMRM8MG7JyRxMS1DoA==", "2a63554d-cdfd-4be3-bcb7-39d97ca29bd6", new DateTime(2025, 11, 7, 17, 4, 52, 918, DateTimeKind.Local).AddTicks(7620) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "45",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "81d30027-05da-4e4e-be51-78a2cea08cfd", "AQAAAAIAAYagAAAAEPIUDbd19z9D+Cx3SAdXFHcgV0kgzUELk1nsv5X1ur3TD61zmjI3K9GwvfYdehgpxg==", "4ee30a0e-50d3-4abd-9cf5-a50e81fa749e", new DateTime(2025, 11, 7, 17, 4, 52, 957, DateTimeKind.Local).AddTicks(5212) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "46",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "0cd026f1-35aa-498c-a6c8-c6cab0b59cc0", "AQAAAAIAAYagAAAAEFzrCdiaPcAHZOUJ9uwmUfcf6d/eBCAXUlYkRhbzqAdhVdzQ0Ui+RrZELCNt4yi6Ug==", "ce9a0bfc-aa98-4702-8f74-65abd4f3fce7", new DateTime(2025, 11, 7, 17, 4, 52, 996, DateTimeKind.Local).AddTicks(6840) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "47",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "eee09199-72f7-436d-910f-3dcd4e33f52c", "AQAAAAIAAYagAAAAEEIiWPex3BBel9ItL0x3oQ6nOza4sa/1SZw+2Zl8YuU+C2ezjHXRoM9YOc6ENgFKIA==", "b499c407-fa74-4cea-bc64-5ff390020386", new DateTime(2025, 11, 7, 17, 4, 53, 36, DateTimeKind.Local).AddTicks(5817) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "48",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "085586d5-d61a-40fa-86dc-a25a76b8ff08", "AQAAAAIAAYagAAAAEDdYFBP9IrxWyPGyRC/NtJ6VNay0cVHvEEYuzFOWU/XnrJPYAFo+b4KInVE1IXbAoA==", "635c7103-9682-4e23-b400-792512fc1870", new DateTime(2025, 11, 7, 17, 4, 53, 77, DateTimeKind.Local).AddTicks(1396) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "49",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "450facdc-f737-4fcf-8845-a914f91a50ad", "AQAAAAIAAYagAAAAECvBsz5JVjFLRYFpnxfHgMnAnWf5QVqdttJSVjAbsx2iMAnJZ/zAlVWb8zQlLEP38A==", "6ad80b9f-28ea-4321-92c3-58a2817db6ed", new DateTime(2025, 11, 7, 17, 4, 53, 117, DateTimeKind.Local).AddTicks(1392) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "39377b96-d2fc-445b-a910-bc1156d4771f", "AQAAAAIAAYagAAAAEPKVBBTiT3Z6Ao7MC2wpBb7Tw/uuJLd7QJ5b2Dky9KlWw6+6wQF9oleTJ6tsVwKE1w==", "ef1f92ea-8f12-4033-b0b9-0363980b3e82", new DateTime(2025, 11, 7, 17, 4, 51, 333, DateTimeKind.Local).AddTicks(2761) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "50",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "9d689200-2c90-4eea-bbee-60aef716ce1e", "AQAAAAIAAYagAAAAEPQ634CwHhvVin9BC2GXgWCmeaEVQVnmiPnJhU2b0fpDlfAUhdKE0X8w34LIs3jl0A==", "de8df70d-3c5d-492f-a5c1-8722dd41862d", new DateTime(2025, 11, 7, 17, 4, 53, 157, DateTimeKind.Local).AddTicks(2736) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "dbb94100-4a97-424e-82e4-e8d1c1a66cb2", "AQAAAAIAAYagAAAAELcNmkCFFbdCiQDqZODEm0CX5P3wTrgvY9U6Se5TqYkmNXRtX/o4wl+0Ts263WfwPw==", "2522a8fe-e2dd-4336-a3e5-00d721587c40", new DateTime(2025, 11, 7, 17, 4, 51, 373, DateTimeKind.Local).AddTicks(6550) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "14784472-6678-4876-9af1-f45751228064", "AQAAAAIAAYagAAAAEIp3hqb5xTGMqzX7ZnZawaAizRBE8E1IwTWFcGcCWd1BBZpC0J2nDlBIJCfc+cfErA==", "80dd5299-827a-4eee-b384-0330a4956a67", new DateTime(2025, 11, 7, 17, 4, 51, 414, DateTimeKind.Local).AddTicks(5248) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "e3be31c0-2bf7-4aea-8a69-a83945da44ad", "AQAAAAIAAYagAAAAEGdIWvWdq23QGq3Sf74xotuOffTcmD3tgZ05j4tr+Cz9ZUwOkTw0+SylXiW0c24DRQ==", "c6d44e94-49d2-4e13-9803-a9654456708e", new DateTime(2025, 11, 7, 17, 4, 51, 454, DateTimeKind.Local).AddTicks(8281) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "e3785afa-27e9-43d7-9a26-a70b5816688f", "AQAAAAIAAYagAAAAEKb1zTkr8C+S0myp6rnGylBrshV6UWJ3SEWW35l/Mk68BHJ4OBDm9xmk9Khd68vnjg==", "ad6c7612-5761-4060-8f74-83ca90d0b2be", new DateTime(2025, 11, 7, 17, 4, 51, 495, DateTimeKind.Local).AddTicks(5061) });
        }
    }
}
