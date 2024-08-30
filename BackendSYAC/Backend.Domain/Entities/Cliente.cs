using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Domain.Entities
{
    public class Cliente
    {
        [Key]
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Identificacion { get; set; }
        public string Direccion { get; set; }
    }
}
