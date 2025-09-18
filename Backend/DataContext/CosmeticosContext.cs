using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using Service.Enums;
using Service.Models;


namespace Backend.DataContext
{
    public class CosmeticosContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Venta> Ventas { get; set; }
        public DbSet<VentaDetalle> VentaDetalles { get; set; }
        public CosmeticosContext()
        {
            //constructor sin parametros
        }
        public CosmeticosContext(DbContextOptions<CosmeticosContext> options) : base(options)
        {
            //toma un argumento que se utiliza para configurar el contexto de la base de datos.
        }

        //onconfiguring
        // se utiliza para configurar el contexto de la base de datos.
        // onConfiguring method to set up the database connection
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .Build();
                var connectionString = configuration.GetConnectionString("mysqlRemote");
                optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Venta>().HasData(
                new Venta
                {
                    Id = 1,
                    Fecha = DateTime.Now,
                    PrecioTotal = 739.96m,
                    Estado = "pagada",
                    ClienteId = 3,
                    VendedorId = 2,

                },
                new Venta
                {
                    Id = 2,
                    Fecha = DateTime.Now,
                    PrecioTotal = 159.98m,
                    Estado = "pendiente",
                    ClienteId = 3,
                    VendedorId = 2,
                },
                new Venta
                {
                    Id = 3,
                    Fecha = DateTime.Now,
                    PrecioTotal = 39.99m,
                    Estado = "enviada",
                    ClienteId = 3,
                    VendedorId = 2,
                },
                new Venta
                {
                    Id = 4,
                    Fecha = DateTime.Now,
                    PrecioTotal = 89.99m,
                    Estado = "cancelada",
                    ClienteId = 3,
                    VendedorId = 2,
                },
                new Venta
                {
                    Id = 5,
                    Fecha = DateTime.Now,
                    PrecioTotal = 49.99m,
                    Estado = "pagada",
                    ClienteId = 3,
                    VendedorId = 2,
                }
                );

            modelBuilder.Entity<Producto>().HasData(
                new Producto
                {
                    Id = 1,
                    Nombre = "Perfume Avon",
                    Descripcion = "Un aroma fresco y duradero.",
                    Precio = 299.99m,
                    Stock = 50,
                },
                new Producto
                {
                    Id = 2,
                    Nombre = "Labial Avon",
                    Descripcion = "Color intenso y humectante.",
                    Precio = 49.99m,
                    Stock = 100,
                    Categoria = TiposCategoriaEnums.Labial,
                },
                new Producto
                {
                    Id = 3,
                    Nombre = "Crema Hidratante Avon",
                    Descripcion = "Hidratación profunda para todo el día.",
                    Precio = 89.99m,
                    Stock = 75,
                    Categoria = TiposCategoriaEnums.Crema,
                },
                new Producto
                {
                    Id = 4,
                    Nombre = "Sombra de Ojos Avon",
                    Descripcion = "Colores vibrantes y duraderos.",
                    Precio = 59.99m,
                    Stock = 80,
                    Categoria = TiposCategoriaEnums.Sombras,
                },
                new Producto
                {
                    Id = 5,
                    Nombre = "Esmalte de Uñas Avon",
                    Descripcion = "Acabado brillante y secado rápido.",
                    Precio = 39.99m,
                    Stock = 120,
                    Categoria = TiposCategoriaEnums.Esmaltes,
                });
            modelBuilder.Entity<VentaDetalle>().HasData(
                new VentaDetalle
                {
                    Id = 1,
                    VentaId = 1,
                    ProductoId = 1,
                    Cantidad = 2,
                    PrecioUnitario = 299.99m,
                },
                new VentaDetalle
                {
                    Id = 2,
                    VentaId = 1,
                    ProductoId = 2,
                    Cantidad = 1,
                    PrecioUnitario = 49.99m,
                },
                new VentaDetalle
                {
                    Id = 3,
                    VentaId = 1,
                    ProductoId = 3,
                    Cantidad = 1,
                    PrecioUnitario = 89.99m,
                
                },
                new VentaDetalle
                {
                    Id = 4,
                    VentaId = 2,
                    ProductoId = 4,
                    Cantidad = 2,
                    PrecioUnitario = 59.99m,
                }
                );

            modelBuilder.Entity<Usuario>().HasData(
                new Usuario
                {
                    Id = 1,
                    Nombre = "Juan",
                    Correo = "juancho@gmail.com",
                    Password = "juan123",
                    Rol = RolEnum.Administrador,

                },
                 new Usuario
                 {
                     Id = 2,
                     Nombre = "Maria",
                     Correo = "mariana@gmail.com",
                     Password = "maria123",
                     Rol = RolEnum.Vendedor,
                 },
                  new Usuario
                  {
                      Id = 3,
                      Nombre = "Patricio",
                      Correo = "estrellademar@gmail.com",
                      Password= "patry123",
                      Rol = RolEnum.Cliente,
                  },
                  new Usuario
                  {
                      Id = 4,
                      Nombre = "Ana",
                      Correo = "annita@gmail.com",
                      Password = "anne1223",
                      Rol = RolEnum.Proveedor,
                  }
                  );




            modelBuilder.Entity<Venta>().HasQueryFilter(v => !v.IsDeleted);
            modelBuilder.Entity<Producto>().HasQueryFilter(p => !p.IsDeleted);
            modelBuilder.Entity<Usuario>().HasQueryFilter(u => !u.IsDeleted);
            modelBuilder.Entity<VentaDetalle>().HasQueryFilter(vd => !vd.IsDeleted);

        }
        

    }
}



