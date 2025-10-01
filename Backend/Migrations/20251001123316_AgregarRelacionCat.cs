using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class AgregarRelacionCat : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2025, 10, 1, 9, 33, 14, 891, DateTimeKind.Local).AddTicks(5986));

            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "Id",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2025, 10, 1, 9, 33, 14, 891, DateTimeKind.Local).AddTicks(5995));

            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "Id",
                keyValue: 3,
                column: "Fecha",
                value: new DateTime(2025, 10, 1, 9, 33, 14, 891, DateTimeKind.Local).AddTicks(5998));

            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "Id",
                keyValue: 4,
                column: "Fecha",
                value: new DateTime(2025, 10, 1, 9, 33, 14, 891, DateTimeKind.Local).AddTicks(6001));

            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "Id",
                keyValue: 5,
                column: "Fecha",
                value: new DateTime(2025, 10, 1, 9, 33, 14, 891, DateTimeKind.Local).AddTicks(6004));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2025, 10, 1, 9, 21, 21, 300, DateTimeKind.Local).AddTicks(814));

            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "Id",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2025, 10, 1, 9, 21, 21, 300, DateTimeKind.Local).AddTicks(827));

            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "Id",
                keyValue: 3,
                column: "Fecha",
                value: new DateTime(2025, 10, 1, 9, 21, 21, 300, DateTimeKind.Local).AddTicks(830));

            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "Id",
                keyValue: 4,
                column: "Fecha",
                value: new DateTime(2025, 10, 1, 9, 21, 21, 300, DateTimeKind.Local).AddTicks(833));

            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "Id",
                keyValue: 5,
                column: "Fecha",
                value: new DateTime(2025, 10, 1, 9, 21, 21, 300, DateTimeKind.Local).AddTicks(836));
        }
    }
}
