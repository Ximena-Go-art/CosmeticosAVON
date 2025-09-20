using Service.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Models
{
    public class MenuRol
    {
        public int Id { get; set; }
        public int MenuId { get; set; }
        public Menu menu { get; set; }
        public RolEnum Rol { get; set; } = RolEnum.Vendedor;
        public bool IsDeleted { get; set; } = false;

    }
}
