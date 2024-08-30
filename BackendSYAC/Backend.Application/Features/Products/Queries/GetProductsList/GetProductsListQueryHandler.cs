using Backend.Application.Contracts.Infraestructure;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Application.Features.Products.Queries.GetProductsList
{
    public class GetProductsListQueryHandler : IRequestHandler<GetProductsListQuery, List<ResponseGetProducsListQueryVm>>
    {
        private readonly IServiceOrder<ResponseGetProducsListQueryVm> _operateService;

        public GetProductsListQueryHandler(IServiceOrder<ResponseGetProducsListQueryVm> operateService)
        {
            _operateService = operateService;
        }

        public async Task<List<ResponseGetProducsListQueryVm>> Handle(GetProductsListQuery request, CancellationToken cancellationToken)
        {
            List<ResponseGetProducsListQueryVm> response = new List<ResponseGetProducsListQueryVm>();
            try
            {
                response = await _operateService.GetAllProducts();
                return response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
