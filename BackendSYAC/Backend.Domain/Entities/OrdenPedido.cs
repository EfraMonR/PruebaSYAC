using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Domain.Entities
{
    public class OrdenPedido
    {
        [Key]
        public int IdPedido { get; set; }
        public int IdCliente { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int Estado { get; set; }
        public string DireccionEntrega { get; set; }
        public int Prioridad { get; set; }
        public decimal ValorTotal { get; set; }
    }
}
