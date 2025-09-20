using Service.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Models
{
    public class VentaDetalle
    {
        public int Id { get; set; }
        public int VentaId { get; set; }
        public string ProductoNombre { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal PrecioTotal => Cantidad * PrecioUnitario;
        public bool IsDeleted { get; set; } = false;


        public override string ToString()
        {
            return $"Se vendio: {ProductoNombre}, Cant: {Cantidad}, Precio: {PrecioUnitario:C}";
        }
    }
}
