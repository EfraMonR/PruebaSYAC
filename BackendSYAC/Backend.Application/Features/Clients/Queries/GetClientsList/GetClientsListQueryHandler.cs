using Backend.Application.Contracts.Infraestructure;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Application.Features.Clients.Queries.GetClientsList
{
    public class GetClientsListQueryHandler : IRequestHandler<GetClientsListQuery, List<ResponseGetClientsListQueryVm>>
    {
        private readonly IServiceOrder<ResponseGetClientsListQueryVm> _operateService;

        public GetClientsListQueryHandler(IServiceOrder<ResponseGetClientsListQueryVm> operateService)
        {
            _operateService = operateService;
        }

        public async Task<List<ResponseGetClientsListQueryVm>> Handle(GetClientsListQuery request, CancellationToken cancellationToken)
        {
            List<ResponseGetClientsListQueryVm> response = new List<ResponseGetClientsListQueryVm>();
            try
            {
                response = await _operateService.GetAllClients();
                return response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
