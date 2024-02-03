using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PC_PartsReview_Website.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultDataAndUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "0cef436f-6f38-4273-a9bd-b799a6b93563", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEFY9qwIY7repFVQTLkAKYXobW4133JAX4GDxQArarfv2w371gAvLm0WsZMSrb0kAjw==", null, false, "c7b95dac-e80d-481f-8a2d-56e9f84cbc09", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "PcParts",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 2, 2, 18, 50, 45, 103, DateTimeKind.Local).AddTicks(5604), new DateTime(2024, 2, 2, 18, 50, 45, 103, DateTimeKind.Local).AddTicks(5604), "RTX 3080", "System" },
                    { 2, "System", new DateTime(2024, 2, 2, 18, 50, 45, 103, DateTimeKind.Local).AddTicks(5606), new DateTime(2024, 2, 2, 18, 50, 45, 103, DateTimeKind.Local).AddTicks(5606), "RTX 3070", "System" }
                });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "PersonalRating", "Quality", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 2, 2, 18, 50, 45, 103, DateTimeKind.Local).AddTicks(5191), new DateTime(2024, 2, 2, 18, 50, 45, 103, DateTimeKind.Local).AddTicks(5207), "Excellent", "5/5", "System" },
                    { 2, "System", new DateTime(2024, 2, 2, 18, 50, 45, 103, DateTimeKind.Local).AddTicks(5209), new DateTime(2024, 2, 2, 18, 50, 45, 103, DateTimeKind.Local).AddTicks(5209), "Very Good", "4/5", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "PcPartId", "RatingId", "ReviewDescription", "ReviewTitle", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 2, 2, 18, 50, 45, 103, DateTimeKind.Local).AddTicks(5765), new DateTime(2024, 2, 2, 18, 50, 45, 103, DateTimeKind.Local).AddTicks(5765), 1, 1, "This GPU Rocks...", "RTX 3080 Review", "System" },
                    { 2, "System", new DateTime(2024, 2, 2, 18, 50, 45, 103, DateTimeKind.Local).AddTicks(5767), new DateTime(2024, 2, 2, 18, 50, 45, 103, DateTimeKind.Local).AddTicks(5767), 2, 2, "This GPU performs...", "RTX 3070 Review", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.DeleteData(
                table: "PcParts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PcParts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
