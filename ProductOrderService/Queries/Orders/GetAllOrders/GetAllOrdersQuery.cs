using MediatR;

namespace ProductOrderService.Queries.Orders.GetAllOrders
{
    public class GetAllOrdersQuery : IRequest<IEnumerable<GetAllOrdersDto>>
    {
    }
}
