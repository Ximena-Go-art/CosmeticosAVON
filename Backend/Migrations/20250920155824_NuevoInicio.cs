using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class NuevoInicio : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Menu",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descripcion = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menu", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descripcion = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Categoria = table.Column<int>(type: "int", nullable: false),
                    Precio = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Password = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Rol = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "VentaDetalles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    VentaId = table.Column<int>(type: "int", nullable: false),
                    ProductoNombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    PrecioUnitario = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VentaDetalles", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Ventas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Fecha = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    PrecioTotal = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ventas", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MenuRol",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    menuId = table.Column<int>(type: "int", nullable: false),
                    Rol = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuRol", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MenuRol_Menu_menuId",
                        column: x => x.menuId,
                        principalTable: "Menu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "Id", "Categoria", "Descripcion", "IsDeleted", "Nombre", "Precio", "Stock" },
                values: new object[,]
                {
                    { 1, 4, "Crema para hidratar la piel", false, "Crema Hidratante", 32000m, 100 },
                    { 2, 1, "Efecto mate", false, "Labial liquido", 12000m, 150 },
                    { 3, 2, "Estilo highlight", false, "Sombras", 18.00m, 120 },
                    { 4, 3, "Efecto cracheado", false, "Esmalte de uñas", 30.00m, 80 },
                    { 5, 0, "De estilo floral", false, "Perfume", 22.00m, 90 }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "Email", "IsDeleted", "Nombre", "Password", "Rol" },
                values: new object[,]
                {
                    { 1, "amada@gmail.com", false, "Amanda", "amanda123", 1 },
                    { 2, "pedro@gmail.com", false, "Pedro", "pedro123", 2 },
                    { 3, "maria@gmail.com", false, "Maria", "maria123", 2 },
                    { 4, "luisa@gmail.com", false, "Luisa", "luisa123", 4 },
                    { 5, "carlos@gmail.com", false, "Carlos", "carlos123", 4 },
                    { 6, "juana@gmail.com", false, "Juana", "juana123", 2 }
                });

            migrationBuilder.InsertData(
                table: "VentaDetalles",
                columns: new[] { "Id", "Cantidad", "IsDeleted", "PrecioUnitario", "ProductoNombre", "VentaId" },
                values: new object[,]
                {
                    { 1, 2, false, 32000m, "Prefume", 1 },
                    { 2, 1, false, 12000m, "Crema", 1 },
                    { 3, 3, false, 18000m, "Labial", 2 },
                    { 4, 1, false, 30000m, "Sombras", 2 },
                    { 5, 2, false, 22000m, "Esmalte", 3 }
                });

            migrationBuilder.InsertData(
                table: "Ventas",
                columns: new[] { "Id", "Estado", "Fecha", "IsDeleted", "Nombre", "PrecioTotal" },
                values: new object[,]
                {
                    { 1, 2, new DateTime(2025, 9, 20, 12, 58, 22, 506, DateTimeKind.Local).AddTicks(7227), false, "", 150.00m },
                    { 2, 1, new DateTime(2025, 9, 20, 12, 58, 22, 506, DateTimeKind.Local).AddTicks(7238), false, "", 200.00m },
                    { 3, 3, new DateTime(2025, 9, 20, 12, 58, 22, 506, DateTimeKind.Local).AddTicks(7241), false, "", 300.00m },
                    { 4, 2, new DateTime(2025, 9, 20, 12, 58, 22, 506, DateTimeKind.Local).AddTicks(7244), false, "", 400.00m },
                    { 5, 1, new DateTime(2025, 9, 20, 12, 58, 22, 506, DateTimeKind.Local).AddTicks(7247), false, "", 500.00m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_MenuRol_menuId",
                table: "MenuRol",
                column: "menuId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MenuRol");

            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "VentaDetalles");

            migrationBuilder.DropTable(
                name: "Ventas");

            migrationBuilder.DropTable(
                name: "Menu");
        }
    }
}
