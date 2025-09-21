using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class CambiosId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MenuRoles",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "MenuRoles",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Usuarios",
                newName: "id");

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 4,
                column: "Nombre",
                value: "Historial");

            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2025, 9, 20, 23, 49, 17, 887, DateTimeKind.Local).AddTicks(5722));

            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "Id",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2025, 9, 20, 23, 49, 17, 887, DateTimeKind.Local).AddTicks(5732));

            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "Id",
                keyValue: 3,
                column: "Fecha",
                value: new DateTime(2025, 9, 20, 23, 49, 17, 887, DateTimeKind.Local).AddTicks(5735));

            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "Id",
                keyValue: 4,
                column: "Fecha",
                value: new DateTime(2025, 9, 20, 23, 49, 17, 887, DateTimeKind.Local).AddTicks(5738));

            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "Id",
                keyValue: 5,
                column: "Fecha",
                value: new DateTime(2025, 9, 20, 23, 49, 17, 887, DateTimeKind.Local).AddTicks(5741));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id",
                table: "Usuarios",
                newName: "Id");

            migrationBuilder.InsertData(
                table: "MenuRoles",
                columns: new[] { "Id", "IsDeleted", "MenuId", "Rol" },
                values: new object[,]
                {
                    { 7, false, 3, 2 },
                    { 8, false, 1, 4 }
                });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 4,
                column: "Nombre",
                value: "Mis Compras");

            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2025, 9, 20, 17, 12, 32, 969, DateTimeKind.Local).AddTicks(2746));

            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "Id",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2025, 9, 20, 17, 12, 32, 969, DateTimeKind.Local).AddTicks(2759));

            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "Id",
                keyValue: 3,
                column: "Fecha",
                value: new DateTime(2025, 9, 20, 17, 12, 32, 969, DateTimeKind.Local).AddTicks(2762));

            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "Id",
                keyValue: 4,
                column: "Fecha",
                value: new DateTime(2025, 9, 20, 17, 12, 32, 969, DateTimeKind.Local).AddTicks(2765));

            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "Id",
                keyValue: 5,
                column: "Fecha",
                value: new DateTime(2025, 9, 20, 17, 12, 32, 969, DateTimeKind.Local).AddTicks(2768));
        }
    }
}
