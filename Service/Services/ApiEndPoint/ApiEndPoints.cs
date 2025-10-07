using Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.ApiEndPoint
{
    public static class ApiEndPoints
    {
        public static string Producto { get; set; } = "productos";
        public static string Usuario { get; set; } = "usuarios";
        public static string Venta { get; set; } = "ventas";
        public static string VentaDetalle { get; set; } = "ventadetalles";
        public static string Categoria { get; set; } = "categorias";

        public static string GetEndpoint(string name)
        {
            return name switch
            {
                nameof(Producto) => Producto,
                nameof(Usuario) => Usuario,
                nameof(Venta) => Venta,
                nameof(VentaDetalle) => VentaDetalle,
                nameof(Categoria) => Categoria,

                _ => throw new ArgumentException($"Endpoint '{name}' no está definido.")
            };
        }
    }
}
