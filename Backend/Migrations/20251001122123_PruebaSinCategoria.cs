using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class PruebaSinCategoria : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

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

            migrationBuilder.CreateTable(
                name: "Menus",
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
                    table.PrimaryKey("PK_Menus", x => x.Id);
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
                    CategoriaId = table.Column<int>(type: "int", nullable: false),
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
                    id = table.Column<int>(type: "int", nullable: false)
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
                    table.PrimaryKey("PK_Usuarios", x => x.id);
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
                name: "MenuRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MenuId = table.Column<int>(type: "int", nullable: false),
                    Rol = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuRoles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MenuRoles_Menus_MenuId",
                        column: x => x.MenuId,
                        principalTable: "Menus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "Id", "IsDeleted", "Nombre" },
                values: new object[,]
                {
                    { 1, false, "Perfumería" },
                    { 2, false, "Cuidado de la Piel" },
                    { 3, false, "Maquillaje" },
                    { 4, false, "Cuidado del Cabello" },
                    { 5, false, "Cuidado Corporal" }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "Id", "Descripcion", "IsDeleted", "Nombre" },
                values: new object[,]
                {
                    { 1, "Acceso al módulo de ventas", false, "Gestión de Ventas" },
                    { 2, "Acceso al módulo de productos", false, "Gestión de Productos" },
                    { 3, "Acceso a reportes del sistema", false, "Reportes" },
                    { 4, "Historial de compras del cliente", false, "Historial" },
                    { 5, "Gestión de usuarios del sistema", false, "Usuarios" },
                    { 6, "Detalles de las ventas", false, "Detalles de Venta" }
                });

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "Id", "CategoriaId", "Descripcion", "IsDeleted", "Nombre", "Precio", "Stock" },
                values: new object[,]
                {
                    { 1, 1, "Perfume floral", false, "Perfume", 50000m, 100 },
                    { 2, 2, "Crema para piel seca", false, "Crema Hidratante", 20000m, 150 },
                    { 3, 3, "Labial rojo intenso", false, "Labial", 15000m, 200 },
                    { 4, 4, "Champú para cabello graso", false, "Champú", 18000m, 120 },
                    { 5, 5, "Exfoliante suave", false, "Exfoliante Corporal", 22000m, 80 }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "id", "Email", "IsDeleted", "Nombre", "Password", "Rol" },
                values: new object[,]
                {
                    { 1, "amada@gmail.com", false, "Amanda", "amanda123", 1 },
                    { 2, "pedro@gmail.com", false, "Pedro", "pedro123", 2 },
                    { 3, "maria@gmail.com", false, "Maria", "maria123", 2 },
                    { 4, "luisa@gmail.com", false, "Luisa", "luisa123", 3 },
                    { 5, "carlos@gmail.com", false, "Carlos", "carlos123", 3 },
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
                    { 1, 2, new DateTime(2025, 10, 1, 9, 21, 21, 300, DateTimeKind.Local).AddTicks(814), false, "", 150.00m },
                    { 2, 1, new DateTime(2025, 10, 1, 9, 21, 21, 300, DateTimeKind.Local).AddTicks(827), false, "", 200.00m },
                    { 3, 3, new DateTime(2025, 10, 1, 9, 21, 21, 300, DateTimeKind.Local).AddTicks(830), false, "", 300.00m },
                    { 4, 2, new DateTime(2025, 10, 1, 9, 21, 21, 300, DateTimeKind.Local).AddTicks(833), false, "", 400.00m },
                    { 5, 1, new DateTime(2025, 10, 1, 9, 21, 21, 300, DateTimeKind.Local).AddTicks(836), false, "", 500.00m }
                });

            migrationBuilder.InsertData(
                table: "MenuRoles",
                columns: new[] { "Id", "IsDeleted", "MenuId", "Rol" },
                values: new object[,]
                {
                    { 1, false, 1, 1 },
                    { 2, false, 2, 1 },
                    { 3, false, 3, 1 },
                    { 4, false, 4, 1 },
                    { 5, false, 1, 2 },
                    { 6, false, 2, 2 },
                    { 9, false, 2, 3 },
                    { 10, false, 4, 3 },
                    { 11, false, 5, 1 },
                    { 12, false, 6, 1 },
                    { 13, false, 6, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_MenuRoles_MenuId",
                table: "MenuRoles",
                column: "MenuId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropTable(
                name: "MenuRoles");

            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "VentaDetalles");

            migrationBuilder.DropTable(
                name: "Ventas");

            migrationBuilder.DropTable(
                name: "Menus");
        }
    }
}
