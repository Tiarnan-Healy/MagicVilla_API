using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddUserTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsWebUser = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 4, 10, 10, 39, 52, 417, DateTimeKind.Local).AddTicks(4747), new DateTime(2025, 4, 10, 10, 39, 52, 417, DateTimeKind.Local).AddTicks(4793) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 4, 10, 10, 39, 52, 417, DateTimeKind.Local).AddTicks(4795), new DateTime(2025, 4, 10, 10, 39, 52, 417, DateTimeKind.Local).AddTicks(4797) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 4, 10, 10, 39, 52, 417, DateTimeKind.Local).AddTicks(4799), new DateTime(2025, 4, 10, 10, 39, 52, 417, DateTimeKind.Local).AddTicks(4800) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 4, 10, 10, 39, 52, 417, DateTimeKind.Local).AddTicks(4802), new DateTime(2025, 4, 10, 10, 39, 52, 417, DateTimeKind.Local).AddTicks(4803) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 4, 10, 10, 39, 52, 417, DateTimeKind.Local).AddTicks(4805), new DateTime(2025, 4, 10, 10, 39, 52, 417, DateTimeKind.Local).AddTicks(4807) });
        }
    }
}
