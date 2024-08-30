using AutoMapper;
using Backend.Application.Contracts.Infraestructure;
using Backend.Application.Contracts.Persistence;
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

        public ServiceOrder(IMapper mapper, IAsyncRepository<Producto> productsRepository)
        {
            _mapper = mapper;
            _productsRepository = productsRepository;
        }

        public async Task<List<ResponseGetProducsListQueryVm>> GetAllProducts()
        {
            var products = await _productsRepository.ListAllAsync();
            return _mapper.Map<List<ResponseGetProducsListQueryVm>>(products);
        }
    }


}
