using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Application.Features.Clients.Queries.GetClientsList
{
    public class GetClientsListQuery : IRequest<List<ResponseGetClientsListQueryVm>>
    {
    }
}
