using FluentValidation;

namespace explorer_api.ViewModels.Validations {
    public class JournalViewModelValidator: AbstractValidator<JournalFileViewModel> {
        public JournalViewModelValidator() {
            RuleFor(model => model.FileName).NotEmpty().WithMessage("FileName is required");
        }
    }
}