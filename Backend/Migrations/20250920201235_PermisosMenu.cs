using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class PermisosMenu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MenuRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "MenuId", "Rol" },
                values: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "MenuRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "MenuId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "MenuRoles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "MenuId", "Rol" },
                values: new object[] { 4, 1 });

            migrationBuilder.UpdateData(
                table: "MenuRoles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "MenuId", "Rol" },
                values: new object[] { 1, 2 });

            migrationBuilder.UpdateData(
                table: "MenuRoles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "MenuId", "Rol" },
                values: new object[] { 2, 2 });

            migrationBuilder.InsertData(
                table: "MenuRoles",
                columns: new[] { "Id", "IsDeleted", "MenuId", "Rol" },
                values: new object[,]
                {
                    { 7, false, 3, 2 },
                    { 8, false, 1, 4 },
                    { 9, false, 2, 4 },
                    { 10, false, 4, 4 }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "Id", "Descripcion", "IsDeleted", "Nombre" },
                values: new object[,]
                {
                    { 5, "Gestión de usuarios del sistema", false, "Usuarios" },
                    { 6, "Detalles de las ventas", false, "Detalles de Venta" }
                });

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

            migrationBuilder.InsertData(
                table: "MenuRoles",
                columns: new[] { "Id", "IsDeleted", "MenuId", "Rol" },
                values: new object[,]
                {
                    { 11, false, 5, 1 },
                    { 12, false, 6, 1 },
                    { 13, false, 6, 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MenuRoles",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "MenuRoles",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "MenuRoles",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "MenuRoles",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "MenuRoles",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "MenuRoles",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "MenuRoles",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "MenuRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "MenuId", "Rol" },
                values: new object[] { 1, 2 });

            migrationBuilder.UpdateData(
                table: "MenuRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "MenuId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "MenuRoles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "MenuId", "Rol" },
                values: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "MenuRoles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "MenuId", "Rol" },
                values: new object[] { 3, 1 });

            migrationBuilder.UpdateData(
                table: "MenuRoles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "MenuId", "Rol" },
                values: new object[] { 4, 4 });

            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2025, 9, 20, 14, 0, 50, 218, DateTimeKind.Local).AddTicks(310));

            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "Id",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2025, 9, 20, 14, 0, 50, 218, DateTimeKind.Local).AddTicks(319));

            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "Id",
                keyValue: 3,
                column: "Fecha",
                value: new DateTime(2025, 9, 20, 14, 0, 50, 218, DateTimeKind.Local).AddTicks(322));

            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "Id",
                keyValue: 4,
                column: "Fecha",
                value: new DateTime(2025, 9, 20, 14, 0, 50, 218, DateTimeKind.Local).AddTicks(325));

            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "Id",
                keyValue: 5,
                column: "Fecha",
                value: new DateTime(2025, 9, 20, 14, 0, 50, 218, DateTimeKind.Local).AddTicks(328));
        }
    }
}
