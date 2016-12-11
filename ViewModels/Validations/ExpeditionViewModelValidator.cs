using FluentValidation;

namespace explorer_api.ViewModels.Validations
{
    public class ExpeditionViewModelValidator: AbstractValidator<ExpeditionViewModel>
    {
        public ExpeditionViewModelValidator()
        {
            RuleFor(model => model.Title).NotEmpty().WithMessage("Title is required");
            RuleFor(model => model.StartDate).NotEmpty().WithMessage("StartDate is required");
        }
    }
}