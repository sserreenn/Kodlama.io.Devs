using FluentValidation;

namespace Application.Features.Languages.Commands.Validator
{
    public class CreateLanguageCommandValidator : AbstractValidator<CreateLanguageCommand>
    {
        public CreateLanguageCommandValidator()
        {
            RuleFor(c => c.Name).NotEmpty();
        }
    }
}