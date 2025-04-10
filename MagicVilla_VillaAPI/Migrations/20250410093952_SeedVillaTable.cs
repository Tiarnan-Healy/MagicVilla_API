using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicVilla_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedVillaTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenity", "CreatedDate", "Details", "ImageUrl", "Name", "Occupancy", "Rate", "SqFt", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "", new DateTime(2025, 4, 10, 10, 39, 52, 417, DateTimeKind.Local).AddTicks(4747), "Details about Royal Villa. Lorem ipsum dolor sit amet.", "", "Royal Villa", 5, 200.0, 550, new DateTime(2025, 4, 10, 10, 39, 52, 417, DateTimeKind.Local).AddTicks(4793) },
                    { 2, "", new DateTime(2025, 4, 10, 10, 39, 52, 417, DateTimeKind.Local).AddTicks(4795), "Details about Luxury Villa. Lorem ipsum dolor sit amet.", "", "Luxury Villa", 4, 150.0, 450, new DateTime(2025, 4, 10, 10, 39, 52, 417, DateTimeKind.Local).AddTicks(4797) },
                    { 3, "", new DateTime(2025, 4, 10, 10, 39, 52, 417, DateTimeKind.Local).AddTicks(4799), "Details about Deluxe Villa. Lorem ipsum dolor sit amet.", "", "Deluxe Villa", 3, 100.0, 350, new DateTime(2025, 4, 10, 10, 39, 52, 417, DateTimeKind.Local).AddTicks(4800) },
                    { 4, "", new DateTime(2025, 4, 10, 10, 39, 52, 417, DateTimeKind.Local).AddTicks(4802), "Details about Standard Villa. Lorem ipsum dolor sit amet.", "", "Standard Villa", 2, 80.0, 250, new DateTime(2025, 4, 10, 10, 39, 52, 417, DateTimeKind.Local).AddTicks(4803) },
                    { 5, "", new DateTime(2025, 4, 10, 10, 39, 52, 417, DateTimeKind.Local).AddTicks(4805), "Details about Premium Villa. Lorem ipsum dolor sit amet.", "", "Premium Villa", 6, 250.0, 600, new DateTime(2025, 4, 10, 10, 39, 52, 417, DateTimeKind.Local).AddTicks(4807) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
