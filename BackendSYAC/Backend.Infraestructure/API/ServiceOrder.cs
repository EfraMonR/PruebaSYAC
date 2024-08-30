using AutoMapper;
using Backend.Application.Contracts.Infraestructure;
using Backend.Application.Contracts.Persistence;
using Backend.Application.Features.Clients.Queries.GetClientsList;
using Backend.Application.Features.Products.Queries.GetProductsList;
using Backend.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Infraestructure.API
{
    public class ServiceOrder<T> : IServiceOrder<T> where T : class
    {
        private readonly IMapper _mapper;
        private IAsyncRepository<Producto> _productsRepository;
        private IAsyncRepository<Cliente> _clienteRepository;

        public ServiceOrder(IMapper mapper, 
            IAsyncRepository<Producto> productsRepository,
            IAsyncRepository<Cliente> clienteRepository)
        {
            _mapper = mapper;
            _productsRepository = productsRepository;
            _clienteRepository = clienteRepository;
        }

        public async Task<List<ResponseGetProducsListQueryVm>> GetAllProducts()
        {
            var products = await _productsRepository.ListAllAsync();
            return _mapper.Map<List<ResponseGetProducsListQueryVm>>(products);
        }

        public async Task<List<ResponseGetClientsListQueryVm>> GetAllClients()
        {
            var clients = await _clienteRepository.ListAllAsync();
            return _mapper.Map<List<ResponseGetClientsListQueryVm>>(clients);
        }
    }


}
