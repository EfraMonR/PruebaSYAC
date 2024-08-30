using Backend.Application.Features.Clients.Queries.GetClientsList;
using Backend.Application.Features.Products.Queries.GetProductsList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Application.Contracts.Infraestructure
{
    public interface IServiceOrder<T> : IApiService<T> where T : class
    {
        Task<List<ResponseGetClientsListQueryVm>> GetAllClients();
        Task<List<ResponseGetProducsListQueryVm>> GetAllProducts();
    }
}
