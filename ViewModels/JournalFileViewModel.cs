using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using explorer_api.Models;
using explorer_api.ViewModels.Validations;
using FluentValidation;
using ValidationContext = System.ComponentModel.DataAnnotations.ValidationContext;

namespace explorer_api.ViewModels
{
    public class JournalFileViewModel: IValidatableObject
    {
        public int Id { get; set; }

        public string FileName { get; set; }

        public DateTime Updated { get; set; }

        public DateTime Created { get; set; }

        public string UserId { get; set; }

        public ApplicationUser User { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext) {
            var validator = new JournalFileViewModelValidator();
            var result = validator.Validate(this);
            return result.Errors.Select(item => new ValidationResult(item.ErrorMessage, new[] { item.PropertyName }));
        }
    }
}