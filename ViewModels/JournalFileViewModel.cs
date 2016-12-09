using System;
using System.Linq;
using System.Collections.Generic;
using explorer_api.Models;
using explorer_api.ViewModels.Validations;
using FluentValidation;
using FluentValidation.Results;

namespace explorer_api.ViewModels
{
    public class JournalFileViewModel
    {
        public int Id { get; set; }

        public string FileName { get; set; }

        public DateTime Updated { get; set; }

        public DateTime Created { get; set; }

        public string UserId { get; set; }

        public ApplicationUser User { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext) {
            var validator = new JournalViewModelValidator();
            var result = validator.Validate(this);
            return new [] {result};
        }
    }
}