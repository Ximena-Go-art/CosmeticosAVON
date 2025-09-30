using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class asignCategorias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Categoria",
                table: "Productos",
                newName: "TipoCategoriaId");

            migrationBuilder.AlterColumn<decimal>(
                name: "Precio",
                table: "Productos",
                type: "decimal(65,30)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)");

            migrationBuilder.AddColumn<int>(
                name: "categoriaId",
                table: "Productos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "Id", "IsDeleted", "Nombre" },
                values: new object[,]
                {
                    { 1, false, "Perfumería" },
                    { 2, false, "Cuidado de la piel" },
                    { 3, false, "Maquillaje" },
                    { 4, false, "Cuidado del cabello" },
                    { 5, false, "Cuidado corporal" }
                });

            migrationBuilder.UpdateData(
                table: "MenuRoles",
                keyColumn: "Id",
                keyValue: 9,
                column: "Rol",
                value: 3);

            migrationBuilder.UpdateData(
                table: "MenuRoles",
                keyColumn: "Id",
                keyValue: 10,
                column: "Rol",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Descripcion", "Nombre", "Stock", "TipoCategoriaId", "categoriaId" },
                values: new object[] { "Perfume floral", "Prefume", 50, 1, null });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Descripcion", "Nombre", "Stock", "TipoCategoriaId", "categoriaId" },
                values: new object[] { "Crema hidratante", "Crema", 30, 2, null });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Descripcion", "Nombre", "Precio", "Stock", "TipoCategoriaId", "categoriaId" },
                values: new object[] { "Labial rojo", "Labial", 18000m, 20, 3, null });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Descripcion", "Nombre", "Precio", "Stock", "categoriaId" },
                values: new object[] { "Paleta de sombras", "Sombras", 30000m, 15, null });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Descripcion", "Nombre", "Precio", "Stock", "TipoCategoriaId", "categoriaId" },
                values: new object[] { "Esmalte de uñas", "Esmalte", 22000m, 25, 3, null });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "id",
                keyValue: 4,
                column: "Rol",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "id",
                keyValue: 5,
                column: "Rol",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2025, 9, 30, 17, 54, 27, 315, DateTimeKind.Local).AddTicks(8326));

            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "Id",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2025, 9, 30, 17, 54, 27, 315, DateTimeKind.Local).AddTicks(8335));

            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "Id",
                keyValue: 3,
                column: "Fecha",
                value: new DateTime(2025, 9, 30, 17, 54, 27, 315, DateTimeKind.Local).AddTicks(8338));

            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "Id",
                keyValue: 4,
                column: "Fecha",
                value: new DateTime(2025, 9, 30, 17, 54, 27, 315, DateTimeKind.Local).AddTicks(8341));

            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "Id",
                keyValue: 5,
                column: "Fecha",
                value: new DateTime(2025, 9, 30, 17, 54, 27, 315, DateTimeKind.Local).AddTicks(8346));

            migrationBuilder.CreateIndex(
                name: "IX_Productos_categoriaId",
                table: "Productos",
                column: "categoriaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Categorias_categoriaId",
                table: "Productos",
                column: "categoriaId",
                principalTable: "Categorias",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Categorias_categoriaId",
                table: "Productos");

            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropIndex(
                name: "IX_Productos_categoriaId",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "categoriaId",
                table: "Productos");

            migrationBuilder.RenameColumn(
                name: "TipoCategoriaId",
                table: "Productos",
                newName: "Categoria");

            migrationBuilder.AlterColumn<decimal>(
                name: "Precio",
                table: "Productos",
                type: "decimal(10,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)");

            migrationBuilder.UpdateData(
                table: "MenuRoles",
                keyColumn: "Id",
                keyValue: 9,
                column: "Rol",
                value: 4);

            migrationBuilder.UpdateData(
                table: "MenuRoles",
                keyColumn: "Id",
                keyValue: 10,
                column: "Rol",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Categoria", "Descripcion", "Nombre", "Stock" },
                values: new object[] { 4, "Crema para hidratar la piel", "Crema Hidratante", 100 });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Categoria", "Descripcion", "Nombre", "Stock" },
                values: new object[] { 1, "Efecto mate", "Labial liquido", 150 });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Categoria", "Descripcion", "Nombre", "Precio", "Stock" },
                values: new object[] { 2, "Estilo highlight", "Sombras", 18.00m, 120 });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Descripcion", "Nombre", "Precio", "Stock" },
                values: new object[] { "Efecto cracheado", "Esmalte de uñas", 30.00m, 80 });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Categoria", "Descripcion", "Nombre", "Precio", "Stock" },
                values: new object[] { 0, "De estilo floral", "Perfume", 22.00m, 90 });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "id",
                keyValue: 4,
                column: "Rol",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "id",
                keyValue: 5,
                column: "Rol",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2025, 9, 24, 19, 4, 51, 621, DateTimeKind.Local).AddTicks(9416));

            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "Id",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2025, 9, 24, 19, 4, 51, 621, DateTimeKind.Local).AddTicks(9426));

            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "Id",
                keyValue: 3,
                column: "Fecha",
                value: new DateTime(2025, 9, 24, 19, 4, 51, 621, DateTimeKind.Local).AddTicks(9429));

            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "Id",
                keyValue: 4,
                column: "Fecha",
                value: new DateTime(2025, 9, 24, 19, 4, 51, 621, DateTimeKind.Local).AddTicks(9432));

            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "Id",
                keyValue: 5,
                column: "Fecha",
                value: new DateTime(2025, 9, 24, 19, 4, 51, 621, DateTimeKind.Local).AddTicks(9435));
        }
    }
}
