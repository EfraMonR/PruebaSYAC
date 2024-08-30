using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Backend.Application.Exceptions;
using Backend.Application.Features.Products.Queries.GetProductsList;

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
        public async Task<ActionResult<ResponseGetProducsListQueryVm>> GetProducts()
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
    }
}
