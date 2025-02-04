using AutoMapper;
using ProductOrderService.Models;
using ProductOrderService.Services.Interfaces;

namespace ProductOrderService.Queries.Orders.GetOrderById
{
    public class GetOrderByIdQueryHandler
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IMapper _mapper;

        public GetOrderByIdQueryHandler(
            IOrderRepository orderRepository, 
            IMapper mapper)
        {
            _orderRepository = orderRepository ?? throw new ArgumentNullException(nameof(orderRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<GetOrderByIdDto> Handle(GetOrderByIdQuery query, CancellationToken cancellationToken)
        {
            var orderDto = await _orderRepository.GetByIdAsync(query.Id);

            return _mapper.Map<GetOrderByIdDto>(orderDto);
        }
    }
}
