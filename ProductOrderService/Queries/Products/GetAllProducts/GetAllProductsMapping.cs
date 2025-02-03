using AutoMapper;
using ProductOrderService.Models;

namespace ProductOrderService.Queries.Products.GetAllProducts
{
    public class GetAllProductsMapping : Profile
    {
        public GetAllProductsMapping()
        {
            CreateMap<Product, GetAllProductsDto>();
        }
    }
}
