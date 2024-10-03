using FluentValidation;

namespace CleanArchitecture.Application.Features.Products.Commands.Create
{
    public class CreateProductCommandValidator : AbstractValidator<CreateProductCommand>
    {
        public CreateProductCommandValidator()
        {
            RuleFor(command => command.PageCount).MaximumLength(20).WithMessage("طول باید کمتر از 5 باشد");
        }
    }
}