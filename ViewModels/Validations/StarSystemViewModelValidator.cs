using FluentValidation;

namespace explorer_api.ViewModels.Validations
{
    public class StarSystemViewModelValidator: AbstractValidator<StarSystemViewModel>
    {
        public StarSystemViewModelValidator() {
            RuleFor(model => model.Name).NotEmpty().WithMessage("Name is required");
        }
    }
}