using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OnlineLearningPlatform.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "student-role");

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 1L,
                column: "UpdatedAt",
                value: new DateTime(2025, 9, 25, 14, 22, 50, 153, DateTimeKind.Local).AddTicks(7361));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 2L,
                column: "UpdatedAt",
                value: new DateTime(2025, 9, 25, 14, 22, 50, 153, DateTimeKind.Local).AddTicks(7411));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 3L,
                column: "UpdatedAt",
                value: new DateTime(2025, 9, 25, 14, 22, 50, 153, DateTimeKind.Local).AddTicks(7419));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 4L,
                column: "UpdatedAt",
                value: new DateTime(2025, 9, 25, 14, 22, 50, 153, DateTimeKind.Local).AddTicks(7424));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 5L,
                column: "UpdatedAt",
                value: new DateTime(2025, 9, 25, 14, 22, 50, 153, DateTimeKind.Local).AddTicks(7428));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 6L,
                column: "UpdatedAt",
                value: new DateTime(2025, 9, 25, 14, 22, 50, 153, DateTimeKind.Local).AddTicks(7439));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 7L,
                column: "UpdatedAt",
                value: new DateTime(2025, 9, 25, 14, 22, 50, 153, DateTimeKind.Local).AddTicks(7443));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 8L,
                column: "UpdatedAt",
                value: new DateTime(2025, 9, 25, 14, 22, 50, 153, DateTimeKind.Local).AddTicks(7447));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 9L,
                column: "UpdatedAt",
                value: new DateTime(2025, 9, 25, 14, 22, 50, 153, DateTimeKind.Local).AddTicks(7450));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 10L,
                column: "UpdatedAt",
                value: new DateTime(2025, 9, 25, 14, 22, 50, 153, DateTimeKind.Local).AddTicks(7456));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 11L,
                column: "UpdatedAt",
                value: new DateTime(2025, 9, 25, 14, 22, 50, 153, DateTimeKind.Local).AddTicks(7459));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 12L,
                column: "UpdatedAt",
                value: new DateTime(2025, 9, 25, 14, 22, 50, 153, DateTimeKind.Local).AddTicks(7462));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 13L,
                column: "UpdatedAt",
                value: new DateTime(2025, 9, 25, 14, 22, 50, 153, DateTimeKind.Local).AddTicks(7466));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 14L,
                column: "UpdatedAt",
                value: new DateTime(2025, 9, 25, 14, 22, 50, 153, DateTimeKind.Local).AddTicks(7469));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 15L,
                column: "UpdatedAt",
                value: new DateTime(2025, 9, 25, 14, 22, 50, 153, DateTimeKind.Local).AddTicks(7472));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 16L,
                column: "UpdatedAt",
                value: new DateTime(2025, 9, 25, 14, 22, 50, 153, DateTimeKind.Local).AddTicks(7476));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 17L,
                column: "UpdatedAt",
                value: new DateTime(2025, 9, 25, 14, 22, 50, 153, DateTimeKind.Local).AddTicks(7479));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 18L,
                column: "UpdatedAt",
                value: new DateTime(2025, 9, 25, 14, 22, 50, 153, DateTimeKind.Local).AddTicks(7485));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 19L,
                column: "UpdatedAt",
                value: new DateTime(2025, 9, 25, 14, 22, 50, 153, DateTimeKind.Local).AddTicks(7488));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 20L,
                column: "UpdatedAt",
                value: new DateTime(2025, 9, 25, 14, 22, 50, 153, DateTimeKind.Local).AddTicks(7491));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 21L,
                column: "UpdatedAt",
                value: new DateTime(2025, 9, 25, 14, 22, 50, 153, DateTimeKind.Local).AddTicks(7495));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 22L,
                column: "UpdatedAt",
                value: new DateTime(2025, 9, 25, 14, 22, 50, 153, DateTimeKind.Local).AddTicks(7498));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 23L,
                column: "UpdatedAt",
                value: new DateTime(2025, 9, 25, 14, 22, 50, 153, DateTimeKind.Local).AddTicks(7502));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 24L,
                column: "UpdatedAt",
                value: new DateTime(2025, 9, 25, 14, 22, 50, 153, DateTimeKind.Local).AddTicks(7505));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "mentee-role", null, "Mentee", "MENTEE" });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "admin-role", "1" },
                    { "mentor-role", "2" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "ba11580e-fa75-4c89-983f-599fb04a06ab", "$2a$12$kQ63D8sZWoabK6BNtC2Af.2GApnoXs28xGSd.R7cbDGQIl5OpQUGm", "8af4f7a9-6441-47da-8ba0-b69f81011d1c", new DateTime(2025, 9, 25, 14, 22, 50, 155, DateTimeKind.Local).AddTicks(9687) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Dob", "FullName", "Gender", "PasswordHash", "Phone", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "1e8eade8-8c9d-427c-b216-0072a9e7a7ee", new DateTime(2025, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateOnly(1990, 1, 1), "User 10", true, "$2a$12$/2znwFl0AxjsTizeNmVgo.qI.146k8i3OO70kI3X/86vOthDCqOyW", "0900000010", "e31c7671-4b6b-414e-b0ea-d3b12c042493", new DateTime(2025, 9, 25, 14, 22, 55, 897, DateTimeKind.Local).AddTicks(5454) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Dob", "FullName", "Gender", "PasswordHash", "Phone", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "1f83ed01-9a5f-4f86-b7a9-304533f6ad90", new DateTime(2025, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateOnly(1989, 1, 1), "User 11", false, "$2a$12$njYpw04uEZit0tGbOwVbiuCHaKBgsVQM.Cya4TvnLOayH0zaXdLbS", "0900000011", "bf06f891-9755-48c0-85f6-c045a583b356", new DateTime(2025, 9, 25, 14, 22, 56, 730, DateTimeKind.Local).AddTicks(192) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Dob", "FullName", "Gender", "PasswordHash", "Phone", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "7ac22c8e-b45e-4edd-91c1-de957434a9df", new DateTime(2025, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateOnly(1988, 1, 1), "User 12", true, "$2a$12$OZ.nDeeumsu8e9YT1Oazv.2elQPYNQjVo9ttap0yhBUXgzJYn/Eki", "0900000012", "ed96422f-33d4-450b-92ed-2ce67d931b98", new DateTime(2025, 9, 25, 14, 22, 57, 559, DateTimeKind.Local).AddTicks(5691) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "7eb08f60-535d-4db6-b5c9-b0216e376f68", "$2a$12$XZS4.rOuiSuadg0rKDro1uRM9gUmIgOljFgQfvRjQ35c2XPeYKcam", "61884762-03c7-4d21-b7f4-5d7b14f47b40", new DateTime(2025, 9, 25, 14, 22, 50, 942, DateTimeKind.Local).AddTicks(3359) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "CreatedAt", "Dob", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "Phone", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "https://picsum.photos/seed/mentee1/200/200", "c313bbc8-627f-4e84-a48b-f448b8bfb15f", new DateTime(2025, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateOnly(1998, 3, 3), "mentee1@example.com", "Mentee One", "MENTEE1@EXAMPLE.COM", "MENTEE1@EXAMPLE.COM", "$2a$12$3B5r.iy9XPHLEDCYXiHuheY5hOpAfw4kUIhUscpoT3Ka3aQyvG6mC", "0900000003", "7c2803cf-e95f-49ac-ae09-ff5c0e2cef3e", new DateTime(2025, 9, 25, 14, 22, 51, 775, DateTimeKind.Local).AddTicks(8485), "mentee1@example.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "CreatedAt", "Dob", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "Phone", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "https://picsum.photos/seed/mentee2/200/200", "7b1560b1-a85a-4a0e-b07d-72c98e2ae997", new DateTime(2025, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateOnly(1997, 4, 4), "mentee2@example.com", "Mentee Two", "MENTEE2@EXAMPLE.COM", "MENTEE2@EXAMPLE.COM", "$2a$12$z36EwdMVqx5f5XBC8O3vLeySQDYWQxuJs4Mw.oBXitkDGJOduzHMe", "0900000004", "a5408749-1023-4060-8d6a-6608b9ced802", new DateTime(2025, 9, 25, 14, 22, 52, 596, DateTimeKind.Local).AddTicks(1339), "mentee2@example.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "CreatedAt", "Dob", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "Phone", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "https://picsum.photos/seed/mentee3/200/200", "2896c3c7-d3c9-43a8-a55b-a1978601b06e", new DateTime(2025, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateOnly(1996, 5, 5), "mentee3@example.com", "Mentee Three", "MENTEE3@EXAMPLE.COM", "MENTEE3@EXAMPLE.COM", "$2a$12$ZWvgH6J18858Ti87Kcl.DuiVS/i6Ic8Etv2W/bmK2bqfQ.p2cKxiS", "0900000005", "35b2b2a7-51bb-4f6c-8ac0-143cd0f3e039", new DateTime(2025, 9, 25, 14, 22, 53, 202, DateTimeKind.Local).AddTicks(9258), "mentee3@example.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Dob", "FullName", "Gender", "PasswordHash", "Phone", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "86c11a9b-d869-40eb-9f4e-193149043695", new DateTime(2025, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateOnly(1994, 1, 1), "User 6", true, "$2a$12$KNw7jSECUcZoWAgQwKpzzOYyDFqmbHAeEBDSeSQBnQR2cdY.lgt6C", "0900000006", "eba14c16-3a3b-4c53-ae56-cda368503c71", new DateTime(2025, 9, 25, 14, 22, 53, 768, DateTimeKind.Local).AddTicks(1585) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Dob", "FullName", "Gender", "PasswordHash", "Phone", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "2547d8ca-1502-49e7-babf-cb7b2a2c58c6", new DateTime(2025, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateOnly(1993, 1, 1), "User 7", false, "$2a$12$FhIUkCN8LVxMpQznEF/0xO5zCtd.BVcqJweU3z7599hj23cqnyP4y", "0900000007", "048e7842-73ca-4c2c-b14a-7dad27f27499", new DateTime(2025, 9, 25, 14, 22, 54, 221, DateTimeKind.Local).AddTicks(6967) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Dob", "FullName", "Gender", "PasswordHash", "Phone", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "495bb50d-9ab0-4d80-b63b-e9be55ae669c", new DateTime(2025, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateOnly(1992, 1, 1), "User 8", true, "$2a$12$2ESvp3K0vpx1B4b25WmPwuf.oVupVUDswOufrSVGqhZaqmnw3IPdC", "0900000008", "bab6b207-e326-4df8-8094-4feb1310a936", new DateTime(2025, 9, 25, 14, 22, 54, 729, DateTimeKind.Local).AddTicks(2195) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Dob", "FullName", "Gender", "PasswordHash", "Phone", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "800f799a-2c4d-421f-b35b-ee2316430b9d", new DateTime(2025, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateOnly(1991, 1, 1), "User 9", false, "$2a$12$gtlIamWYmzUVMl9fY4J/keOyiJXSeqImLd1HKHCbjho9os.kTW.nS", "0900000009", "10cb7948-876d-4408-8bf8-6523c5315de8", new DateTime(2025, 9, 25, 14, 22, 55, 272, DateTimeKind.Local).AddTicks(1364) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "AvatarUrl", "ConcurrencyStamp", "CreatedAt", "DeletedAt", "Dob", "Email", "EmailConfirmed", "FullName", "Gender", "IsActived", "IsDeleted", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "Phone", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdatedAt", "UserName" },
                values: new object[,]
                {
                    { "13", 0, "https://picsum.photos/seed/13/200/200", "51ba0cf8-356a-4f74-8b01-2cd057fe2baa", new DateTime(2025, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(1987, 1, 1), "user13@example.com", true, "User 13", false, true, false, false, null, "USER13@EXAMPLE.COM", "USER13@EXAMPLE.COM", "$2a$12$4rU5FUaEzZgAqBgFY5gnb.Kl05H.wsBIRQfHIjpYzOwYAA8ku/g.u", "0900000013", null, false, "b63a7473-9851-427c-a6de-4093c6d2b3d4", false, new DateTime(2025, 9, 25, 14, 22, 58, 397, DateTimeKind.Local).AddTicks(4541), "user13@example.com" },
                    { "14", 0, "https://picsum.photos/seed/14/200/200", "00a37723-0aa7-4bdc-ac10-c640fa378326", new DateTime(2025, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(1986, 1, 1), "user14@example.com", true, "User 14", true, true, false, false, null, "USER14@EXAMPLE.COM", "USER14@EXAMPLE.COM", "$2a$12$AZV4HETIVK3AAF7H75SSIOfNQpr8x.U.YDD70AIg.qtagRSHvVsaC", "0900000014", null, false, "8492bcfb-d8a5-4a16-9a1b-6377437aa254", false, new DateTime(2025, 9, 25, 14, 22, 59, 192, DateTimeKind.Local).AddTicks(5635), "user14@example.com" },
                    { "15", 0, "https://picsum.photos/seed/15/200/200", "19f062ed-ba9f-4c28-bc57-1317e3c52f31", new DateTime(2025, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(1985, 1, 1), "user15@example.com", true, "User 15", false, true, false, false, null, "USER15@EXAMPLE.COM", "USER15@EXAMPLE.COM", "$2a$12$tjCSbOMU8U0KnbZsiA6gYOdD8D6KykCtcDn0F0XTBGhFfCMKvQhOq", "0900000015", null, false, "03be11e0-7b09-40ef-b45a-b0d0847b8456", false, new DateTime(2025, 9, 25, 14, 22, 59, 985, DateTimeKind.Local).AddTicks(3353), "user15@example.com" },
                    { "16", 0, "https://picsum.photos/seed/16/200/200", "1e25c7df-3844-4a2b-bcd5-c662c4cef5dc", new DateTime(2025, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(1984, 1, 1), "user16@example.com", true, "User 16", true, true, false, false, null, "USER16@EXAMPLE.COM", "USER16@EXAMPLE.COM", "$2a$12$aVOyGfiUS/07a3QZ8kMU8ef4xLHIROhFKGSlwmuWTfG23BJj.jZbW", "0900000016", null, false, "96e14148-8eab-4730-b203-9260fb1dc831", false, new DateTime(2025, 9, 25, 14, 23, 0, 816, DateTimeKind.Local).AddTicks(2435), "user16@example.com" },
                    { "17", 0, "https://picsum.photos/seed/17/200/200", "8c9b0cd1-05f9-4931-8a69-fc2fab20893c", new DateTime(2025, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(1983, 1, 1), "user17@example.com", true, "User 17", false, true, false, false, null, "USER17@EXAMPLE.COM", "USER17@EXAMPLE.COM", "$2a$12$is7bd9VHfIOLLzQHb7FgDeVRYsds13bRZgpEnPlaD6PiPKca94H2m", "0900000017", null, false, "80730248-2de9-451d-9656-227b6147fcfd", false, new DateTime(2025, 9, 25, 14, 23, 1, 609, DateTimeKind.Local).AddTicks(1115), "user17@example.com" },
                    { "18", 0, "https://picsum.photos/seed/18/200/200", "e0cbee48-afec-4fcd-861d-6c3a5d21872c", new DateTime(2025, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(1982, 1, 1), "user18@example.com", true, "User 18", true, true, false, false, null, "USER18@EXAMPLE.COM", "USER18@EXAMPLE.COM", "$2a$12$5V1d.h2c2/CFJ8c3NhzL4.2RdCjMojsZFmevmg7mI6av8KpqcpOgK", "0900000018", null, false, "242bdf65-343d-47a0-8869-7f2c696d8860", false, new DateTime(2025, 9, 25, 14, 23, 2, 347, DateTimeKind.Local).AddTicks(6235), "user18@example.com" },
                    { "19", 0, "https://picsum.photos/seed/19/200/200", "2596fb07-02a0-4e30-83cd-808673374c0c", new DateTime(2025, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(1981, 1, 1), "user19@example.com", true, "User 19", false, true, false, false, null, "USER19@EXAMPLE.COM", "USER19@EXAMPLE.COM", "$2a$12$ftBTYVfgL.W5EGTgwSUMQe2dvdmZY8ef5e9SRZ9qx/fTKfRnFpyeS", "0900000019", null, false, "76cc7b27-7c92-4388-9790-743d4c28b636", false, new DateTime(2025, 9, 25, 14, 23, 3, 152, DateTimeKind.Local).AddTicks(8412), "user19@example.com" },
                    { "20", 0, "https://picsum.photos/seed/20/200/200", "37831653-c30f-4fe1-92ec-c1ae19f94823", new DateTime(2025, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(1980, 1, 1), "user20@example.com", true, "User 20", true, true, false, false, null, "USER20@EXAMPLE.COM", "USER20@EXAMPLE.COM", "$2a$12$8oMt26Qho0KWuz0yWsIsWuVpzBp821gLJasLSi2bnTVPkRLP3svWS", "0900000020", null, false, "5504c09c-6dc1-41f6-b6ba-26b5077c73b9", false, new DateTime(2025, 9, 25, 14, 23, 3, 933, DateTimeKind.Local).AddTicks(9740), "user20@example.com" },
                    { "21", 0, "https://picsum.photos/seed/21/200/200", "d4eee14f-f329-403d-8ee4-e22c489b7301", new DateTime(2025, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(1979, 1, 1), "user21@example.com", true, "User 21", false, true, false, false, null, "USER21@EXAMPLE.COM", "USER21@EXAMPLE.COM", "$2a$12$KWsGFBqw4T/TxC.i/XLM1uyPpVe2N2KZm7oWS4N0U5srj/cyOIuPm", "0900000021", null, false, "528d521b-2932-4490-b8e4-1bc5c06e7d54", false, new DateTime(2025, 9, 25, 14, 23, 4, 711, DateTimeKind.Local).AddTicks(8045), "user21@example.com" },
                    { "22", 0, "https://picsum.photos/seed/22/200/200", "6700fee4-d06d-409b-aab6-01f80dec7a14", new DateTime(2025, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(1978, 1, 1), "user22@example.com", true, "User 22", true, true, false, false, null, "USER22@EXAMPLE.COM", "USER22@EXAMPLE.COM", "$2a$12$CtKTizLk51XmgmvV82qVQ.RR/lRPe9L3B8Av5sot3sDUbqxOteB7O", "0900000022", null, false, "395e4b87-7bb0-4bc1-b6d2-cf09413e6e00", false, new DateTime(2025, 9, 25, 14, 23, 5, 379, DateTimeKind.Local).AddTicks(2951), "user22@example.com" },
                    { "23", 0, "https://picsum.photos/seed/23/200/200", "effb4707-14fc-4ab2-8b43-28035cffe85e", new DateTime(2025, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(1977, 1, 1), "user23@example.com", true, "User 23", false, true, false, false, null, "USER23@EXAMPLE.COM", "USER23@EXAMPLE.COM", "$2a$12$YYJfLiHtZXG1f2bfcCeQ/.PFLNyqvStSVs16j5rr2Nx2JyPGRYVym", "0900000023", null, false, "805b5e85-64d5-4443-bd69-2daaa83fc187", false, new DateTime(2025, 9, 25, 14, 23, 6, 89, DateTimeKind.Local).AddTicks(1525), "user23@example.com" },
                    { "24", 0, "https://picsum.photos/seed/24/200/200", "d636b756-607b-487c-8bd0-aaa516a2323a", new DateTime(2025, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(1976, 1, 1), "user24@example.com", true, "User 24", true, true, false, false, null, "USER24@EXAMPLE.COM", "USER24@EXAMPLE.COM", "$2a$12$nf7c4OAaaQfXlCx56RWquuh3BGC4zftbGl8XVe6HAT9qCZIQvQ0nG", "0900000024", null, false, "a3f6845c-2c22-49a8-8bc4-4986a13dfba6", false, new DateTime(2025, 9, 25, 14, 23, 6, 729, DateTimeKind.Local).AddTicks(4837), "user24@example.com" },
                    { "25", 0, "https://picsum.photos/seed/25/200/200", "ca0151fc-e2be-48b7-a4d7-07244ad37ef8", new DateTime(2025, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(1975, 1, 1), "user25@example.com", true, "User 25", false, true, false, false, null, "USER25@EXAMPLE.COM", "USER25@EXAMPLE.COM", "$2a$12$U9hlXLh10JfzM4xvDtw1jOzFLA4mfsjMr6N8rHm9Tu8Jum/5EN.2e", "0900000025", null, false, "4a5cfca3-3840-436c-be6b-7c8b35ae615b", false, new DateTime(2025, 9, 25, 14, 23, 7, 368, DateTimeKind.Local).AddTicks(5067), "user25@example.com" },
                    { "26", 0, "https://picsum.photos/seed/26/200/200", "67a5d238-2d03-47f4-b75e-f5458b8131b5", new DateTime(2025, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(1974, 1, 1), "user26@example.com", true, "User 26", true, true, false, false, null, "USER26@EXAMPLE.COM", "USER26@EXAMPLE.COM", "$2a$12$DnnLwtpaiDxoO5X4Esj.4OaUzdQQUXhderm6ce5EQAiQpk4l/BZPe", "0900000026", null, false, "d681d886-237c-413a-bf8e-56358d79e6e1", false, new DateTime(2025, 9, 25, 14, 23, 8, 144, DateTimeKind.Local).AddTicks(4866), "user26@example.com" },
                    { "27", 0, "https://picsum.photos/seed/27/200/200", "c2c01aae-9713-4c0e-bba3-4fb929e63dd0", new DateTime(2025, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(1973, 1, 1), "user27@example.com", true, "User 27", false, true, false, false, null, "USER27@EXAMPLE.COM", "USER27@EXAMPLE.COM", "$2a$12$DnAVLuqb8pMAXOoRrby3YuAgvTzsEimXhgDeKUvfFEBj5IBYS6YPG", "0900000027", null, false, "80a28b96-ae97-4c2b-ba46-cc2bc561b688", false, new DateTime(2025, 9, 25, 14, 23, 8, 862, DateTimeKind.Local).AddTicks(1106), "user27@example.com" },
                    { "28", 0, "https://picsum.photos/seed/28/200/200", "a57e234c-145e-4c23-a600-049798a18fdf", new DateTime(2025, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(1972, 1, 1), "user28@example.com", true, "User 28", true, true, false, false, null, "USER28@EXAMPLE.COM", "USER28@EXAMPLE.COM", "$2a$12$8jxAbNQPFrtFhdiE5sNpAO3HECvM2kDzVjihrGxeXEn7b8tVAnZ3G", "0900000028", null, false, "0295b855-ef8e-4051-8d96-847154c7f6a8", false, new DateTime(2025, 9, 25, 14, 23, 9, 649, DateTimeKind.Local).AddTicks(1222), "user28@example.com" },
                    { "29", 0, "https://picsum.photos/seed/29/200/200", "dafdcbb9-0dc2-471f-8e97-3436b2aee7b2", new DateTime(2025, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(1971, 1, 1), "user29@example.com", true, "User 29", false, true, false, false, null, "USER29@EXAMPLE.COM", "USER29@EXAMPLE.COM", "$2a$12$iOD1UQCLx4Yzw8yYPZ1m/O2PE3ZfjgvgJQTAb26PkS2x2zgPnzO9a", "0900000029", null, false, "ef44e281-37b4-4e3f-a2ac-abb621ad08da", false, new DateTime(2025, 9, 25, 14, 23, 10, 349, DateTimeKind.Local).AddTicks(9338), "user29@example.com" },
                    { "30", 0, "https://picsum.photos/seed/30/200/200", "e4d51009-3cd4-4b02-9845-1e446a6e8391", new DateTime(2025, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(1970, 1, 1), "user30@example.com", true, "User 30", true, true, false, false, null, "USER30@EXAMPLE.COM", "USER30@EXAMPLE.COM", "$2a$12$U0x8efYCjIwNfLiDZbyZIuHcN7oh4LXp1ckPqQGGZU8Z4UruX7fiu", "0900000030", null, false, "d6e77219-7be0-446b-8524-08caa452ef5f", false, new DateTime(2025, 9, 25, 14, 23, 10, 939, DateTimeKind.Local).AddTicks(3849), "user30@example.com" },
                    { "31", 0, "https://picsum.photos/seed/31/200/200", "b19cb6b1-269f-4bf5-9ca2-178371ccd8d5", new DateTime(2025, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(1969, 1, 1), "user31@example.com", true, "User 31", false, true, false, false, null, "USER31@EXAMPLE.COM", "USER31@EXAMPLE.COM", "$2a$12$VKIj.D10xM4987ijqS0/L.wIXExKvBdKbz7jQPtlgfv4yZcAUUjRi", "0900000031", null, false, "fcc84fd7-cc05-4aee-a0df-c988d36a69c5", false, new DateTime(2025, 9, 25, 14, 23, 11, 654, DateTimeKind.Local).AddTicks(8999), "user31@example.com" },
                    { "32", 0, "https://picsum.photos/seed/32/200/200", "d5eb869b-a6c9-4f91-89c4-b2140518b801", new DateTime(2025, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(1968, 1, 1), "user32@example.com", true, "User 32", true, true, false, false, null, "USER32@EXAMPLE.COM", "USER32@EXAMPLE.COM", "$2a$12$2A/uWi9ruCGAa45K9UwJSOndfe9dyXvvuv6mv/QIjc/FHJ9ngl8rW", "0900000032", null, false, "ee0ed3cb-afce-4ca8-8ae3-d333a821098c", false, new DateTime(2025, 9, 25, 14, 23, 12, 191, DateTimeKind.Local).AddTicks(6839), "user32@example.com" },
                    { "33", 0, "https://picsum.photos/seed/33/200/200", "c6e989c2-b7c1-4ff8-b287-8ba2f8a73ccc", new DateTime(2025, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(1967, 1, 1), "user33@example.com", true, "User 33", false, true, false, false, null, "USER33@EXAMPLE.COM", "USER33@EXAMPLE.COM", "$2a$12$QDKwkr/4G7cTT8fRMHq4BuLwFAn4eetP0n..L7yyQ91zKRQLeWmiq", "0900000033", null, false, "73bff46b-2169-4172-8c3f-069153ffd117", false, new DateTime(2025, 9, 25, 14, 23, 12, 705, DateTimeKind.Local).AddTicks(4915), "user33@example.com" },
                    { "34", 0, "https://picsum.photos/seed/34/200/200", "809c80f8-cdb5-4bc6-9d48-090868111719", new DateTime(2025, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(1966, 1, 1), "user34@example.com", true, "User 34", true, true, false, false, null, "USER34@EXAMPLE.COM", "USER34@EXAMPLE.COM", "$2a$12$uYWA4EwHAOCksdrQgz3keu64bdfa93VllGkN16vyLRlzQ2HFrLacu", "0900000034", null, false, "66d57eb4-fa58-4032-b045-551c5765ede5", false, new DateTime(2025, 9, 25, 14, 23, 13, 183, DateTimeKind.Local).AddTicks(5305), "user34@example.com" },
                    { "35", 0, "https://picsum.photos/seed/35/200/200", "002cd325-2d8c-4fb8-b6c8-cfbc9893e9e5", new DateTime(2025, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(1965, 1, 1), "user35@example.com", true, "User 35", false, true, false, false, null, "USER35@EXAMPLE.COM", "USER35@EXAMPLE.COM", "$2a$12$etCb98NRSKm8ZcARDOYIJu9QcHsnmqTwGZj83Y0L19DY2LTdLBW.e", "0900000035", null, false, "ac286ac4-070f-4bad-882b-fe87db467cd7", false, new DateTime(2025, 9, 25, 14, 23, 13, 773, DateTimeKind.Local).AddTicks(8632), "user35@example.com" },
                    { "36", 0, "https://picsum.photos/seed/36/200/200", "0ccae1e7-9a16-4b14-b0fa-baff63c38efd", new DateTime(2025, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(1964, 1, 1), "user36@example.com", true, "User 36", true, true, false, false, null, "USER36@EXAMPLE.COM", "USER36@EXAMPLE.COM", "$2a$12$z2FSqlFIst9Cx88MwxVh4OP3ULDbpWRusCe5tZEZGobxdAoYY669q", "0900000036", null, false, "742b4d83-f9f5-4d88-ba0c-6547a2a96941", false, new DateTime(2025, 9, 25, 14, 23, 14, 289, DateTimeKind.Local).AddTicks(8753), "user36@example.com" },
                    { "37", 0, "https://picsum.photos/seed/37/200/200", "55fc2e1a-3121-4183-b051-393b6edd4cd1", new DateTime(2025, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(1963, 1, 1), "user37@example.com", true, "User 37", false, true, false, false, null, "USER37@EXAMPLE.COM", "USER37@EXAMPLE.COM", "$2a$12$PYUPOPVzVA9k1BZpiHpjeOyqPOc6vli7XzhTRRYKBO2RJ/hNFWPZ.", "0900000037", null, false, "026a3c24-712a-4200-867d-394be28fa1b7", false, new DateTime(2025, 9, 25, 14, 23, 14, 789, DateTimeKind.Local).AddTicks(6814), "user37@example.com" },
                    { "38", 0, "https://picsum.photos/seed/38/200/200", "1d18182a-0039-431a-8810-7bd4f78f6d09", new DateTime(2025, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(1962, 1, 1), "user38@example.com", true, "User 38", true, true, false, false, null, "USER38@EXAMPLE.COM", "USER38@EXAMPLE.COM", "$2a$12$hDxXVTKKVoukga/N4rbsTu3mXFql37mc2YAizoEWpfPUYfghduogS", "0900000038", null, false, "1ad76ff5-5a57-4afe-97d9-07a927bad05a", false, new DateTime(2025, 9, 25, 14, 23, 15, 492, DateTimeKind.Local).AddTicks(8841), "user38@example.com" },
                    { "39", 0, "https://picsum.photos/seed/39/200/200", "58472670-5582-4fab-8ddd-e6294a65a3d5", new DateTime(2025, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(1961, 1, 1), "user39@example.com", true, "User 39", false, true, false, false, null, "USER39@EXAMPLE.COM", "USER39@EXAMPLE.COM", "$2a$12$xPvB9tc79J0R69hnaOk3YuiWxqzPjfZCcB/Uwr3z3Mx0n9DIlUmUO", "0900000039", null, false, "b2de6e70-06a8-495a-b8c4-0a6a77bb7116", false, new DateTime(2025, 9, 25, 14, 23, 16, 150, DateTimeKind.Local).AddTicks(2807), "user39@example.com" },
                    { "40", 0, "https://picsum.photos/seed/40/200/200", "15e68091-4e19-4562-bcaf-031be1117306", new DateTime(2025, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(1960, 1, 1), "user40@example.com", true, "User 40", true, true, false, false, null, "USER40@EXAMPLE.COM", "USER40@EXAMPLE.COM", "$2a$12$RNXtzGQYG85qn015np4jKOvn3YY.eAKZZZCu2yNbWdppOwQ4DscAy", "0900000040", null, false, "73f540f1-4cd7-4452-bd0b-df338cfbabe0", false, new DateTime(2025, 9, 25, 14, 23, 16, 891, DateTimeKind.Local).AddTicks(6930), "user40@example.com" },
                    { "41", 0, "https://picsum.photos/seed/41/200/200", "de3bb3a1-211a-4a1a-839a-529152b093fa", new DateTime(2025, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(1959, 1, 1), "user41@example.com", true, "User 41", false, true, false, false, null, "USER41@EXAMPLE.COM", "USER41@EXAMPLE.COM", "$2a$12$IpKVyzGCMnsU2H2Fk1h1luRf/nqrWy9XYV/Nts.SiySHn5KQrQi7i", "0900000041", null, false, "5313b253-3dac-4c65-bf56-3e96b251593a", false, new DateTime(2025, 9, 25, 14, 23, 17, 457, DateTimeKind.Local).AddTicks(2408), "user41@example.com" },
                    { "42", 0, "https://picsum.photos/seed/42/200/200", "2a18ac42-4a68-46a3-8474-fc0b10ea73ec", new DateTime(2025, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(1958, 1, 1), "user42@example.com", true, "User 42", true, true, false, false, null, "USER42@EXAMPLE.COM", "USER42@EXAMPLE.COM", "$2a$12$4ftQpPIYgwR..vEfDqeTse6dm8evsAMmje4Kcu5//Q2tvejr8ljci", "0900000042", null, false, "a54e3bfc-5674-4565-8c72-bb39da7e13e0", false, new DateTime(2025, 9, 25, 14, 23, 18, 30, DateTimeKind.Local).AddTicks(976), "user42@example.com" },
                    { "43", 0, "https://picsum.photos/seed/43/200/200", "70c850f6-4a90-40c0-bace-6c815a0f9478", new DateTime(2025, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(1957, 1, 1), "user43@example.com", true, "User 43", false, true, false, false, null, "USER43@EXAMPLE.COM", "USER43@EXAMPLE.COM", "$2a$12$0/kdJQMxhGzmOcscml.rS.rzY7Fa3eLTvyIewzuc1aImqb7BobZVG", "0900000043", null, false, "3ddf86ae-88a5-4823-8841-8b89b92fb434", false, new DateTime(2025, 9, 25, 14, 23, 18, 595, DateTimeKind.Local).AddTicks(2115), "user43@example.com" },
                    { "44", 0, "https://picsum.photos/seed/44/200/200", "930ad58e-3ebd-466f-95c1-4ce4150d8368", new DateTime(2025, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(1956, 1, 1), "user44@example.com", true, "User 44", true, true, false, false, null, "USER44@EXAMPLE.COM", "USER44@EXAMPLE.COM", "$2a$12$0amethMy4E5nf5tWUrYc.Oq/T8pkPlgK0gisZabntmWxZWsmm4JSK", "0900000044", null, false, "3c089392-0a90-4cc5-b4a8-7d848792224f", false, new DateTime(2025, 9, 25, 14, 23, 19, 202, DateTimeKind.Local).AddTicks(4329), "user44@example.com" },
                    { "45", 0, "https://picsum.photos/seed/45/200/200", "147711c5-ae6e-4ad2-b20a-dc9f3190d66e", new DateTime(2025, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(1955, 1, 1), "user45@example.com", true, "User 45", false, true, false, false, null, "USER45@EXAMPLE.COM", "USER45@EXAMPLE.COM", "$2a$12$3/kBAHzqI05kCugGtR.KzO5462S0Y/5BYgyr1RgT2sUUMNJG33iBC", "0900000045", null, false, "a9dad905-77db-4143-af38-cd587c8ae066", false, new DateTime(2025, 9, 25, 14, 23, 19, 799, DateTimeKind.Local).AddTicks(8451), "user45@example.com" },
                    { "46", 0, "https://picsum.photos/seed/46/200/200", "6742eefa-68da-4675-88c1-78b108ebab57", new DateTime(2025, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(1954, 1, 1), "user46@example.com", true, "User 46", true, true, false, false, null, "USER46@EXAMPLE.COM", "USER46@EXAMPLE.COM", "$2a$12$6n3ZWfLxeDqv7PG2xeQKF.R3IOGzi66s64HBdGbFn0hiFEeDTQ4eK", "0900000046", null, false, "72b01883-e0c6-4e54-abe3-070e9e5e2db1", false, new DateTime(2025, 9, 25, 14, 23, 20, 309, DateTimeKind.Local).AddTicks(9030), "user46@example.com" },
                    { "47", 0, "https://picsum.photos/seed/47/200/200", "227b7fec-2fe2-4854-8977-19aabd4d2a74", new DateTime(2025, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(1953, 1, 1), "user47@example.com", true, "User 47", false, true, false, false, null, "USER47@EXAMPLE.COM", "USER47@EXAMPLE.COM", "$2a$12$v1Cd9txSLEbxwQsNdx8PwuF.CWq3xEr10HDIcYum6DntHJ0MBZ/bW", "0900000047", null, false, "9dd66621-cf7c-4f50-9cc2-55216b10679b", false, new DateTime(2025, 9, 25, 14, 23, 20, 782, DateTimeKind.Local).AddTicks(1483), "user47@example.com" },
                    { "48", 0, "https://picsum.photos/seed/48/200/200", "1628f75d-a61a-40cb-97f7-98ce34e537ab", new DateTime(2025, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(1952, 1, 1), "user48@example.com", true, "User 48", true, true, false, false, null, "USER48@EXAMPLE.COM", "USER48@EXAMPLE.COM", "$2a$12$pNFX8R/YU/RJ459yHMkXqezTS8eU5KgC1R03HC/a3NjpB25j.vKN6", "0900000048", null, false, "d9ad6d1b-8d2b-4793-ad17-f80d0494b361", false, new DateTime(2025, 9, 25, 14, 23, 21, 60, DateTimeKind.Local).AddTicks(1651), "user48@example.com" },
                    { "49", 0, "https://picsum.photos/seed/49/200/200", "45c93495-0b09-4d4c-804d-e28d4233402e", new DateTime(2025, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(1951, 1, 1), "user49@example.com", true, "User 49", false, true, false, false, null, "USER49@EXAMPLE.COM", "USER49@EXAMPLE.COM", "$2a$12$liuVPDttPK9C4hA.GGP8OuleLPJEFoaKClCMKmmhzmihZU1CP1fp.", "0900000049", null, false, "2b24d5e4-61c1-4cf1-bc76-4399896c3e7d", false, new DateTime(2025, 9, 25, 14, 23, 21, 336, DateTimeKind.Local).AddTicks(215), "user49@example.com" },
                    { "50", 0, "https://picsum.photos/seed/50/200/200", "d4a61429-28ad-4a39-b257-1ad958b86954", new DateTime(2025, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(1950, 1, 1), "user50@example.com", true, "User 50", true, true, false, false, null, "USER50@EXAMPLE.COM", "USER50@EXAMPLE.COM", "$2a$12$EjryErbvv7B1/kYkwOU4b.6/EUj.pDEN2O1pf3kNdH6Gy9KzxH8n2", "0900000050", null, false, "4ac8fc10-a33f-4d30-a372-89e53e9f8acc", false, new DateTime(2025, 9, 25, 14, 23, 21, 610, DateTimeKind.Local).AddTicks(8061), "user50@example.com" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "mentee-role", "10" },
                    { "mentee-role", "11" },
                    { "mentee-role", "12" },
                    { "mentee-role", "13" },
                    { "mentee-role", "14" },
                    { "mentee-role", "15" },
                    { "mentee-role", "16" },
                    { "mentee-role", "17" },
                    { "mentee-role", "18" },
                    { "mentee-role", "19" },
                    { "mentee-role", "20" },
                    { "mentee-role", "21" },
                    { "mentee-role", "22" },
                    { "mentee-role", "23" },
                    { "mentee-role", "24" },
                    { "mentee-role", "25" },
                    { "mentee-role", "26" },
                    { "mentee-role", "27" },
                    { "mentee-role", "28" },
                    { "mentee-role", "29" },
                    { "mentee-role", "3" },
                    { "mentee-role", "30" },
                    { "mentee-role", "31" },
                    { "mentee-role", "32" },
                    { "mentee-role", "33" },
                    { "mentee-role", "34" },
                    { "mentee-role", "35" },
                    { "mentee-role", "36" },
                    { "mentee-role", "37" },
                    { "mentee-role", "38" },
                    { "mentee-role", "39" },
                    { "mentee-role", "4" },
                    { "mentee-role", "40" },
                    { "mentee-role", "41" },
                    { "mentee-role", "42" },
                    { "mentee-role", "43" },
                    { "mentee-role", "44" },
                    { "mentee-role", "45" },
                    { "mentee-role", "46" },
                    { "mentee-role", "47" },
                    { "mentee-role", "48" },
                    { "mentee-role", "49" },
                    { "mentee-role", "5" },
                    { "mentee-role", "50" },
                    { "mentee-role", "6" },
                    { "mentee-role", "7" },
                    { "mentee-role", "8" },
                    { "mentee-role", "9" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "admin-role", "1" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "mentee-role", "10" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "mentee-role", "11" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "mentee-role", "12" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "mentee-role", "13" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "mentee-role", "14" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "mentee-role", "15" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "mentee-role", "16" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "mentee-role", "17" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "mentee-role", "18" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "mentee-role", "19" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "mentor-role", "2" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "mentee-role", "20" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "mentee-role", "21" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "mentee-role", "22" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "mentee-role", "23" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "mentee-role", "24" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "mentee-role", "25" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "mentee-role", "26" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "mentee-role", "27" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "mentee-role", "28" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "mentee-role", "29" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "mentee-role", "3" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "mentee-role", "30" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "mentee-role", "31" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "mentee-role", "32" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "mentee-role", "33" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "mentee-role", "34" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "mentee-role", "35" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "mentee-role", "36" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "mentee-role", "37" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "mentee-role", "38" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "mentee-role", "39" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "mentee-role", "4" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "mentee-role", "40" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "mentee-role", "41" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "mentee-role", "42" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "mentee-role", "43" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "mentee-role", "44" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "mentee-role", "45" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "mentee-role", "46" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "mentee-role", "47" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "mentee-role", "48" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "mentee-role", "49" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "mentee-role", "5" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "mentee-role", "50" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "mentee-role", "6" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "mentee-role", "7" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "mentee-role", "8" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "mentee-role", "9" });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "mentee-role");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "13");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "14");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "15");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "16");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "17");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "18");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "19");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "20");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "21");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "22");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "23");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "24");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "25");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "26");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "27");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "28");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "29");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "30");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "31");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "32");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "33");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "34");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "35");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "36");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "37");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "38");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "39");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "40");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "41");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "42");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "43");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "44");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "45");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "46");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "47");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "48");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "49");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "50");

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 1L,
                column: "UpdatedAt",
                value: new DateTime(2025, 9, 20, 21, 19, 34, 741, DateTimeKind.Local).AddTicks(5380));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 2L,
                column: "UpdatedAt",
                value: new DateTime(2025, 9, 20, 21, 19, 34, 741, DateTimeKind.Local).AddTicks(5402));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 3L,
                column: "UpdatedAt",
                value: new DateTime(2025, 9, 20, 21, 19, 34, 741, DateTimeKind.Local).AddTicks(5406));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 4L,
                column: "UpdatedAt",
                value: new DateTime(2025, 9, 20, 21, 19, 34, 741, DateTimeKind.Local).AddTicks(5409));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 5L,
                column: "UpdatedAt",
                value: new DateTime(2025, 9, 20, 21, 19, 34, 741, DateTimeKind.Local).AddTicks(5411));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 6L,
                column: "UpdatedAt",
                value: new DateTime(2025, 9, 20, 21, 19, 34, 741, DateTimeKind.Local).AddTicks(5415));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 7L,
                column: "UpdatedAt",
                value: new DateTime(2025, 9, 20, 21, 19, 34, 741, DateTimeKind.Local).AddTicks(5417));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 8L,
                column: "UpdatedAt",
                value: new DateTime(2025, 9, 20, 21, 19, 34, 741, DateTimeKind.Local).AddTicks(5419));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 9L,
                column: "UpdatedAt",
                value: new DateTime(2025, 9, 20, 21, 19, 34, 741, DateTimeKind.Local).AddTicks(5421));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 10L,
                column: "UpdatedAt",
                value: new DateTime(2025, 9, 20, 21, 19, 34, 741, DateTimeKind.Local).AddTicks(5424));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 11L,
                column: "UpdatedAt",
                value: new DateTime(2025, 9, 20, 21, 19, 34, 741, DateTimeKind.Local).AddTicks(5426));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 12L,
                column: "UpdatedAt",
                value: new DateTime(2025, 9, 20, 21, 19, 34, 741, DateTimeKind.Local).AddTicks(5427));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 13L,
                column: "UpdatedAt",
                value: new DateTime(2025, 9, 20, 21, 19, 34, 741, DateTimeKind.Local).AddTicks(5429));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 14L,
                column: "UpdatedAt",
                value: new DateTime(2025, 9, 20, 21, 19, 34, 741, DateTimeKind.Local).AddTicks(5485));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 15L,
                column: "UpdatedAt",
                value: new DateTime(2025, 9, 20, 21, 19, 34, 741, DateTimeKind.Local).AddTicks(5486));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 16L,
                column: "UpdatedAt",
                value: new DateTime(2025, 9, 20, 21, 19, 34, 741, DateTimeKind.Local).AddTicks(5488));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 17L,
                column: "UpdatedAt",
                value: new DateTime(2025, 9, 20, 21, 19, 34, 741, DateTimeKind.Local).AddTicks(5490));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 18L,
                column: "UpdatedAt",
                value: new DateTime(2025, 9, 20, 21, 19, 34, 741, DateTimeKind.Local).AddTicks(5493));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 19L,
                column: "UpdatedAt",
                value: new DateTime(2025, 9, 20, 21, 19, 34, 741, DateTimeKind.Local).AddTicks(5494));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 20L,
                column: "UpdatedAt",
                value: new DateTime(2025, 9, 20, 21, 19, 34, 741, DateTimeKind.Local).AddTicks(5496));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 21L,
                column: "UpdatedAt",
                value: new DateTime(2025, 9, 20, 21, 19, 34, 741, DateTimeKind.Local).AddTicks(5498));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 22L,
                column: "UpdatedAt",
                value: new DateTime(2025, 9, 20, 21, 19, 34, 741, DateTimeKind.Local).AddTicks(5499));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 23L,
                column: "UpdatedAt",
                value: new DateTime(2025, 9, 20, 21, 19, 34, 741, DateTimeKind.Local).AddTicks(5501));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 24L,
                column: "UpdatedAt",
                value: new DateTime(2025, 9, 20, 21, 19, 34, 741, DateTimeKind.Local).AddTicks(5502));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "student-role", null, "Student", "STUDENT" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "24ff7179-5472-49bd-98c7-4ea305c6fc61", "AQAAAAIAAYagAAAAEGc+7apP...==", "963bc9e4-95b5-4281-9cfe-5cdf9cc1d237", new DateTime(2025, 9, 20, 21, 19, 34, 742, DateTimeKind.Local).AddTicks(888) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Dob", "FullName", "Gender", "PasswordHash", "Phone", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "c73466ec-a15d-4e17-b077-0c77857c5147", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateOnly(1999, 9, 9), "User Ten", false, "AQAAAAIAAYagAAAAEGc+7apP...==", "0000000010", "426d52fa-909c-4a8e-9326-c9583fd065c8", new DateTime(2025, 9, 20, 21, 19, 34, 742, DateTimeKind.Local).AddTicks(1182) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Dob", "FullName", "Gender", "PasswordHash", "Phone", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "bae8d433-401e-4562-8616-4cb8d36fa8a5", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateOnly(1991, 1, 11), "User Eleven", true, "AQAAAAIAAYagAAAAEGc+7apP...==", "0000000011", "41089673-5515-440f-83b5-3c70626489b2", new DateTime(2025, 9, 20, 21, 19, 34, 742, DateTimeKind.Local).AddTicks(1206) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Dob", "FullName", "Gender", "PasswordHash", "Phone", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "65723c00-4c0a-4d76-a38d-8d38aee68971", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateOnly(1992, 2, 12), "User Twelve", false, "AQAAAAIAAYagAAAAEGc+7apP...==", "0000000012", "2fa8adca-eeac-4625-8e1e-d87eb01fe991", new DateTime(2025, 9, 20, 21, 19, 34, 742, DateTimeKind.Local).AddTicks(1227) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "09f69620-924b-4d56-9be8-d7a0aeee6186", "AQAAAAIAAYagAAAAEGc+7apP...==", "a92802c6-c5c3-41e0-a860-cfeb7c7232d5", new DateTime(2025, 9, 20, 21, 19, 34, 742, DateTimeKind.Local).AddTicks(940) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "CreatedAt", "Dob", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "Phone", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "https://picsum.photos/seed/3/200/200", "6e2d10b1-b5bb-4ede-bd03-4fe62f377d61", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateOnly(1995, 5, 5), "user3@example.com", "User Three", "USER3@EXAMPLE.COM", "USER3@EXAMPLE.COM", "AQAAAAIAAYagAAAAEGc+7apP...==", "0000000003", "216a9f2b-5225-4be0-9f7d-3f465f814916", new DateTime(2025, 9, 20, 21, 19, 34, 742, DateTimeKind.Local).AddTicks(974), "user3@example.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "CreatedAt", "Dob", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "Phone", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "https://picsum.photos/seed/4/200/200", "530c8eaa-f6d4-4182-b868-43bc6ac3a1e7", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateOnly(1992, 2, 2), "user4@example.com", "User Four", "USER4@EXAMPLE.COM", "USER4@EXAMPLE.COM", "AQAAAAIAAYagAAAAEGc+7apP...==", "0000000004", "61422693-d5e8-4702-b633-87b6b1ebc7fd", new DateTime(2025, 9, 20, 21, 19, 34, 742, DateTimeKind.Local).AddTicks(1048), "user4@example.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "CreatedAt", "Dob", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "Phone", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "https://picsum.photos/seed/5/200/200", "afc770bc-c4de-4fbe-8f95-8e2c274a8b9f", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateOnly(1993, 3, 3), "user5@example.com", "User Five", "USER5@EXAMPLE.COM", "USER5@EXAMPLE.COM", "AQAAAAIAAYagAAAAEGc+7apP...==", "0000000005", "842f0b88-6c52-4562-a50c-b908d48c614d", new DateTime(2025, 9, 20, 21, 19, 34, 742, DateTimeKind.Local).AddTicks(1070), "user5@example.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Dob", "FullName", "Gender", "PasswordHash", "Phone", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "ce7d2998-dccb-4c32-ace4-b6366cd31b51", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateOnly(1994, 4, 4), "User Six", false, "AQAAAAIAAYagAAAAEGc+7apP...==", "0000000006", "e9ff54a5-9b09-4baa-95b6-0b1d8317a08b", new DateTime(2025, 9, 20, 21, 19, 34, 742, DateTimeKind.Local).AddTicks(1095) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Dob", "FullName", "Gender", "PasswordHash", "Phone", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "81da1e18-3bac-4344-acf4-45e63bb5e5be", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateOnly(1996, 6, 6), "User Seven", true, "AQAAAAIAAYagAAAAEGc+7apP...==", "0000000007", "9b7ea821-ed79-4011-be1b-1fb603620794", new DateTime(2025, 9, 20, 21, 19, 34, 742, DateTimeKind.Local).AddTicks(1116) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Dob", "FullName", "Gender", "PasswordHash", "Phone", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "65eaeb26-fdf5-4d0f-9734-51360edb06ea", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateOnly(1997, 7, 7), "User Eight", false, "AQAAAAIAAYagAAAAEGc+7apP...==", "0000000008", "a004c34e-f553-4e16-b5c8-7f863082a9a7", new DateTime(2025, 9, 20, 21, 19, 34, 742, DateTimeKind.Local).AddTicks(1141) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Dob", "FullName", "Gender", "PasswordHash", "Phone", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "86a3e24a-b700-4ac2-8c9f-b3df3db9713c", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateOnly(1998, 8, 8), "User Nine", true, "AQAAAAIAAYagAAAAEGc+7apP...==", "0000000009", "6cf7b012-0826-40c2-9bb6-ff9960dbc8f6", new DateTime(2025, 9, 20, 21, 19, 34, 742, DateTimeKind.Local).AddTicks(1162) });
        }
    }
}
