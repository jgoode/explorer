using FluentValidation;

namespace explorer_api.ViewModels.Validations {
    public class JournalFileViewModelValidator: AbstractValidator<JournalFileViewModel> {
        public JournalFileViewModelValidator() {
            RuleFor(model => model.FileName).NotEmpty().WithMessage("FileName is required");
        }
    }
}