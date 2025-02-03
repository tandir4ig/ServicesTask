using AutoMapper;
using ProductOrderService.Models;

namespace ProductOrderService.Queries.Products.GetProductById
{
    public class GetProductByIdMapping : Profile
    {
        public GetProductByIdMapping()
        {
            CreateMap<Product, GetProductByIdDto>();
        }
    }
}
