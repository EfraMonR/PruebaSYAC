using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Domain.Entities
{
    public class ProductoPedido
    {
        [Key]
        public int IdProductoPedido { get; set; }
        public int IdProducto { get; set; }
        public int IdPedido { get; set; }
        public decimal ValorUnitario { get; set; }
        public int Cantidad { get; set; }
    }
}
