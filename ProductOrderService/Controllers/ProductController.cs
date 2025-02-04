using MediatR;
using Microsoft.AspNetCore.Mvc;
using ProductOrderService.Queries.Products.GetAllProducts;
using ProductOrderService.Queries.Products.GetProductById;

namespace ProductOrderService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : Controller
    {
        private readonly IMediator _mediator;

        public ProductsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IEnumerable<GetAllProductsDto>> GetProducts()
        {
            return await _mediator.Send(new GetAllProductsQuery());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<GetProductByIdDto>> GetProduct(int id)
        {
            var productDto = await _mediator.Send(new GetProductByIdQuery(id));
            
            if (productDto is null)
            {
                return NotFound();
            }

            return Ok(productDto);
        }
    }
}
