using Service.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Models
{
    public class Venta
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public DateTime Fecha { get; set; } = DateTime.Now;//muestra la fecha a la hora de realizar la venta
        public decimal PrecioTotal { get; set; }
        public EstadoEnum Estado { get; set; } = EstadoEnum.Pendiente;
        public bool IsDeleted { get; set; } = false;
       

        public override string ToString()
        {
            return $"Venta #{Id} - Total: {PrecioTotal:C} - Estado: {Estado} - Realizada por: {Nombre}";
        }
    }
}
    
