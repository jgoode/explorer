using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using explorer_api.Models;
using explorer_api.ViewModels.Validations;

namespace explorer_api.ViewModels
{
    public class JournalViewModel: IValidatableObject
    {
        public int Id { get; set; }

        public string JsonData { get; set; }

        public int JournalFileId { get; set; }

        public JournalFile JournalFile { get; set; }

        public DateTime Updated { get; set; }

        public DateTime Created { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var validator = new JournalViewModelValidator();
            var result = validator.Validate(this);
            return result.Errors.Select(item => new ValidationResult(item.ErrorMessage, new[] { item.PropertyName }));
        }
    }
}