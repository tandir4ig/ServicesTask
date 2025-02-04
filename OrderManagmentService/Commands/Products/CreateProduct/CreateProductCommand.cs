using MediatR;

namespace OrderManagmentService.Commands.Products.CreateProduct
{
    public class CreateProductCommand : IRequest<CreateProductDto>
    {
        public string Article { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
    }
}
