using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

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
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "ce523853-30c8-4ae7-bce2-92c8c8abce0f", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEMqiBBBmMMHNWcQTeSAaZpXQnWibOEm37UuuzQtFgr4dz6K2Y0iUDJOrrtlTQG2d6Q==", null, false, "cac6e53e-5f7d-4b5f-aadd-5391042e6766", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 16, 31, 24, 318, DateTimeKind.Local).AddTicks(3779), new DateTime(2024, 11, 20, 16, 31, 24, 318, DateTimeKind.Local).AddTicks(3794) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 16, 31, 24, 318, DateTimeKind.Local).AddTicks(3798), new DateTime(2024, 11, 20, 16, 31, 24, 318, DateTimeKind.Local).AddTicks(3799) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 16, 31, 24, 318, DateTimeKind.Local).AddTicks(4303), new DateTime(2024, 11, 20, 16, 31, 24, 318, DateTimeKind.Local).AddTicks(4305) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 16, 31, 24, 318, DateTimeKind.Local).AddTicks(4308), new DateTime(2024, 11, 20, 16, 31, 24, 318, DateTimeKind.Local).AddTicks(4310) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 16, 31, 24, 318, DateTimeKind.Local).AddTicks(4714), new DateTime(2024, 11, 20, 16, 31, 24, 318, DateTimeKind.Local).AddTicks(4720) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 16, 31, 24, 318, DateTimeKind.Local).AddTicks(4724), new DateTime(2024, 11, 20, 16, 31, 24, 318, DateTimeKind.Local).AddTicks(4726) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 16, 31, 24, 318, DateTimeKind.Local).AddTicks(4729), new DateTime(2024, 11, 20, 16, 31, 24, 318, DateTimeKind.Local).AddTicks(4730) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 16, 31, 24, 318, DateTimeKind.Local).AddTicks(4733), new DateTime(2024, 11, 20, 16, 31, 24, 318, DateTimeKind.Local).AddTicks(4735) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
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
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 16, 19, 33, 62, DateTimeKind.Local).AddTicks(493), new DateTime(2024, 11, 20, 16, 19, 33, 62, DateTimeKind.Local).AddTicks(511) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 16, 19, 33, 62, DateTimeKind.Local).AddTicks(516), new DateTime(2024, 11, 20, 16, 19, 33, 62, DateTimeKind.Local).AddTicks(517) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 16, 19, 33, 62, DateTimeKind.Local).AddTicks(1230), new DateTime(2024, 11, 20, 16, 19, 33, 62, DateTimeKind.Local).AddTicks(1233) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 16, 19, 33, 62, DateTimeKind.Local).AddTicks(1236), new DateTime(2024, 11, 20, 16, 19, 33, 62, DateTimeKind.Local).AddTicks(1238) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 16, 19, 33, 62, DateTimeKind.Local).AddTicks(1532), new DateTime(2024, 11, 20, 16, 19, 33, 62, DateTimeKind.Local).AddTicks(1534) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 16, 19, 33, 62, DateTimeKind.Local).AddTicks(1537), new DateTime(2024, 11, 20, 16, 19, 33, 62, DateTimeKind.Local).AddTicks(1539) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 16, 19, 33, 62, DateTimeKind.Local).AddTicks(1542), new DateTime(2024, 11, 20, 16, 19, 33, 62, DateTimeKind.Local).AddTicks(1544) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 16, 19, 33, 62, DateTimeKind.Local).AddTicks(1547), new DateTime(2024, 11, 20, 16, 19, 33, 62, DateTimeKind.Local).AddTicks(1549) });
        }
    }
}
