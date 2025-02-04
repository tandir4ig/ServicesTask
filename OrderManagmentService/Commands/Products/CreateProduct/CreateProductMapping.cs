using AutoMapper;
using ProductOrderService.Models;

namespace OrderManagmentService.Commands.Products.CreateProduct
{
    public class CreateProductMapping : Profile
    {
        public CreateProductMapping() 
        {
            CreateMap<Product, CreateProductDto>();
            
        }
    }
}
