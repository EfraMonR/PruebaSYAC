using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Application.Features.Clients.Queries.GetClientsList
{
    public class ResponseGetClientsListQueryVm
    {
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Identificacion { get; set; }
        public string Direccion { get; set; }
    }
}
