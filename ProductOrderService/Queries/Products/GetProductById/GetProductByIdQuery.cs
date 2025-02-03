using MediatR;

namespace ProductOrderService.Queries.Products.GetProductById
{
    public class GetProductByIdQuery : IRequest<GetProductByIdDto>
    {
        public int Id { get; set; }

        public GetProductByIdQuery(int id)
        {
            Id = id;
        }
    }
}
