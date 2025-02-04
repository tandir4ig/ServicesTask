using AutoMapper;
using MediatR;
using ProductOrderService.Services.Interfaces;

namespace ProductOrderService.Queries.Orders.GetAllOrders
{
    public class GetAllOrdersQueryHandler : IRequestHandler<GetAllOrdersQuery, IEnumerable<GetAllOrdersDto>>
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IMapper _mapper;

        public GetAllOrdersQueryHandler(
            IOrderRepository orderRepository,
            IMapper mapper)
        {
            _orderRepository = orderRepository ?? throw new ArgumentNullException(nameof(orderRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<IEnumerable<GetAllOrdersDto>> Handle(GetAllOrdersQuery query, CancellationToken cancellationToken)
        {
            var orders = await _orderRepository.GetAllAsync();

            return _mapper.Map<IEnumerable<GetAllOrdersDto>>(orders); 
        }
    }
}
