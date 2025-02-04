using MediatR;

namespace ProductOrderService.Queries.Orders.GetOrderById
{
    public class GetOrderByIdQuery : IRequest<GetOrderByIdDto>
    {
        public int Id { get; set; }

        public GetOrderByIdQuery(int id)
        {
            Id = id;
        }
    }
}
