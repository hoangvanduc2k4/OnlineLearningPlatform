using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineLearningPlatform.Data.Migrations
{
    /// <inheritdoc />
    public partial class FixCourseColumnNames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Users_AdminId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Users_MentorId",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_AdminId",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_MentorId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "AdminId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "MentorId",
                table: "Courses");

            migrationBuilder.AlterColumn<string>(
                name: "Creator",
                table: "Courses",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Acceptor",
                table: "Courses",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 1L,
                columns: new[] { "Acceptor", "Creator" },
                values: new object[] { "1", "2" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 2L,
                columns: new[] { "Acceptor", "Creator" },
                values: new object[] { "1", "2" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 3L,
                columns: new[] { "Acceptor", "Creator" },
                values: new object[] { "1", "2" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 4L,
                columns: new[] { "Acceptor", "Creator" },
                values: new object[] { "1", "2" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 5L,
                columns: new[] { "Acceptor", "Creator" },
                values: new object[] { "1", "2" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 6L,
                columns: new[] { "Acceptor", "Creator" },
                values: new object[] { "1", "2" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 7L,
                columns: new[] { "Acceptor", "Creator" },
                values: new object[] { "1", "2" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 8L,
                columns: new[] { "Acceptor", "Creator" },
                values: new object[] { "1", "2" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 9L,
                columns: new[] { "Acceptor", "Creator" },
                values: new object[] { "1", "2" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 10L,
                columns: new[] { "Acceptor", "Creator" },
                values: new object[] { "1", "2" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 11L,
                columns: new[] { "Acceptor", "Creator" },
                values: new object[] { "1", "2" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 12L,
                columns: new[] { "Acceptor", "Creator" },
                values: new object[] { "1", "2" });

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 1L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 9, 59, 45, 792, DateTimeKind.Local).AddTicks(9448));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 2L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 9, 59, 45, 792, DateTimeKind.Local).AddTicks(9460));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 3L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 9, 59, 45, 792, DateTimeKind.Local).AddTicks(9463));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 4L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 9, 59, 45, 792, DateTimeKind.Local).AddTicks(9465));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 5L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 9, 59, 45, 792, DateTimeKind.Local).AddTicks(9467));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 6L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 9, 59, 45, 792, DateTimeKind.Local).AddTicks(9470));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 7L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 9, 59, 45, 792, DateTimeKind.Local).AddTicks(9471));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 8L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 9, 59, 45, 792, DateTimeKind.Local).AddTicks(9473));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 9L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 9, 59, 45, 792, DateTimeKind.Local).AddTicks(9474));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 10L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 9, 59, 45, 792, DateTimeKind.Local).AddTicks(9477));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 11L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 9, 59, 45, 792, DateTimeKind.Local).AddTicks(9478));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 12L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 9, 59, 45, 792, DateTimeKind.Local).AddTicks(9480));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 13L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 9, 59, 45, 792, DateTimeKind.Local).AddTicks(9481));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 14L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 9, 59, 45, 792, DateTimeKind.Local).AddTicks(9483));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 15L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 9, 59, 45, 792, DateTimeKind.Local).AddTicks(9484));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 16L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 9, 59, 45, 792, DateTimeKind.Local).AddTicks(9486));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 17L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 9, 59, 45, 792, DateTimeKind.Local).AddTicks(9487));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 18L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 9, 59, 45, 792, DateTimeKind.Local).AddTicks(9490));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 19L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 9, 59, 45, 792, DateTimeKind.Local).AddTicks(9492));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 20L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 9, 59, 45, 792, DateTimeKind.Local).AddTicks(9493));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 21L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 9, 59, 45, 792, DateTimeKind.Local).AddTicks(9495));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 22L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 9, 59, 45, 792, DateTimeKind.Local).AddTicks(9496));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 23L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 9, 59, 45, 792, DateTimeKind.Local).AddTicks(9498));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 24L,
                column: "UpdatedAt",
                value: new DateTime(2025, 10, 18, 9, 59, 45, 792, DateTimeKind.Local).AddTicks(9500));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "ad1ab52e-717a-4d7a-8cc4-56ade882ff19", "AQAAAAIAAYagAAAAEAKsRSQD3714SAOga3rQWLbsoiICBvE72OpkkFMaul2d1XN2NT6nVMfJRAyUoFG0Lw==", "d58c0700-399c-4036-9391-16a24a2d9bdd", new DateTime(2025, 10, 18, 9, 59, 45, 793, DateTimeKind.Local).AddTicks(5146) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "1c22eece-6b84-4530-8776-a0a56fafd928", "AQAAAAIAAYagAAAAECtuRApsoWqdVYx4FUFVgqlDbmgzAOv0Y6VA2hfCNnO8WE9tFMY2ULctpHJeSq0UjQ==", "c2c7598f-9b01-4968-96b2-1a88267edeef", new DateTime(2025, 10, 18, 9, 59, 46, 649, DateTimeKind.Local).AddTicks(2945) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "c94631d9-a87e-4c41-9302-1b6334256837", "AQAAAAIAAYagAAAAEOkg440ir5eWvvHQekiiiAWP8p6600pz2ekUUZUAn9x52R+2ZotnhTLTSAcEiDSy9Q==", "083d7409-88a0-45d2-82e0-07a07588a530", new DateTime(2025, 10, 18, 9, 59, 46, 736, DateTimeKind.Local).AddTicks(9420) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "2b965231-8c7d-4e2a-b406-82e79e193c09", "AQAAAAIAAYagAAAAEEgzHXqu/OGLB33TebTPNpyS7/hmfeHM0Q8RwJNM7ksipyNGroWUDUhCPV8NaRATyg==", "cd697d96-f353-4ba6-89aa-282750fc8748", new DateTime(2025, 10, 18, 9, 59, 46, 831, DateTimeKind.Local).AddTicks(5148) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "724d07ad-e368-4de4-81fb-dea23acd367d", "AQAAAAIAAYagAAAAEIN+mxWtIDaRx7g4MYTmWWWf7hMFzLhGNKjMtMMGcCxbzNHbjM2EGbFvRGnrpTCjMQ==", "5810ed4f-71f1-4417-b072-42899fec8529", new DateTime(2025, 10, 18, 9, 59, 46, 920, DateTimeKind.Local).AddTicks(2704) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "9b580e57-f985-401e-b6c0-2fc889bb0246", "AQAAAAIAAYagAAAAEIx4xlEeapAKHbgco2AKOB0CK+zq8zmbPZiMWK3WwF0zL6COd/FhGdhC9Qtpx0vAPw==", "e0e9fc29-d4f0-48ce-8f7c-40fb17b389fb", new DateTime(2025, 10, 18, 9, 59, 47, 10, DateTimeKind.Local).AddTicks(929) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "53f67301-ed4b-485d-b86a-f0c6a0d864f1", "AQAAAAIAAYagAAAAEAUA9yOnBocKaHTtViAueGw/hXCdAVRjvO0aTDPrg2uAd8nTO2Q7UryTzbn+ImzQrg==", "37e7b8e5-5570-4e4b-a9ce-dce0b05a0421", new DateTime(2025, 10, 18, 9, 59, 47, 112, DateTimeKind.Local).AddTicks(6316) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "bbbdb14f-02c5-43c3-80d2-4b9c30173774", "AQAAAAIAAYagAAAAEGeLhVFQhVPsqNG1yzoQCfR/7oYuFRLPAHziCW6Krmg5EDOnMla5q2Vh0u8iuZnNdg==", "f17a81b1-d502-42cb-91a4-e207fb2a9a8d", new DateTime(2025, 10, 18, 9, 59, 47, 204, DateTimeKind.Local).AddTicks(142) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "c6608ed0-d023-4f20-9883-8320b930d7bf", "AQAAAAIAAYagAAAAEFtIZstzJPqwxdylraPLd6uJ3K+gkk8jE8vSEEni/BfE9U4wcUHoS5OliCxg8C8Qew==", "3a4504e7-0f4f-4ed6-9805-4d99e9f4f8c8", new DateTime(2025, 10, 18, 9, 59, 47, 289, DateTimeKind.Local).AddTicks(9763) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "f13c3715-8299-4590-baef-a0878e5c1f54", "AQAAAAIAAYagAAAAEFbUHtqLel7gjMHTIU/glaFSkFAqznPF8QJ03TQPPa+fCbDwOqCxTdn5w0+zZmuoHw==", "5cf55d16-994a-4fae-b41b-e6e3853244ee", new DateTime(2025, 10, 18, 9, 59, 47, 382, DateTimeKind.Local).AddTicks(7476) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "3c74980f-377f-4d53-a8ec-263e08ca5fc2", "AQAAAAIAAYagAAAAEG91BujU2H1VNe7wPDDBMVN8KXBajhokSE19CQJzauQCHjihYPzURCbYqcWMQZH/lg==", "ee17a41a-a0b3-4bc0-aadd-5f1649f067dd", new DateTime(2025, 10, 18, 9, 59, 47, 485, DateTimeKind.Local).AddTicks(611) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "19dc1b99-e619-455b-bdae-a990457c3dc3", "AQAAAAIAAYagAAAAEAfjELgGlPVgmm15h3FIURPAnl8nmY6OVZahwYu2zezXVMS/+MkhhrCc6pgj4qhFxg==", "e99960f0-a631-4bf3-8cfd-ded068de1b38", new DateTime(2025, 10, 18, 9, 59, 45, 882, DateTimeKind.Local).AddTicks(7879) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "9b409a41-ec31-4add-99a2-52a8dc768fda", "AQAAAAIAAYagAAAAEEkG0ep6IG/Moq7SBGONdKbelgHE9Bj8vedcDVgm0Ox+crc3chWKBjNlQgPmuf7h4Q==", "a9c26324-eac6-4fd8-a828-a2008a1e76b0", new DateTime(2025, 10, 18, 9, 59, 47, 573, DateTimeKind.Local).AddTicks(3387) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "4515121c-5c4a-42e5-9ee2-4c218b9538bf", "AQAAAAIAAYagAAAAEFBXu4xEeY4u4ken86MS3M5s6w2hTJzIfE36TFV8NPBSls7OcDagWkWOQFvKdAz2GA==", "8e7c5f1c-797e-4c7c-9f64-bd0d363ac051", new DateTime(2025, 10, 18, 9, 59, 47, 673, DateTimeKind.Local).AddTicks(3352) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "7af74b32-ef23-4d55-a5e7-115f5fc1e79a", "AQAAAAIAAYagAAAAEEJxXDlyvRA2LfuXROHJU/lTVm4aZoNRgVcynJTUUf3b8gUeYBRJUjWCGiAPz+ULRA==", "af0c7ba8-568e-4221-b4fa-842ddf1e5707", new DateTime(2025, 10, 18, 9, 59, 47, 781, DateTimeKind.Local).AddTicks(7396) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "23",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "ebf39650-73e1-40a4-887d-3abf9169010e", "AQAAAAIAAYagAAAAEPivVZbvd45phOtbN6/8657f89+63bmoQsYO6gimbIWMxq+UdrUAjZlp4aQjvjoHMg==", "f54a44ed-70d9-4ea0-8190-62fb57a58c0e", new DateTime(2025, 10, 18, 9, 59, 47, 880, DateTimeKind.Local).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "24",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "da7797d3-bbce-4c56-b839-bb415c572e6b", "AQAAAAIAAYagAAAAEAY0AfZ+W8/T3jhEh6lBbfN34WMvTRtAXAyp0rZUcsOmdJbkSVtOOZGu+1bgArPRRQ==", "cbe68bfb-72be-4235-889f-a52f0d27b319", new DateTime(2025, 10, 18, 9, 59, 47, 966, DateTimeKind.Local).AddTicks(7379) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "25",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "d0a3b1c5-5bac-4d5c-a7ae-a160703c09fd", "AQAAAAIAAYagAAAAEHQlb7QQ7TRe/Ik4PMhz91kp59i6ATzITM3vZ0z5bhzRyVqS+LRUVJ8eHbsX5Kt5iQ==", "430e693c-7f5a-4010-9bcd-836d2e8778d2", new DateTime(2025, 10, 18, 9, 59, 48, 76, DateTimeKind.Local).AddTicks(9252) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "26",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "d64fec05-2c38-4a6f-9437-0bc67cb0ae04", "AQAAAAIAAYagAAAAEMrF/tzmQlwFWWQtl1liqNRmbtRVkywAEuZM3jITt5dn+DwlfMfIF4CwwB7jwZPZyw==", "e3e70d06-6dce-4ed5-80b1-b6d9aa5c794c", new DateTime(2025, 10, 18, 9, 59, 48, 184, DateTimeKind.Local).AddTicks(6062) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "40d0874b-78f8-4a54-a484-6020db8165fe", "AQAAAAIAAYagAAAAECGoRllmdJTzV6Lb/b4zdo9ya5IO8zh5KQjPYbK4jurCLG0+EyY5UNqjgPG0QR346A==", "22c9a26d-2025-4a2e-854c-a859e69878d5", new DateTime(2025, 10, 18, 9, 59, 48, 269, DateTimeKind.Local).AddTicks(6696) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "28",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "985907b7-6bc0-459e-9ee3-a47156b5d21a", "AQAAAAIAAYagAAAAELNT0tTmhACRpfX8/RaoD1bEir/m2mVVpEMV7uROJkwAMsHpvi3tuQAv6E6Z+ovNPQ==", "2e1126af-4fb4-47f4-a39e-d3e64283271b", new DateTime(2025, 10, 18, 9, 59, 48, 357, DateTimeKind.Local).AddTicks(2951) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "29",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "df7c7ce2-5a82-4a46-8ab6-998fe62d3777", "AQAAAAIAAYagAAAAEH75OXdeMcDoE6X1mW4K2YqCqt4JaW3wtbbtumiuvaBAbk4OeGJ+DTxgpWg0IbGZ2w==", "381b168c-3647-4ec4-9bf7-36bd1c0fb540", new DateTime(2025, 10, 18, 9, 59, 48, 451, DateTimeKind.Local).AddTicks(3466) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "b6b5e115-7adf-47b7-a100-0c427bb038e7", "AQAAAAIAAYagAAAAEB1IhWXLaBtEXhlSrq2XDY1OMVQB7Tm4Xj5S4tdR/7OqnrhY3FodcubzZTAJcGqdzA==", "5678c8b3-a372-4d70-ac0d-906f842fef3e", new DateTime(2025, 10, 18, 9, 59, 45, 975, DateTimeKind.Local).AddTicks(5844) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "30",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "58a644f4-01bb-4549-834b-8927fe292bc6", "AQAAAAIAAYagAAAAEHawQ+n+FN3it+ViLHA+5LxFGlILGCw6rDaYkIr72oQMy4p3OpznBjJIwhnkZGaKVQ==", "d35438ed-106b-49a1-97b7-b44567a8033d", new DateTime(2025, 10, 18, 9, 59, 48, 542, DateTimeKind.Local).AddTicks(9355) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "31",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "a7cd810f-0343-4a7b-b935-e80ee4005f02", "AQAAAAIAAYagAAAAEEnvuTSWeAW9GAtV/xhYRwiKmcy/0nlNOFYKsMH1d5mOs6cz9zsOO7ZSGIoo91qetA==", "92c506c2-aea3-4f08-96f8-2bfee67fe2d6", new DateTime(2025, 10, 18, 9, 59, 48, 630, DateTimeKind.Local).AddTicks(3593) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "32",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "ab262f0d-9fe5-47ad-842d-774792f84c3c", "AQAAAAIAAYagAAAAEC7MxhmAEdx703eoLAdcVs8H6zQvJHRRPnkO3jluHkxY3gC8qxFXf6DxlUq/uMgPhQ==", "4fedee01-b115-4c5d-9503-5c73fa02ad4b", new DateTime(2025, 10, 18, 9, 59, 48, 726, DateTimeKind.Local).AddTicks(1764) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "33",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "7659e591-7336-485b-ab18-5a4ebc33d868", "AQAAAAIAAYagAAAAEG7syervkJljwh2G07oxlRfpFacBg9LidghJopWIJt03lAXyIvTv+RY3LA6rM9/JzA==", "dee88036-2956-4bbd-85a1-69a1d20ee024", new DateTime(2025, 10, 18, 9, 59, 48, 815, DateTimeKind.Local).AddTicks(2052) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "34",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "8efa1350-f926-445a-a66d-5e1b18a85312", "AQAAAAIAAYagAAAAEALBfWnJyd/eAE4v3Z5DsyngMna3hP3xbKDNgK/1BVWhcL+APKyOTJkgjTM4LxqL1g==", "6bb1852c-c5cc-40a8-97ec-6c519303b33d", new DateTime(2025, 10, 18, 9, 59, 48, 909, DateTimeKind.Local).AddTicks(372) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "35",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "a731b283-c453-4bbd-96e0-32e46256371a", "AQAAAAIAAYagAAAAEMre3Foq8DLGR0i2aK4vaQTREH6Mo1BL33c7o4d2vVdzh0geS88rqQTG+65trWUfNQ==", "c16a1117-5b47-4902-8e55-a428d1b830ff", new DateTime(2025, 10, 18, 9, 59, 49, 18, DateTimeKind.Local).AddTicks(2876) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "36",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "7f42e61a-bc7b-496e-837e-9099962f232b", "AQAAAAIAAYagAAAAEHSZ0G95fiXbwAreH4h+NBvrmyh7dchh/l3YGRezt9/HDGih+SJ06DuJMdLq8Dckhg==", "73c68655-f189-4f67-bcef-7e5052f14e06", new DateTime(2025, 10, 18, 9, 59, 49, 406, DateTimeKind.Local).AddTicks(6584) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "37",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "21d8d31a-a012-4e3c-a1a1-da7a0b4f7f9d", "AQAAAAIAAYagAAAAEF4Lzu2oLvq2BekT5eN8ZMc6HsW8Syb1vOLhGQ1N6BRdHRhKI+IXIIGIMPPwfhvhBQ==", "91ace1ff-7e40-43af-a4c3-994ef6024c11", new DateTime(2025, 10, 18, 9, 59, 49, 513, DateTimeKind.Local).AddTicks(6510) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "38",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "bbacf1db-c425-4fd6-a728-bb8dc61e7480", "AQAAAAIAAYagAAAAEDE7hkHUhYXzmL4je0WQa3sXL1Ms+aRRKsF+tPiUzPlUqdbPI9JRldIwrZEyE+Ortg==", "f373965f-3b97-4813-8e14-15e37219b8fe", new DateTime(2025, 10, 18, 9, 59, 49, 609, DateTimeKind.Local).AddTicks(1042) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "39",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "2d6377f4-83ba-4787-bb73-b2b87b086f4f", "AQAAAAIAAYagAAAAEB92Opp9h5MaSo93BV468ENBe9OqDwxTsiE3zt0umWNIFiPhLSSKtqVVDHT7o5rWSQ==", "c3eee590-3aaf-44bf-9e02-a57cd59f2a85", new DateTime(2025, 10, 18, 9, 59, 49, 702, DateTimeKind.Local).AddTicks(8831) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "b0c29ce8-13a6-44fc-bdeb-20ae6ea8d591", "AQAAAAIAAYagAAAAEJ+fvJ57Io7j1Kp2ly3XM+hOTj8EpvNlMHYg7WglGxUcA727cv2fi9Ygeo++e/LRJA==", "416897cd-de94-47ed-a6e7-2754eddb9d02", new DateTime(2025, 10, 18, 9, 59, 46, 97, DateTimeKind.Local).AddTicks(3248) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "40",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "24e1a8ba-6264-4d2c-bbe2-5f9d69a77f6f", "AQAAAAIAAYagAAAAEPAeZmcgPVdAfBs6u81NFFU2E4b9LIYhKYQ5sqwFcAC50pNzPEUtU6/T2HWuyAinlQ==", "087b0019-eacc-4c2a-b36b-9bbe99f72608", new DateTime(2025, 10, 18, 9, 59, 49, 820, DateTimeKind.Local).AddTicks(5521) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "41",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "f5f691ce-09f8-4555-874b-f493b4331287", "AQAAAAIAAYagAAAAEDnWSjEa0hRvmvTGorbyofFTbtwo42OYKqkrKa0ciaTqpu1z06ptougUt8TdXLDUNA==", "c0298e97-bd1e-4d0d-9f04-121c9201c20e", new DateTime(2025, 10, 18, 9, 59, 49, 917, DateTimeKind.Local).AddTicks(9691) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "42",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "8873e4d2-52b2-4a7b-88ad-232fdab49eb5", "AQAAAAIAAYagAAAAEAVuOSRMtTS1K20lvDl3sW6r98hnNzSEqEBvt80dVytw/4HYB51/6iKDQm/0LMsFcg==", "0b50c2ca-8340-4b4c-8090-f03607f5000b", new DateTime(2025, 10, 18, 9, 59, 50, 20, DateTimeKind.Local).AddTicks(1394) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "43",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "29701f9f-c54c-4dbd-a98d-d303a5180964", "AQAAAAIAAYagAAAAEMC/zdmpNDFWkGw5U8v1n+PZwUGee7pog+K8PhTn4z0LI/Jkg97xfSudubR/go/z7A==", "c41c207b-973f-4ca2-afbf-bd8e5bcdee61", new DateTime(2025, 10, 18, 9, 59, 50, 121, DateTimeKind.Local).AddTicks(196) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "44",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "bcbdacca-70a8-4d25-85b7-28e52c4de43d", "AQAAAAIAAYagAAAAEKp6P4gGkksHE5Jh6vuBnABAR8wa3BBFYlFU9uzvx24lS6ZrdHUiRfmXyCsV8qIlYg==", "4e663f64-3e42-4c58-a71e-e6cd1e3d5f16", new DateTime(2025, 10, 18, 9, 59, 50, 219, DateTimeKind.Local).AddTicks(4441) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "45",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "8873fd68-912e-4bad-a3e2-e36a00d9bee6", "AQAAAAIAAYagAAAAECqrcy8vwPFxm7Me0J5rbe2c1HpzOZggj+8nU5GhCM1MF0P47G6RFSZ51LALJ2Ahgg==", "e0c33a0f-0c8a-4a75-8cd3-c8064b34d5f4", new DateTime(2025, 10, 18, 9, 59, 50, 310, DateTimeKind.Local).AddTicks(8178) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "46",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "9929a191-b6db-41e5-9f5d-fc2ae1824953", "AQAAAAIAAYagAAAAEFjSaCxPO3VsjAQss9Cz8OUg+AMfGOTEcenm4eK+HxKjKVs3yyyt7sDujdd6q0ftOg==", "926ef144-c57a-4701-85ee-d4e52f42486f", new DateTime(2025, 10, 18, 9, 59, 50, 412, DateTimeKind.Local).AddTicks(279) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "47",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "92ba93cc-edb1-47c6-b798-8f31eee4d9c6", "AQAAAAIAAYagAAAAEOusoF6yXI/vu9V++se+qlZLfqb16QPV4quNzFhlGM15D19rZBABbUHPXB4+93nRcA==", "d9c0d494-db90-44a7-bf98-8c74714bc0c5", new DateTime(2025, 10, 18, 9, 59, 50, 533, DateTimeKind.Local).AddTicks(333) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "48",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "ff2af1b6-977b-41ea-8d63-6d614ea41e8c", "AQAAAAIAAYagAAAAEBSppH9raiigsQcjn7rITJ/G4x+/tJW7FB3Nj2InGkE3mEiWSC+QKpMZ8g/UEacnCg==", "4f4e7d16-4b2d-43d7-971a-4686db57bb4e", new DateTime(2025, 10, 18, 9, 59, 50, 623, DateTimeKind.Local).AddTicks(2977) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "49",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "c91b4b89-ef56-4d53-b418-04d0e8583558", "AQAAAAIAAYagAAAAEOSzmsSfPu1kLMGuJjUQr5W8uhNEdyq5qVyq5SbUSjsgHeJCbdakp6PPKgastZrcWw==", "48a55b6b-264f-4bdf-97f3-c7c1c09cb077", new DateTime(2025, 10, 18, 9, 59, 50, 713, DateTimeKind.Local).AddTicks(8416) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "36fd1f3f-3dcb-4205-bb2c-97d9b8440c08", "AQAAAAIAAYagAAAAEAzkqasSosQcEDpaKiY9xrvJbPT2NvNxiTavAclPsvHP5D3Mqz4TAXpMa0iKqv8Fkg==", "e034f190-b5c6-45d8-993e-f664b24fe533", new DateTime(2025, 10, 18, 9, 59, 46, 183, DateTimeKind.Local).AddTicks(5572) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "50",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "3fd9c690-fc6e-4cb9-a16e-d179c74c3506", "AQAAAAIAAYagAAAAEG/KQxSXM0BX48fuarMXK3+QOE5CiuTHySGUb06GWHpsYJJjQHiA2My30H3jimBKkg==", "24f252fa-70be-427c-ae7d-6b589ae156f7", new DateTime(2025, 10, 18, 9, 59, 50, 837, DateTimeKind.Local).AddTicks(8373) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "d2d8a1be-d7bd-4e8b-8711-f3c909c922e9", "AQAAAAIAAYagAAAAEPrv0XSK8uyFGSuooxnZKuz52dfnq2Vs1DhKCZEeEfbL5UqcmCaqFjwTK7UOuS9pIA==", "c7012a59-3c9d-40e1-b35f-3eb1547b607b", new DateTime(2025, 10, 18, 9, 59, 46, 282, DateTimeKind.Local).AddTicks(2420) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "334501c6-eefd-47bd-ab09-37eb60d62fae", "AQAAAAIAAYagAAAAEGA5YEuQoi/B4dbWufi2Dhs3DR4LZ5pUYsJJyEd/Td04/ySv5bXaAVkh7fig5pB83w==", "f0511a4d-4d56-453d-8691-eabdd3562c7f", new DateTime(2025, 10, 18, 9, 59, 46, 373, DateTimeKind.Local).AddTicks(5623) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "9be35e74-cf26-416a-a508-3fa134bb2ff8", "AQAAAAIAAYagAAAAEDFNpKWJmowz7d+SH0PSFYq4eNDJSdCyns2y1F+uMWUT+H7NfX8dmnoki+4qmWNMRA==", "0e0cddaf-b450-46ba-a6f8-d12dd76b73fd", new DateTime(2025, 10, 18, 9, 59, 46, 459, DateTimeKind.Local).AddTicks(9839) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "bb0a50c4-e2df-4f32-9060-df9e722a6f30", "AQAAAAIAAYagAAAAEKwbLpGrfQP8IK4NTqK4+mJvAwOqn8dEOrosVcfg2XzV8ngvUS77GH40XMyIvQ50Sg==", "76d234c4-46aa-44b6-b2fd-32bd6ae3542d", new DateTime(2025, 10, 18, 9, 59, 46, 558, DateTimeKind.Local).AddTicks(5059) });

            migrationBuilder.CreateIndex(
                name: "IX_Courses_Acceptor",
                table: "Courses",
                column: "Acceptor");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_Creator",
                table: "Courses",
                column: "Creator");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Users_Acceptor",
                table: "Courses",
                column: "Acceptor",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Users_Creator",
                table: "Courses",
                column: "Creator",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Users_Acceptor",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Users_Creator",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_Acceptor",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_Creator",
                table: "Courses");

            migrationBuilder.AlterColumn<string>(
                name: "Creator",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Acceptor",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AdminId",
                table: "Courses",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MentorId",
                table: "Courses",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 1L,
                columns: new[] { "Acceptor", "AdminId", "Creator", "MentorId" },
                values: new object[] { null, "1", null, "2" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 2L,
                columns: new[] { "Acceptor", "AdminId", "Creator", "MentorId" },
                values: new object[] { null, "1", null, "2" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 3L,
                columns: new[] { "Acceptor", "AdminId", "Creator", "MentorId" },
                values: new object[] { null, "1", null, "2" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 4L,
                columns: new[] { "Acceptor", "AdminId", "Creator", "MentorId" },
                values: new object[] { null, "1", null, "2" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 5L,
                columns: new[] { "Acceptor", "AdminId", "Creator", "MentorId" },
                values: new object[] { null, "1", null, "2" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 6L,
                columns: new[] { "Acceptor", "AdminId", "Creator", "MentorId" },
                values: new object[] { null, "1", null, "2" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 7L,
                columns: new[] { "Acceptor", "AdminId", "Creator", "MentorId" },
                values: new object[] { null, "1", null, "2" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 8L,
                columns: new[] { "Acceptor", "AdminId", "Creator", "MentorId" },
                values: new object[] { null, "1", null, "2" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 9L,
                columns: new[] { "Acceptor", "AdminId", "Creator", "MentorId" },
                values: new object[] { null, "1", null, "2" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 10L,
                columns: new[] { "Acceptor", "AdminId", "Creator", "MentorId" },
                values: new object[] { null, "1", null, "2" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 11L,
                columns: new[] { "Acceptor", "AdminId", "Creator", "MentorId" },
                values: new object[] { null, "1", null, "2" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 12L,
                columns: new[] { "Acceptor", "AdminId", "Creator", "MentorId" },
                values: new object[] { null, "1", null, "2" });

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 1L,
                column: "UpdatedAt",
                value: new DateTime(2025, 9, 25, 15, 26, 53, 931, DateTimeKind.Local).AddTicks(5513));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 2L,
                column: "UpdatedAt",
                value: new DateTime(2025, 9, 25, 15, 26, 53, 931, DateTimeKind.Local).AddTicks(5531));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 3L,
                column: "UpdatedAt",
                value: new DateTime(2025, 9, 25, 15, 26, 53, 931, DateTimeKind.Local).AddTicks(5535));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 4L,
                column: "UpdatedAt",
                value: new DateTime(2025, 9, 25, 15, 26, 53, 931, DateTimeKind.Local).AddTicks(5536));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 5L,
                column: "UpdatedAt",
                value: new DateTime(2025, 9, 25, 15, 26, 53, 931, DateTimeKind.Local).AddTicks(5537));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 6L,
                column: "UpdatedAt",
                value: new DateTime(2025, 9, 25, 15, 26, 53, 931, DateTimeKind.Local).AddTicks(5539));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 7L,
                column: "UpdatedAt",
                value: new DateTime(2025, 9, 25, 15, 26, 53, 931, DateTimeKind.Local).AddTicks(5540));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 8L,
                column: "UpdatedAt",
                value: new DateTime(2025, 9, 25, 15, 26, 53, 931, DateTimeKind.Local).AddTicks(5541));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 9L,
                column: "UpdatedAt",
                value: new DateTime(2025, 9, 25, 15, 26, 53, 931, DateTimeKind.Local).AddTicks(5543));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 10L,
                column: "UpdatedAt",
                value: new DateTime(2025, 9, 25, 15, 26, 53, 931, DateTimeKind.Local).AddTicks(5545));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 11L,
                column: "UpdatedAt",
                value: new DateTime(2025, 9, 25, 15, 26, 53, 931, DateTimeKind.Local).AddTicks(5546));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 12L,
                column: "UpdatedAt",
                value: new DateTime(2025, 9, 25, 15, 26, 53, 931, DateTimeKind.Local).AddTicks(5547));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 13L,
                column: "UpdatedAt",
                value: new DateTime(2025, 9, 25, 15, 26, 53, 931, DateTimeKind.Local).AddTicks(5548));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 14L,
                column: "UpdatedAt",
                value: new DateTime(2025, 9, 25, 15, 26, 53, 931, DateTimeKind.Local).AddTicks(5549));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 15L,
                column: "UpdatedAt",
                value: new DateTime(2025, 9, 25, 15, 26, 53, 931, DateTimeKind.Local).AddTicks(5550));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 16L,
                column: "UpdatedAt",
                value: new DateTime(2025, 9, 25, 15, 26, 53, 931, DateTimeKind.Local).AddTicks(5551));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 17L,
                column: "UpdatedAt",
                value: new DateTime(2025, 9, 25, 15, 26, 53, 931, DateTimeKind.Local).AddTicks(5552));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 18L,
                column: "UpdatedAt",
                value: new DateTime(2025, 9, 25, 15, 26, 53, 931, DateTimeKind.Local).AddTicks(5553));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 19L,
                column: "UpdatedAt",
                value: new DateTime(2025, 9, 25, 15, 26, 53, 931, DateTimeKind.Local).AddTicks(5554));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 20L,
                column: "UpdatedAt",
                value: new DateTime(2025, 9, 25, 15, 26, 53, 931, DateTimeKind.Local).AddTicks(5555));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 21L,
                column: "UpdatedAt",
                value: new DateTime(2025, 9, 25, 15, 26, 53, 931, DateTimeKind.Local).AddTicks(5556));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 22L,
                column: "UpdatedAt",
                value: new DateTime(2025, 9, 25, 15, 26, 53, 931, DateTimeKind.Local).AddTicks(5557));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 23L,
                column: "UpdatedAt",
                value: new DateTime(2025, 9, 25, 15, 26, 53, 931, DateTimeKind.Local).AddTicks(5558));

            migrationBuilder.UpdateData(
                table: "QuizResults",
                keyColumn: "QuizResultId",
                keyValue: 24L,
                column: "UpdatedAt",
                value: new DateTime(2025, 9, 25, 15, 26, 53, 931, DateTimeKind.Local).AddTicks(5560));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "efc33132-c59e-4417-9194-7450b58786a7", "AQAAAAIAAYagAAAAEN2CggPV0DN58YXBQ6OniWcB4wJdvGCEts6YTz8USAj4+RX9GYOsqTn6uZGP3sbDIg==", "4ee8c62d-9b13-4ce7-a594-ecbd2c1dd2fc", new DateTime(2025, 9, 25, 15, 26, 53, 931, DateTimeKind.Local).AddTicks(9569) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "083bf41e-274c-4615-a2a3-6e12c1abce89", "AQAAAAIAAYagAAAAEAvp1g0qP9TD4uZedLokDFvaUHgk8IHZ1d1uoYV0eiqjTFyCmYOeLn7osXLEXd2nkg==", "77a1805c-2e5e-4a8d-bddb-9c1eb265abec", new DateTime(2025, 9, 25, 15, 26, 54, 466, DateTimeKind.Local).AddTicks(4388) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "ffa1f764-650b-4db5-977b-5849d9dcea1d", "AQAAAAIAAYagAAAAEJbzBO4bA+cHcC/dPSNO8RkZjd9gWOnVM8UQ/N7f4RRAq+UChMOZVmaeXTSiFHdUFA==", "182cbe25-e7f8-4521-bbc9-cf80f17da275", new DateTime(2025, 9, 25, 15, 26, 54, 521, DateTimeKind.Local).AddTicks(5750) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "d24da276-7b2b-41d9-a3da-1fd7753af69b", "AQAAAAIAAYagAAAAEOIcUbIXLlOZw5sr5Ro3eq6UA1JsNPhSbyeqDwhQQCxQstyyKSetjnbPyejFeKc+cg==", "8e0d60ab-30a9-4d51-8b6e-9563cd92f562", new DateTime(2025, 9, 25, 15, 26, 54, 598, DateTimeKind.Local).AddTicks(3675) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "dae8555e-13b2-46ca-b62e-10f745f0be9d", "AQAAAAIAAYagAAAAELfdP1WEtYAa5ChQwmdW0aT8ILT2kTrKjCKEfIuL8cZOx4xhNtXD/A0RVEqx90mOwg==", "701f3d15-c80b-4edc-a36f-7b6437b6440c", new DateTime(2025, 9, 25, 15, 26, 54, 655, DateTimeKind.Local).AddTicks(8192) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "fbae1bf2-1e94-4ea0-8be5-a45f18fa56f9", "AQAAAAIAAYagAAAAEHNQT/mup/dyPIFr3iLIiTyx1l6vdGpJLQ1EXZPsUwEASwnfblNceLidQPxrMc/c5g==", "c924e449-dc27-489d-9801-02da739cb077", new DateTime(2025, 9, 25, 15, 26, 54, 717, DateTimeKind.Local).AddTicks(6191) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "a04f7253-e044-442a-a309-92fe1aeb8f29", "AQAAAAIAAYagAAAAEHjK2m/xr5SdFrORpENpW/IDgPCgSeeNwn5fLdrmOUrkZSoklYqfcG4fcvVgCTJaGQ==", "fbd42bad-246b-4ef6-9133-5705dc6f8e2f", new DateTime(2025, 9, 25, 15, 26, 54, 778, DateTimeKind.Local).AddTicks(2944) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "4c4598da-d2b5-4d8a-b9cb-05f73677f2c4", "AQAAAAIAAYagAAAAEAQgxIaWkrGaSJ1kzmgpZ3jmT2OF+27CTsGgs3CHozUhkTZBG7JKp+qP6razKhz5eg==", "6cf0695b-0f1a-4164-b1bd-07745e9fdcf8", new DateTime(2025, 9, 25, 15, 26, 54, 834, DateTimeKind.Local).AddTicks(3053) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "df85def7-bd27-4231-bbcd-30975c3cd72a", "AQAAAAIAAYagAAAAECcTflvAYBaIglSBWdWjF2va2lQ9bpBqFxd0Lt8Y82ZrQezmhBtzpx7L8ADNiA8DbQ==", "b326b2cf-722a-4220-8f2c-16ac62f01f15", new DateTime(2025, 9, 25, 15, 26, 54, 896, DateTimeKind.Local).AddTicks(9250) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "201f370b-fd0a-42a8-86d6-d472b1d67e23", "AQAAAAIAAYagAAAAEEU+1HYJ9FwfEg4ogfzEMvlFd/p9Uyn2NqxGZAjnp8/9PImR+PFjehbx/9kl07FkGA==", "cfe018f9-50b4-4f28-8ebc-5abe382419b6", new DateTime(2025, 9, 25, 15, 26, 54, 971, DateTimeKind.Local).AddTicks(5519) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "e4b913a3-ea7f-4149-b21a-f3a96ee6ee6f", "AQAAAAIAAYagAAAAEHOr98yUE85bgFYPkdAxuvkJ16nkFB4SZKQX7cfVKT5c56mkPrAjAqqb0BoS/MI5dQ==", "7c22151c-918e-4c01-aac1-ba25a6325d0f", new DateTime(2025, 9, 25, 15, 26, 55, 39, DateTimeKind.Local).AddTicks(4240) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "efebe7ef-42e1-4ea1-8ed6-3314bd490ea9", "AQAAAAIAAYagAAAAEOil2KUQFhxT0QWPMNhZbWP4xYWjSebWFXcFjvfbBmV+pynPoFdmoHDIszQjGHdERQ==", "cc76d07d-4b6c-4760-aa7b-541592216fb0", new DateTime(2025, 9, 25, 15, 26, 53, 986, DateTimeKind.Local).AddTicks(5665) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "a10dadca-47f3-4d3c-a6d4-53d17220a9f1", "AQAAAAIAAYagAAAAEHd+NULPXjw3AbSgVNi9szC91oTMQtI+kipPK7I8kPHoBAh2BcpenEXlCJZmUXJMRg==", "fbca23ae-abd9-46a8-a626-fe28ae421096", new DateTime(2025, 9, 25, 15, 26, 55, 109, DateTimeKind.Local).AddTicks(4276) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "80316c28-5924-40b4-a37c-430d0b5677ad", "AQAAAAIAAYagAAAAEEiaAe64VYGFvq61V6mEYkKTIBzlcF/mTVmBhgEF2iCVkY+0YCAb4rNshBq38Rz4Pg==", "e8e21478-0d56-4d19-969a-2bd38712da38", new DateTime(2025, 9, 25, 15, 26, 55, 165, DateTimeKind.Local).AddTicks(9737) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "5f8efc8a-5b47-4dc4-baf0-e6b34b0bb8c9", "AQAAAAIAAYagAAAAEII1FTNLEKwi6AXBP+mQDt+fH+sCZ2bZg9BFbcD90FHIbz/AQRKihe+qrlzsbQ7AKg==", "7f627513-7097-4c9b-85b9-11f10232e547", new DateTime(2025, 9, 25, 15, 26, 55, 221, DateTimeKind.Local).AddTicks(6177) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "23",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "6dfad9b3-2831-430d-b5d7-111dcc51fdaa", "AQAAAAIAAYagAAAAEMQlCxLWZ9wtFsGMhub7U5syxIQSfp1LYEpiGAvPyp1eebV8kf6uNXahuu+EoFfc3w==", "e6df8802-dc91-49fa-a940-a55f1498d9ba", new DateTime(2025, 9, 25, 15, 26, 55, 276, DateTimeKind.Local).AddTicks(6309) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "24",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "41dea4b1-0e63-4448-9ea6-16a6f7302297", "AQAAAAIAAYagAAAAEIlg2enc/iTf3HwSEzgL9WE2xeKXUxZBwRXKQqEjkBr04xwzLNdFpXhd/M+5cIA2qg==", "71ea033d-0962-4ccf-a769-91f2d5c98474", new DateTime(2025, 9, 25, 15, 26, 55, 345, DateTimeKind.Local).AddTicks(5347) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "25",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "45ebf004-a183-4de4-9886-f6166d56ebb8", "AQAAAAIAAYagAAAAEK44f1cn8NYsgrOq7q7w3ujGGu7NkRLQ/BGJjwsamX2omZC99saB4t92FaRbU4agdQ==", "9c53d238-1b50-4733-8ac5-25268770ac2e", new DateTime(2025, 9, 25, 15, 26, 55, 404, DateTimeKind.Local).AddTicks(5223) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "26",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "a7838a5f-ba2a-40ec-833e-776583e1ea26", "AQAAAAIAAYagAAAAEEW0+j+zj6bTPM2rU6fV+b+JMIZZTrY/Qk/83e8NMav0211B32UVJwDSLHu14Cjucg==", "c1908098-eecc-4101-aa4a-49b7dc90047b", new DateTime(2025, 9, 25, 15, 26, 55, 459, DateTimeKind.Local).AddTicks(6405) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "0797d1f9-e294-4718-bf58-398406ddc26a", "AQAAAAIAAYagAAAAEHeTmNT2nAJ5Xlm7NXi4PNFla3x8+40SwCQ+OAGxrFFir9Cvq4qOyPJjhvHDY7GrJw==", "9e049990-46e4-4d51-80e6-a0d4036571ad", new DateTime(2025, 9, 25, 15, 26, 55, 519, DateTimeKind.Local).AddTicks(6779) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "28",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "d13039a1-821b-44e8-9d84-ebcbb24ac8ea", "AQAAAAIAAYagAAAAECvVgypFTTo8gEQhHY2QvUf6GB+8o7gZtrrzp87zmhPfOeGK1KHGQPsEix7uhnI02w==", "088a8a0d-4e2c-43b2-b5e2-37f5ac30f240", new DateTime(2025, 9, 25, 15, 26, 55, 588, DateTimeKind.Local).AddTicks(3026) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "29",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "26f52202-c24f-4e9c-80e2-76045a10461e", "AQAAAAIAAYagAAAAEM3I7X7omzc6+whBDqlo1bXKjhIIcxABBr5qyQyorwdG/nWCHflmUO3FKYD+7r/PYA==", "7d8ce719-90cf-4316-a380-5dcbc790d7dd", new DateTime(2025, 9, 25, 15, 26, 55, 656, DateTimeKind.Local).AddTicks(9284) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "48fac432-ab3d-4d53-9634-ff46b84d664b", "AQAAAAIAAYagAAAAEFLhlHIQCzet2vh/DkXGdhctmKqiO1lqYiM40FAD5BkEyMEZh0O2h0TQHwK9t5+4ww==", "931cb9b5-059a-468b-bc16-247053d77464", new DateTime(2025, 9, 25, 15, 26, 54, 38, DateTimeKind.Local).AddTicks(1873) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "30",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "2bae516e-b02c-453d-9253-188e356736f6", "AQAAAAIAAYagAAAAELJ2UPYzeqHKrrej60luv4PnYz2QOPFovFkKGYe92mIQ/RXRF+XYXiq7fI7+dAR0eQ==", "25694ef8-49f4-441d-8e75-816cfad44b2b", new DateTime(2025, 9, 25, 15, 26, 55, 725, DateTimeKind.Local).AddTicks(4159) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "31",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "5c23dc2d-c619-4b8c-841e-7339d2eb622c", "AQAAAAIAAYagAAAAEDgqgVBFQMkMbT+yzBnyleNBhWYlJOGy6n2LSa2+HjDOz3EpF91pVFiCyarPZ7eIEA==", "620e2805-341c-4c82-b24c-1d0fa1e7a89e", new DateTime(2025, 9, 25, 15, 26, 55, 789, DateTimeKind.Local).AddTicks(5120) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "32",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "bcdcf7c9-ac0f-431d-ba1e-9cceb6bf8d11", "AQAAAAIAAYagAAAAEHwPADiGTnYEKtky3UiXylpjEUSlKTKQzsSEERgfAg2Q7eTW6sUMfgulidu3JjXemw==", "e664543d-de49-4267-aa7c-040b8b82ab81", new DateTime(2025, 9, 25, 15, 26, 55, 859, DateTimeKind.Local).AddTicks(8506) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "33",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "2b434179-a329-4e07-92a0-de4c0734d732", "AQAAAAIAAYagAAAAEEO47GNvRxKHy9NZeox0AA6aoQiwC4HfvgC2nzHbgMo4CyhFaOMxdKv9cMJ+4WehwQ==", "e66bf220-0122-4e5e-9222-8d1ed6969419", new DateTime(2025, 9, 25, 15, 26, 55, 923, DateTimeKind.Local).AddTicks(9144) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "34",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "dc290ff5-b127-42c8-aa9d-6ef9bee6d27f", "AQAAAAIAAYagAAAAEFprZJx9IW9ykXA6lm0TvjZoMv2FdUPzmmsIl6TJyEnCsHSV62NF1x15K4Fl/3HXDQ==", "bd44c46d-7510-4c0e-83aa-c6cf7190646c", new DateTime(2025, 9, 25, 15, 26, 55, 983, DateTimeKind.Local).AddTicks(5079) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "35",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "23ac495d-1614-4cf5-a35c-81117ec68f06", "AQAAAAIAAYagAAAAEEcUu7bqIhoBMyAYSg6ybiHGyrX5w5AAtxZ4kWZ/4Cd4QoRLtiZIRxi7BJUcVaaleA==", "c6893683-8fa0-4cd3-96b4-9573350d0fe8", new DateTime(2025, 9, 25, 15, 26, 56, 39, DateTimeKind.Local).AddTicks(7584) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "36",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "4e210c63-c525-4860-ae3d-be85024c760a", "AQAAAAIAAYagAAAAEEN47VO4T/SgHFQu5DuMgjjYAxYWdrR3jSD/1teso4XeXFQ/9nlWDR2D2fC03SgsTA==", "234c8dba-f85f-4b4c-857e-9832cd0afeea", new DateTime(2025, 9, 25, 15, 26, 56, 112, DateTimeKind.Local).AddTicks(9429) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "37",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "15ebd82b-1c5a-466b-bf10-585c64080fab", "AQAAAAIAAYagAAAAEIfRmtZhJajAUfZmpe2a0yt1/+7dNE6bnI4rlxCgEK4BAWjEhFTmm1BvgluBew4NHw==", "2a575b9e-f6c7-47cf-b3ac-f23a0ece9987", new DateTime(2025, 9, 25, 15, 26, 56, 177, DateTimeKind.Local).AddTicks(7197) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "38",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "a91d79e2-3016-4b42-9f91-f58ebe250cd6", "AQAAAAIAAYagAAAAEObirlGaW05gaVWs/jUyAt6de64rsuV/Twl/du5gX4ZPP87hh/E1ABOzug4NrebYjg==", "85ded531-48f8-4020-8765-46eb9cd0acce", new DateTime(2025, 9, 25, 15, 26, 56, 233, DateTimeKind.Local).AddTicks(8697) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "39",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "32a8491f-abf3-429a-83aa-aff3367bd735", "AQAAAAIAAYagAAAAEALFa8ZjC2Bc662fUOBWQCvOW6esKpVBN4nWMh56q7oLoWMwvo8CY/6U41Q1hcZnaw==", "5610810e-4fe2-49f2-8c86-c874227aeac4", new DateTime(2025, 9, 25, 15, 26, 56, 289, DateTimeKind.Local).AddTicks(5080) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "be8790c9-df1d-439c-b118-0a524f3fb2af", "AQAAAAIAAYagAAAAEJYW7ViRJeNRx9m3BecVQZnn8cJ5c1wew4vFTRAJs/IMlaKwFdb3Ic07YkxRyrwjRw==", "9cff054a-9168-4dc0-a2ff-a32df0748572", new DateTime(2025, 9, 25, 15, 26, 54, 100, DateTimeKind.Local).AddTicks(5779) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "40",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "6f7d8fa1-e36e-49b5-8294-b221602a89ac", "AQAAAAIAAYagAAAAEOH0SqKtvJviPg8iVWMSFAqDjxnVMmMdBUmq2T4YtzdVyqvz2saU7rYdhT+9ZlRbMw==", "5f6cee87-2197-4f50-bc53-81ffa7e0e69f", new DateTime(2025, 9, 25, 15, 26, 56, 363, DateTimeKind.Local).AddTicks(7395) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "41",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "a48e9112-e7b1-41ca-97c3-059c3b3059a9", "AQAAAAIAAYagAAAAEInk+R+SXT03+mcXWBRSsaBNxL1K673g8RsAzYgYSS41ic1vg0+2+PLjJ98DUQoCBQ==", "7bb3d91d-690c-4b75-b214-26fef7eabaf0", new DateTime(2025, 9, 25, 15, 26, 56, 421, DateTimeKind.Local).AddTicks(1948) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "42",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "a5d9f2e6-12a9-4a6b-9c06-b5656acc0404", "AQAAAAIAAYagAAAAEIuF6zy3P99wd+oLd2OIi//KL7HCP/Wo+3F9U7xwDEc47h+d8/5wu09dsD4uSnTcRQ==", "8693a035-3c56-484d-92f7-f8dc32756a9b", new DateTime(2025, 9, 25, 15, 26, 56, 490, DateTimeKind.Local).AddTicks(3418) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "43",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "a00864d1-c7f2-467c-aa4e-38bf7ef0e384", "AQAAAAIAAYagAAAAEN1lS7vV6rSam68JqxZy36zu24ZdOQ69Ri2UH6+L/Gs+DfnA4Y5syOUNybDtQVnDrQ==", "dbea48b2-a91e-4ed5-824e-47ec80e523a8", new DateTime(2025, 9, 25, 15, 26, 56, 545, DateTimeKind.Local).AddTicks(5516) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "44",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "9aeb71bb-d95c-411c-8427-666b8e264338", "AQAAAAIAAYagAAAAEOlPLi2BiXRCrJHiJvgdezcvZ+yQQFyJ4ITuhfqGfZL/O728MD7aPrYO/hf6kCAFVA==", "2ac0083b-5f82-41c1-a3ef-aeb4e1d4523a", new DateTime(2025, 9, 25, 15, 26, 56, 601, DateTimeKind.Local).AddTicks(9504) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "45",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "30fa40dc-7f7b-4793-a6cb-76a7f14c82f0", "AQAAAAIAAYagAAAAEPZqR/0H2PN0hVagc51Qmm9BBW1t34gja7dUTtIqXz6G9SVOJkuC/gq+zVvgDw3vqw==", "905d85ba-b507-45f3-8a77-b62e2a53712b", new DateTime(2025, 9, 25, 15, 26, 56, 658, DateTimeKind.Local).AddTicks(1997) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "46",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "73b23966-e06f-4b7c-b9c8-70329783e4e7", "AQAAAAIAAYagAAAAEKlzXEWnWPkpEyFE3Mnl1MSLuLlsFV86hfQuNWqiAeKn6207k9PT29GXobkb5TX0nw==", "463fbc23-58d4-406a-9e76-e7a8f95bbccf", new DateTime(2025, 9, 25, 15, 26, 56, 715, DateTimeKind.Local).AddTicks(3437) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "47",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "6bc08024-3ca4-4bfb-8fbb-acfa399fcd17", "AQAAAAIAAYagAAAAEJZLB+0Q9/9bU8ne9Ujo3w9OYS7EaSNJuhAxBijm/n8rL5pbiL7zB7fcrFXswww/gQ==", "2143a310-f362-4688-9096-1ba203164ca2", new DateTime(2025, 9, 25, 15, 26, 56, 773, DateTimeKind.Local).AddTicks(4262) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "48",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "68e2e303-5d53-4d68-8aea-63a3c8f434f2", "AQAAAAIAAYagAAAAEPb/shh0jIBRx0K97ISp/X6JEBHzN78EGz51RyWOVKgWpru+sg6mNBhzsaFvIWznsA==", "5f8aa86b-e8ca-4776-ae78-a62e2a6c276c", new DateTime(2025, 9, 25, 15, 26, 56, 844, DateTimeKind.Local).AddTicks(6401) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "49",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "74e62182-c6ac-4148-8794-fc7ed5f9153a", "AQAAAAIAAYagAAAAEMyALcSrICrXglwhq6epNIkt2EdA1HLx8SYAJGCtIBDyZViaWdONuIuTMd627asN3Q==", "e273335a-80ef-4422-b022-c2121fa97efb", new DateTime(2025, 9, 25, 15, 26, 56, 911, DateTimeKind.Local).AddTicks(4284) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "f88185d1-72b5-40af-8010-cc9674caf4c7", "AQAAAAIAAYagAAAAEPdiU7GPpqos48TtV5nyFB8XK0hpL+XD5W+t20VPPA4xDJE7CL8sqGJZUnQGURE3rg==", "5b191563-c368-44c2-8fb7-040584f82c16", new DateTime(2025, 9, 25, 15, 26, 54, 158, DateTimeKind.Local).AddTicks(5288) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "50",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "ba1db3c5-02e4-4a19-9ed5-da519d3c84f2", "AQAAAAIAAYagAAAAEOlMQhLw/tBWDxB78AdtHm5ebII0122Q0/tR8cCsf1C02sTUu2c6bYvOmlZMcDbHkg==", "8cef86d1-ee4b-4670-97ab-5ead75fceb9b", new DateTime(2025, 9, 25, 15, 26, 56, 966, DateTimeKind.Local).AddTicks(2927) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "73aba742-2bc6-484c-b2d1-affaf0a093d3", "AQAAAAIAAYagAAAAEJ53ynl3+utHpWfqw+y4DPNVq9aHr3SEE/5L1TYZoeyByQVMRYo5yuDsgX3DODMUeQ==", "aedb1f1f-f9f8-45bc-bd49-60a4438d34ec", new DateTime(2025, 9, 25, 15, 26, 54, 214, DateTimeKind.Local).AddTicks(2431) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "804f5d19-4fc5-45c8-89cc-a0e7e9c66b0b", "AQAAAAIAAYagAAAAENPAF99PT6oaBK2w39At/0rNSpEwxjz1waU28d0Za4X1bSo+pHHrB4WkqPEwpcgpwg==", "0ddc4492-70c5-4648-896f-3f03329a37e5", new DateTime(2025, 9, 25, 15, 26, 54, 270, DateTimeKind.Local).AddTicks(2805) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "3b080077-d714-417a-837f-dcff3e415a96", "AQAAAAIAAYagAAAAEMo/tLkZXmAqG0ndXAsNDUiRqkefX7HLeh7Nxyg3pocbmUdzNWhpPjuwlfMDhpSCBw==", "1e2105ca-c318-46aa-ac5d-82a064b09755", new DateTime(2025, 9, 25, 15, 26, 54, 347, DateTimeKind.Local).AddTicks(2231) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "ac5db0e2-1f8a-4e76-8d62-03dbfc12ecc3", "AQAAAAIAAYagAAAAEKcAnRbsjU0uFu4fbctNLRBu10S2808N0+1EVWYEso58n6+Qad8v/4WxKWeB4LWmwQ==", "cdc021cc-5d4f-495c-9143-d9bfb938d846", new DateTime(2025, 9, 25, 15, 26, 54, 411, DateTimeKind.Local).AddTicks(4273) });

            migrationBuilder.CreateIndex(
                name: "IX_Courses_AdminId",
                table: "Courses",
                column: "AdminId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_MentorId",
                table: "Courses",
                column: "MentorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Users_AdminId",
                table: "Courses",
                column: "AdminId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Users_MentorId",
                table: "Courses",
                column: "MentorId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
