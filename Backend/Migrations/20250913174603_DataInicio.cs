using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class DataInicio : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
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
                    Correo = table.Column<string>(type: "longtext", nullable: false)
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
                    ProductoId = table.Column<int>(type: "int", nullable: false),
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
                    Fecha = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    PrecioTotal = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Estado = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ClienteId = table.Column<int>(type: "int", nullable: false),
                    VendedorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ventas", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "Id", "Categoria", "Descripcion", "IsDeleted", "Nombre", "Precio", "Stock" },
                values: new object[,]
                {
                    { 1, 0, "Un aroma fresco y duradero.", false, "Perfume Avon", 299.99m, 50 },
                    { 2, 1, "Color intenso y humectante.", false, "Labial Avon", 49.99m, 100 },
                    { 3, 4, "Hidratación profunda para todo el día.", false, "Crema Hidratante Avon", 89.99m, 75 },
                    { 4, 2, "Colores vibrantes y duraderos.", false, "Sombra de Ojos Avon", 59.99m, 80 },
                    { 5, 3, "Acabado brillante y secado rápido.", false, "Esmalte de Uñas Avon", 39.99m, 120 }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "Correo", "IsDeleted", "Nombre", "Password", "Rol" },
                values: new object[,]
                {
                    { 1, "juancho@gmail.com", false, "Juan", "juan123", 1 },
                    { 2, "mariana@gmail.com", false, "Maria", "maria123", 2 },
                    { 3, "estrellademar@gmail.com", false, "Patricio", "patry123", 4 },
                    { 4, "annita@gmail.com", false, "Ana", "anne1223", 3 }
                });

            migrationBuilder.InsertData(
                table: "VentaDetalles",
                columns: new[] { "Id", "Cantidad", "IsDeleted", "PrecioUnitario", "ProductoId", "VentaId" },
                values: new object[,]
                {
                    { 1, 2, false, 299.99m, 1, 1 },
                    { 2, 1, false, 49.99m, 2, 1 },
                    { 3, 1, false, 89.99m, 3, 1 },
                    { 4, 2, false, 59.99m, 4, 2 }
                });

            migrationBuilder.InsertData(
                table: "Ventas",
                columns: new[] { "Id", "ClienteId", "Estado", "Fecha", "IsDeleted", "PrecioTotal", "VendedorId" },
                values: new object[,]
                {
                    { 1, 3, "pagada", new DateTime(2025, 9, 13, 14, 46, 1, 328, DateTimeKind.Local).AddTicks(9198), false, 739.96m, 2 },
                    { 2, 3, "pendiente", new DateTime(2025, 9, 13, 14, 46, 1, 328, DateTimeKind.Local).AddTicks(9208), false, 159.98m, 2 },
                    { 3, 3, "enviada", new DateTime(2025, 9, 13, 14, 46, 1, 328, DateTimeKind.Local).AddTicks(9211), false, 39.99m, 2 },
                    { 4, 3, "cancelada", new DateTime(2025, 9, 13, 14, 46, 1, 328, DateTimeKind.Local).AddTicks(9217), false, 89.99m, 2 },
                    { 5, 3, "pagada", new DateTime(2025, 9, 13, 14, 46, 1, 328, DateTimeKind.Local).AddTicks(9219), false, 49.99m, 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "VentaDetalles");

            migrationBuilder.DropTable(
                name: "Ventas");
        }
    }
}
