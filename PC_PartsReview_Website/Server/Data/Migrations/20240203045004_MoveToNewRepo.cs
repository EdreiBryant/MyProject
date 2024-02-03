using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PC_PartsReview_Website.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class MoveToNewRepo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a07cacbc-9886-4954-bf01-e45d9cdf2a94", "AQAAAAIAAYagAAAAEMnu692V88TAb45j2EOvG31MBri2d+XZZj1Rm9HD8c+Xo1icDQ7mrJEmkiJ0992lAA==", "85beefb1-aea1-4586-95ce-87e8e6527abb" });

            migrationBuilder.UpdateData(
                table: "PcParts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 12, 50, 4, 469, DateTimeKind.Local).AddTicks(2432), new DateTime(2024, 2, 3, 12, 50, 4, 469, DateTimeKind.Local).AddTicks(2433) });

            migrationBuilder.UpdateData(
                table: "PcParts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 12, 50, 4, 469, DateTimeKind.Local).AddTicks(2436), new DateTime(2024, 2, 3, 12, 50, 4, 469, DateTimeKind.Local).AddTicks(2437) });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 12, 50, 4, 469, DateTimeKind.Local).AddTicks(1873), new DateTime(2024, 2, 3, 12, 50, 4, 469, DateTimeKind.Local).AddTicks(1884) });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 12, 50, 4, 469, DateTimeKind.Local).AddTicks(1887), new DateTime(2024, 2, 3, 12, 50, 4, 469, DateTimeKind.Local).AddTicks(1888) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 12, 50, 4, 469, DateTimeKind.Local).AddTicks(2751), new DateTime(2024, 2, 3, 12, 50, 4, 469, DateTimeKind.Local).AddTicks(2752) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 12, 50, 4, 469, DateTimeKind.Local).AddTicks(2755), new DateTime(2024, 2, 3, 12, 50, 4, 469, DateTimeKind.Local).AddTicks(2756) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0cef436f-6f38-4273-a9bd-b799a6b93563", "AQAAAAIAAYagAAAAEFY9qwIY7repFVQTLkAKYXobW4133JAX4GDxQArarfv2w371gAvLm0WsZMSrb0kAjw==", "c7b95dac-e80d-481f-8a2d-56e9f84cbc09" });

            migrationBuilder.UpdateData(
                table: "PcParts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 18, 50, 45, 103, DateTimeKind.Local).AddTicks(5604), new DateTime(2024, 2, 2, 18, 50, 45, 103, DateTimeKind.Local).AddTicks(5604) });

            migrationBuilder.UpdateData(
                table: "PcParts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 18, 50, 45, 103, DateTimeKind.Local).AddTicks(5606), new DateTime(2024, 2, 2, 18, 50, 45, 103, DateTimeKind.Local).AddTicks(5606) });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 18, 50, 45, 103, DateTimeKind.Local).AddTicks(5191), new DateTime(2024, 2, 2, 18, 50, 45, 103, DateTimeKind.Local).AddTicks(5207) });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 18, 50, 45, 103, DateTimeKind.Local).AddTicks(5209), new DateTime(2024, 2, 2, 18, 50, 45, 103, DateTimeKind.Local).AddTicks(5209) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 18, 50, 45, 103, DateTimeKind.Local).AddTicks(5765), new DateTime(2024, 2, 2, 18, 50, 45, 103, DateTimeKind.Local).AddTicks(5765) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 18, 50, 45, 103, DateTimeKind.Local).AddTicks(5767), new DateTime(2024, 2, 2, 18, 50, 45, 103, DateTimeKind.Local).AddTicks(5767) });
        }
    }
}
