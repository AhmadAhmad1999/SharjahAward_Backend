using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace SharijhaAward.Application.Features.Event.Commands.CreateEvent
{
    public class CreateEventCommandValidator : AbstractValidator<CreateEventCommand>
    {
        public CreateEventCommandValidator() {
            RuleFor(e => e.EnglishName)
               .NotEmpty().WithMessage("{PropertyName} is required.")
               .NotNull()
               .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters.");
            RuleFor(e => e.EnglishDescription)
               .NotEmpty().WithMessage("{PropertyName} is required.")
               .NotNull()
               .MaximumLength(255).WithMessage("{PropertyName} must not exceed 50 characters.");
            RuleFor(e => e.StartDate)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull();
            RuleFor(e => e.EndDate)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull();
                
                
        }
    }
}
