using FluentValidation;

namespace CleanArchitecture.Application.Features.Products.Commands.Create
{
    public class UpdateProductCommandValidator : AbstractValidator<UpdateProductCommand>
    {
        public UpdateProductCommandValidator()
        {
            RuleFor(command => command.PageCount).MaximumLength(20).WithMessage("طول باید کمتر از 5 باشد");
        }
    }
}