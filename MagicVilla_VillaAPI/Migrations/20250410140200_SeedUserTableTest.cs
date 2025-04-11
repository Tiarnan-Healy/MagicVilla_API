using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserTableTest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 4, 10, 15, 2, 0, 535, DateTimeKind.Local).AddTicks(5997), new DateTime(2025, 4, 10, 15, 2, 0, 535, DateTimeKind.Local).AddTicks(5998) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedDate", "IsWebUser", "Password", "UpdatedDate", "Username" },
                values: new object[] { 2, new DateTime(2025, 4, 10, 15, 2, 0, 535, DateTimeKind.Local).AddTicks(6005), false, "admin123", new DateTime(2025, 4, 10, 15, 2, 0, 535, DateTimeKind.Local).AddTicks(6006), "admin2" });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 4, 10, 15, 2, 0, 535, DateTimeKind.Local).AddTicks(5850), new DateTime(2025, 4, 10, 15, 2, 0, 535, DateTimeKind.Local).AddTicks(5891) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 4, 10, 15, 2, 0, 535, DateTimeKind.Local).AddTicks(5894), new DateTime(2025, 4, 10, 15, 2, 0, 535, DateTimeKind.Local).AddTicks(5895) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 4, 10, 15, 2, 0, 535, DateTimeKind.Local).AddTicks(5898), new DateTime(2025, 4, 10, 15, 2, 0, 535, DateTimeKind.Local).AddTicks(5899) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 4, 10, 15, 2, 0, 535, DateTimeKind.Local).AddTicks(5901), new DateTime(2025, 4, 10, 15, 2, 0, 535, DateTimeKind.Local).AddTicks(5902) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 4, 10, 15, 2, 0, 535, DateTimeKind.Local).AddTicks(5904), new DateTime(2025, 4, 10, 15, 2, 0, 535, DateTimeKind.Local).AddTicks(5905) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Users");

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
    }
}
