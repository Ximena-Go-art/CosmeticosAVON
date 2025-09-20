using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class NuevaDataMenu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MenuRol_Menu_menuId",
                table: "MenuRol");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MenuRol",
                table: "MenuRol");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Menu",
                table: "Menu");

            migrationBuilder.RenameTable(
                name: "MenuRol",
                newName: "MenuRoles");

            migrationBuilder.RenameTable(
                name: "Menu",
                newName: "Menus");

            migrationBuilder.RenameColumn(
                name: "menuId",
                table: "MenuRoles",
                newName: "MenuId");

            migrationBuilder.RenameIndex(
                name: "IX_MenuRol_menuId",
                table: "MenuRoles",
                newName: "IX_MenuRoles_MenuId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MenuRoles",
                table: "MenuRoles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Menus",
                table: "Menus",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "Id", "Descripcion", "IsDeleted", "Nombre" },
                values: new object[,]
                {
                    { 1, "Acceso al módulo de ventas", false, "Gestión de Ventas" },
                    { 2, "Acceso al módulo de productos", false, "Gestión de Productos" },
                    { 3, "Acceso a reportes del sistema", false, "Reportes" },
                    { 4, "Historial de compras del cliente", false, "Mis Compras" }
                });

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

            migrationBuilder.InsertData(
                table: "MenuRoles",
                columns: new[] { "Id", "IsDeleted", "MenuId", "Rol" },
                values: new object[,]
                {
                    { 1, false, 1, 1 },
                    { 2, false, 1, 2 },
                    { 3, false, 2, 1 },
                    { 4, false, 2, 2 },
                    { 5, false, 3, 1 },
                    { 6, false, 4, 4 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_MenuRoles_Menus_MenuId",
                table: "MenuRoles",
                column: "MenuId",
                principalTable: "Menus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MenuRoles_Menus_MenuId",
                table: "MenuRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Menus",
                table: "Menus");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MenuRoles",
                table: "MenuRoles");

            migrationBuilder.DeleteData(
                table: "MenuRoles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MenuRoles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MenuRoles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MenuRoles",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MenuRoles",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "MenuRoles",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.RenameTable(
                name: "Menus",
                newName: "Menu");

            migrationBuilder.RenameTable(
                name: "MenuRoles",
                newName: "MenuRol");

            migrationBuilder.RenameColumn(
                name: "MenuId",
                table: "MenuRol",
                newName: "menuId");

            migrationBuilder.RenameIndex(
                name: "IX_MenuRoles_MenuId",
                table: "MenuRol",
                newName: "IX_MenuRol_menuId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Menu",
                table: "Menu",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MenuRol",
                table: "MenuRol",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2025, 9, 20, 12, 58, 22, 506, DateTimeKind.Local).AddTicks(7227));

            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "Id",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2025, 9, 20, 12, 58, 22, 506, DateTimeKind.Local).AddTicks(7238));

            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "Id",
                keyValue: 3,
                column: "Fecha",
                value: new DateTime(2025, 9, 20, 12, 58, 22, 506, DateTimeKind.Local).AddTicks(7241));

            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "Id",
                keyValue: 4,
                column: "Fecha",
                value: new DateTime(2025, 9, 20, 12, 58, 22, 506, DateTimeKind.Local).AddTicks(7244));

            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "Id",
                keyValue: 5,
                column: "Fecha",
                value: new DateTime(2025, 9, 20, 12, 58, 22, 506, DateTimeKind.Local).AddTicks(7247));

            migrationBuilder.AddForeignKey(
                name: "FK_MenuRol_Menu_menuId",
                table: "MenuRol",
                column: "menuId",
                principalTable: "Menu",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
