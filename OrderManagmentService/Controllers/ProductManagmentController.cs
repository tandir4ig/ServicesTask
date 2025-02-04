using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderManagmentService.Commands.Products.CreateProduct;

namespace OrderManagmentService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductManagmentController : Controller
    {
        private readonly IMediator _mediator;

        public ProductManagmentController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<CreateProductDto> Post([FromBody] CreateProductCommand command)
        {
            var productDto = await _mediator.Send(command);

            return productDto;
        }
    }
}
