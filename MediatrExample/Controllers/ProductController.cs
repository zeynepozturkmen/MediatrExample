using MediatR;
using MediatrExample.Med.Command;
using MediatrExample.Med.Queries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MediatrExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("id")]
        public async Task<IActionResult> Get(Guid Id) {
            var query = new GetProductByIdQuery() { Id = Id };

            return Ok(await _mediator.Send(query));


        }

        [HttpGet()]
        public async Task<IActionResult> GetAll()
        {
            var query = new GetAllProductQuery(){};

            return Ok(await _mediator.Send(query));


        }

        [HttpPost()]
        public async Task<IActionResult> Post(CreateProductCommand command)
        {

            return Ok(await _mediator.Send(command));


        }

    }
}
