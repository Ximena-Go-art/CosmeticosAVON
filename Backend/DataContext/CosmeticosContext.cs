using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
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
        public DbSet<Menu> Menus { get; set; }
        public DbSet<MenuRol> MenuRoles { get; set; }
        public DbSet<Categoria> Categorias { get; set; }

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
              new Venta { Id = 1, Nombre = "", Fecha = DateTime.Now, PrecioTotal = 150.00m, Estado = EstadoEnum.Pagado, IsDeleted = false },
                new Venta { Id = 2, Nombre = "", Fecha = DateTime.Now, PrecioTotal = 200.00m, Estado = EstadoEnum.Pendiente, IsDeleted = false },
                new Venta { Id = 3, Nombre = "", Fecha = DateTime.Now, PrecioTotal = 300.00m, Estado = EstadoEnum.Cancelada, IsDeleted = false },
                new Venta
                {
                    Id = 4,
                    Nombre = "",
                    Fecha = DateTime.Now,
                    PrecioTotal = 400.00m,
                    Estado = EstadoEnum.Pagado
                ,
                    IsDeleted = false
                },
                new Venta { Id = 5, Nombre = "", Fecha = DateTime.Now, PrecioTotal = 500.00m, Estado = EstadoEnum.Pendiente, IsDeleted = false }
                );
            modelBuilder.Entity<Categoria>().HasData(
               new Categoria { Id = 1, Nombre = "Perfumería", IsDeleted = false },
                new Categoria { Id = 2, Nombre = "Cuidado de la Piel", IsDeleted = false },
                new Categoria { Id = 3, Nombre = "Maquillaje", IsDeleted = false },
                new Categoria { Id = 4, Nombre = "Cuidado del Cabello", IsDeleted = false },
                new Categoria { Id = 5, Nombre = "Cuidado Corporal", IsDeleted = false }
                );
            modelBuilder.Entity<Producto>().HasData(
               new Producto { Id = 1, Nombre = "Perfume", Descripcion = "Perfume floral", CategoriaId = 1, Precio = 50000, Stock = 100, IsDeleted = false },
                new Producto { Id = 2, Nombre = "Crema Hidratante", Descripcion = "Crema para piel seca", CategoriaId = 2, Precio = 20000, Stock = 150, IsDeleted = false },
                new Producto { Id = 3, Nombre = "Labial", Descripcion = "Labial rojo intenso", CategoriaId = 3, Precio = 15000, Stock = 200, IsDeleted = false },
                new Producto { Id = 4, Nombre = "Champú", Descripcion = "Champú para cabello graso", CategoriaId = 4, Precio = 18000, Stock = 120, IsDeleted = false },
                new Producto { Id = 5, Nombre = "Exfoliante Corporal", Descripcion = "Exfoliante suave", CategoriaId = 5, Precio = 22000, Stock = 80, IsDeleted = false }
                );
            modelBuilder.Entity<Usuario>().HasData(
                new Usuario { id = 1, Nombre = "Amanda", Email = "amada@gmail.com", Password = "amanda123", Rol = Service.Enums.RolEnum.Administrador },
                new Usuario { id = 6, Nombre = "Juana", Email = "juana@gmail.com", Password = "juana123", Rol = Service.Enums.RolEnum.Vendedor },
                new Usuario { id = 2, Nombre = "Pedro", Email = "pedro@gmail.com", Password = "pedro123", Rol = Service.Enums.RolEnum.Vendedor },
                new Usuario
                {
                    id = 3,
                    Nombre = "Maria",
                    Email = "maria@gmail.com",
                    Password = "maria123",
                    Rol = Service.Enums.RolEnum.Vendedor
                },
                new Usuario
                {
                    id = 4,
                    Nombre = "Luisa",
                    Email = "luisa@gmail.com",
                    Password = "luisa123",
                    Rol = Service.Enums.RolEnum.Cliente
                },
                new Usuario { id = 5, Nombre = "Carlos", Email = "carlos@gmail.com", Password = "carlos123", Rol = Service.Enums.RolEnum.Cliente }
                );
            modelBuilder.Entity<VentaDetalle>().HasData(
                new VentaDetalle { Id = 1, VentaId = 1, ProductoNombre = "Prefume", Cantidad = 2, PrecioUnitario = 32000, IsDeleted = false },
                new VentaDetalle { Id = 2, VentaId = 1, ProductoNombre = "Crema", Cantidad = 1, PrecioUnitario = 12000, IsDeleted = false },
                new VentaDetalle { Id = 3, VentaId = 2, ProductoNombre = "Labial", Cantidad = 3, PrecioUnitario = 18000, IsDeleted = false },
                new VentaDetalle { Id = 4, VentaId = 2, ProductoNombre = "Sombras", Cantidad = 1, PrecioUnitario = 30000, IsDeleted = false },
                new VentaDetalle { Id = 5, VentaId = 3, ProductoNombre = "Esmalte", Cantidad = 2, PrecioUnitario = 22000, IsDeleted = false }
                );
            modelBuilder.Entity<Menu>().HasData(
                // Definición de menús 
                new Menu { Id = 1, Nombre = "Gestión de Ventas", Descripcion = "Acceso al módulo de ventas", IsDeleted = false },
                new Menu { Id = 2, Nombre = "Gestión de Productos", Descripcion = "Acceso al módulo de productos", IsDeleted = false },
                new Menu { Id = 3, Nombre = "Reportes", Descripcion = "Acceso a reportes del sistema", IsDeleted = false },
                new Menu { Id = 4, Nombre = "Historial", Descripcion = "Historial de compras del cliente", IsDeleted = false },
                new Menu { Id = 5, Nombre = "Usuarios", Descripcion = "Gestión de usuarios del sistema", IsDeleted = false },
                new Menu { Id = 6, Nombre = "Detalles de Venta", Descripcion = "Detalles de las ventas", IsDeleted = false }

                );
            modelBuilder.Entity<MenuRol>().HasData(
            // Administrador → acceso a todo
                new MenuRol { Id = 1, MenuId = 1, Rol = RolEnum.Administrador, IsDeleted = false },
                new MenuRol { Id = 2, MenuId = 2, Rol = RolEnum.Administrador, IsDeleted = false },
                new MenuRol { Id = 3, MenuId = 3, Rol = RolEnum.Administrador, IsDeleted = false },
                new MenuRol { Id = 4, MenuId = 4, Rol = RolEnum.Administrador, IsDeleted = false },
                new MenuRol { Id = 11, MenuId = 5, Rol = RolEnum.Administrador, IsDeleted = false },
                new MenuRol { Id = 12, MenuId = 6, Rol = RolEnum.Administrador, IsDeleted = false },

                // Vendedor → Productos, Ventas, Detalles de Venta
                new MenuRol { Id = 5, MenuId = 1, Rol = RolEnum.Vendedor, IsDeleted = false },
                new MenuRol { Id = 6, MenuId = 2, Rol = RolEnum.Vendedor, IsDeleted = false },
                new MenuRol { Id = 13, MenuId = 6, Rol = RolEnum.Vendedor, IsDeleted = false },

                 // Cliente → Productos, Ventas y Mis Compras
                 new MenuRol { Id = 9, MenuId = 2, Rol = RolEnum.Cliente, IsDeleted = false },
                 new MenuRol { Id = 10, MenuId = 4, Rol = RolEnum.Cliente, IsDeleted = false }
                );
            



            modelBuilder.Entity<Venta>().HasQueryFilter(v => !v.IsDeleted);
            modelBuilder.Entity<Producto>().HasQueryFilter(p => !p.IsDeleted);
            modelBuilder.Entity<Usuario>().HasQueryFilter(u => !u.IsDeleted);
            modelBuilder.Entity<VentaDetalle>().HasQueryFilter(vd => !vd.IsDeleted);
            modelBuilder.Entity<Menu>().HasQueryFilter(m => !m.IsDeleted);
            modelBuilder.Entity<MenuRol>().HasQueryFilter(mr => !mr.IsDeleted);
            modelBuilder.Entity<Categoria>().HasQueryFilter(c => !c.IsDeleted);

        } 
        

    }
}



