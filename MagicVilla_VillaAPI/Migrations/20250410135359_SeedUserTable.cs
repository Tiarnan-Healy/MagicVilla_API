using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "IsWebUser", "Password", "Username" },
                values: new object[] { 1, true, "admin123", "admin" });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 4, 10, 14, 53, 59, 564, DateTimeKind.Local).AddTicks(5148), new DateTime(2025, 4, 10, 14, 53, 59, 564, DateTimeKind.Local).AddTicks(5191) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 4, 10, 14, 53, 59, 564, DateTimeKind.Local).AddTicks(5194), new DateTime(2025, 4, 10, 14, 53, 59, 564, DateTimeKind.Local).AddTicks(5195) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 4, 10, 14, 53, 59, 564, DateTimeKind.Local).AddTicks(5198), new DateTime(2025, 4, 10, 14, 53, 59, 564, DateTimeKind.Local).AddTicks(5199) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 4, 10, 14, 53, 59, 564, DateTimeKind.Local).AddTicks(5201), new DateTime(2025, 4, 10, 14, 53, 59, 564, DateTimeKind.Local).AddTicks(5202) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 4, 10, 14, 53, 59, 564, DateTimeKind.Local).AddTicks(5204), new DateTime(2025, 4, 10, 14, 53, 59, 564, DateTimeKind.Local).AddTicks(5205) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 4, 10, 13, 36, 43, 812, DateTimeKind.Local).AddTicks(7087), new DateTime(2025, 4, 10, 13, 36, 43, 812, DateTimeKind.Local).AddTicks(7130) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 4, 10, 13, 36, 43, 812, DateTimeKind.Local).AddTicks(7133), new DateTime(2025, 4, 10, 13, 36, 43, 812, DateTimeKind.Local).AddTicks(7134) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 4, 10, 13, 36, 43, 812, DateTimeKind.Local).AddTicks(7136), new DateTime(2025, 4, 10, 13, 36, 43, 812, DateTimeKind.Local).AddTicks(7137) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 4, 10, 13, 36, 43, 812, DateTimeKind.Local).AddTicks(7139), new DateTime(2025, 4, 10, 13, 36, 43, 812, DateTimeKind.Local).AddTicks(7140) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 4, 10, 13, 36, 43, 812, DateTimeKind.Local).AddTicks(7142), new DateTime(2025, 4, 10, 13, 36, 43, 812, DateTimeKind.Local).AddTicks(7144) });
        }
    }
}
