using FluentValidation;

namespace explorer_api.ViewModels.Validations
{
    public class JournalViewModelValidator: AbstractValidator<JournalViewModel>
    {
        public JournalViewModelValidator()
        {
            RuleFor(model => model.JournalFileId).NotEmpty().WithMessage("JournalFileId is required");
            RuleFor(model => model.JsonData).NotEmpty().WithMessage("JsonData is required");
        }
    }
}