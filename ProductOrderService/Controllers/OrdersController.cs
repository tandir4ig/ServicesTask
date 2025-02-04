//using MediatR;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using ProductOrderService.Models;
//using ProductOrderService.Services.Interfaces;

//namespace ProductOrderService.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class OrdersController : Controller
//    {
//        private readonly IMediator _mediator;

//        public OrdersController(IMediator mediator)
//        {
//            _mediator = mediator;
//        }

//        [HttpGet]
//        public async Task<ActionResult<IEnumerable<Order>>> Get()
//        {
//            return await _mediator.Send;
//        }

//        [HttpGet("{id}")]
//        public async Task<ActionResult<Order>> Get(int id)
//        {
//            var order = await _orderRepository.GetByIdAsync(id);
//            if (order == null)
//            {
//                return NotFound();
//            }
//            return Ok(order);
//        }
//    }
//}
