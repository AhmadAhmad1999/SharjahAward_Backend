using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace SharijhaAward.Application.Features.Event.Commands.UpdateEvent
{
    public class UpdateEventCommandValidator : AbstractValidator<UpdateEventCommand>
    {
        public UpdateEventCommandValidator() {
            RuleFor(e => e.EnglishName)
               .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters.");
            RuleFor(e => e.EnglishDescription)
               .MaximumLength(255).WithMessage("{PropertyName} must not exceed 50 characters.");
   
        }
    }
}
