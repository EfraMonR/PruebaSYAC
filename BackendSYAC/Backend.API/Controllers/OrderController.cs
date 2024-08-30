using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Backend.Application.Exceptions;
using Backend.Application.Features.Products.Queries.GetProductsList;
using Backend.Application.Features.Clients.Queries.GetClientsList;

namespace Backend.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IMediator _mediator;
        public OrderController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [Route("GetProducts")]
        [HttpGet]
        public async Task<ActionResult<ResponseGetProducsListQueryVm>> GetAllProducts()
        {
            try
            {
                var response = await _mediator.Send(new GetProductsListQuery());
                return Ok(response);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [Route("GetClients")]
        [HttpGet]
        public async Task<ActionResult<ResponseGetClientsListQueryVm>> GetAllClients()
        {
            try
            {
                var response = await _mediator.Send(new GetClientsListQuery());
                return Ok(response);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
