using FluentValidation;

namespace explorer_api.ViewModels.Validations
{
    public class SystemObjectViewModelValidator: AbstractValidator<SystemObjectViewModel>
    {
        public SystemObjectViewModelValidator()
        {
            RuleFor(model => model.Name).NotEmpty().WithMessage("Name is required");
        }
    }
}