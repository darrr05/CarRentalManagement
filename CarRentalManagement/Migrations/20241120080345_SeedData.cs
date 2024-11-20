using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 20, 16, 3, 43, 395, DateTimeKind.Local).AddTicks(5865), new DateTime(2024, 11, 20, 16, 3, 43, 395, DateTimeKind.Local).AddTicks(5878), "Black", "System" },
                    { 2, "System", new DateTime(2024, 11, 20, 16, 3, 43, 395, DateTimeKind.Local).AddTicks(5883), new DateTime(2024, 11, 20, 16, 3, 43, 395, DateTimeKind.Local).AddTicks(5884), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 20, 16, 3, 43, 395, DateTimeKind.Local).AddTicks(6446), new DateTime(2024, 11, 20, 16, 3, 43, 395, DateTimeKind.Local).AddTicks(6448), "BMW", "System" },
                    { 2, "System", new DateTime(2024, 11, 20, 16, 3, 43, 395, DateTimeKind.Local).AddTicks(6451), new DateTime(2024, 11, 20, 16, 3, 43, 395, DateTimeKind.Local).AddTicks(6453), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 20, 16, 3, 43, 395, DateTimeKind.Local).AddTicks(6627), new DateTime(2024, 11, 20, 16, 3, 43, 395, DateTimeKind.Local).AddTicks(6629), "i4", "System" },
                    { 2, "System", new DateTime(2024, 11, 20, 16, 3, 43, 395, DateTimeKind.Local).AddTicks(6631), new DateTime(2024, 11, 20, 16, 3, 43, 395, DateTimeKind.Local).AddTicks(6632), "X5", "System" },
                    { 3, "System", new DateTime(2024, 11, 20, 16, 3, 43, 395, DateTimeKind.Local).AddTicks(6635), new DateTime(2024, 11, 20, 16, 3, 43, 395, DateTimeKind.Local).AddTicks(6636), "Prius", "System" },
                    { 4, "System", new DateTime(2024, 11, 20, 16, 3, 43, 395, DateTimeKind.Local).AddTicks(6639), new DateTime(2024, 11, 20, 16, 3, 43, 395, DateTimeKind.Local).AddTicks(6640), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
