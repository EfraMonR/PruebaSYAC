using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Domain.Entities
{
    public class Producto
    {
        [Key]
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public decimal ValorUnitario { get; set; }
    }
}
