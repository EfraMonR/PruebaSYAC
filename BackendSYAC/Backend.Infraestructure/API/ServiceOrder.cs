using Backend.Application.Contracts.Infraestructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Infraestructure.API
{
    public class ServiceOrder<T> : IServiceOrder<T> where T : class
    {
    }
}
