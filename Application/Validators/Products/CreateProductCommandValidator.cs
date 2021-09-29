using Application.Commands.Products;
using FluentValidation;

namespace Application.Validators.Products
{
    public class CreateProductCommandValidator : AbstractValidator<CreateProductCommand>
    {
        public CreateProductCommandValidator()
        {
            RuleFor(x => x.Product.ProductName).NotEmpty().WithMessage("El producto debe tener Nombre");
            RuleFor(x => x.Product.UnitPrice).GreaterThan(0).WithMessage("{PropertyName} debe tener un valor válido");
        }
    }
}
