using AutoMapper;
using MediatR;
using ProductOrderService.Contexts;
using ProductOrderService.Models;
using ProductOrderService.Services;
using ProductOrderService.Services.Interfaces;

namespace OrderManagmentService.Commands.Products.CreateProduct
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, CreateProductDto>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public CreateProductCommandHandler(
            IProductRepository productRepository,
            IMapper mapper)
        {
            _productRepository = productRepository ?? throw new ArgumentNullException(nameof(productRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<CreateProductDto> Handle(CreateProductCommand command, CancellationToken cancellationToken)
        {
            var product = new Product
            {
                Article = command.Article,
                Description = command.Description,
                Name = command.Name,
                Price = command.Price,
                Stock = command.Stock,
            };

            await _productRepository.AddAsync(product);

            return _mapper.Map<CreateProductDto>(product);
        }
    }
}
