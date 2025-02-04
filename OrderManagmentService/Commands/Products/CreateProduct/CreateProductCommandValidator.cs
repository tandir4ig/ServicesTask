using FluentValidation;
using System.Data;

namespace OrderManagmentService.Commands.Products.CreateProduct
{
    public class CreateProductCommandValidator : AbstractValidator<CreateProductCommand>
    {
        public CreateProductCommandValidator() 
        {
            RuleFor(c => c.Name).NotEmpty();
            RuleFor(c => c.Article).NotEmpty();
            RuleFor(c => c.Price).NotEmpty();
            RuleFor(c => c.Stock).NotEmpty();
            RuleFor(c => c.Description).NotEmpty();
        }
    }
}
