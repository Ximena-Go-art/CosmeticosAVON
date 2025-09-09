using Service.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
        public TiposCategoriaEnums Categoria { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public bool IsDeleted { get; set; } = false;
        public string Marca { get; set; } = string.Empty;


        public override string ToString()
        {
            return $"{Nombre} - {Precio:C}";
        }
    }
}
