using MediatR;

namespace ProductOrderService.Queries.Products.GetAllProducts
{
    public class GetAllProductsQuery : IRequest<IEnumerable<GetAllProductsDto>>
    {

    }
}
