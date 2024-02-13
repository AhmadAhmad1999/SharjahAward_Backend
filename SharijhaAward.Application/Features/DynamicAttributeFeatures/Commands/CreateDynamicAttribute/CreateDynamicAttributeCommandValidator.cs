using FluentValidation;
using SharijhaAward.Application.Features.Event.Commands.CreateEvent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.DynamicAttributeFeatures.Commands.CreateDynamicAttribute
{
    public class CreateDynamicAttributeCommandValidator : AbstractValidator<CreateDynamicAttributeCommand>
    {
        public CreateDynamicAttributeCommandValidator()
        {
            RuleFor(e => e.Key)
               .NotEmpty().WithMessage("{PropertyName} is required.")
               .NotNull()
               .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters.");

            RuleFor(e => e.ArabicLabel)
               .NotEmpty().WithMessage("{PropertyName} is required.")
               .NotNull()
               .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters.");

            RuleFor(e => e.EnglishLabel)
               .NotEmpty().WithMessage("{PropertyName} is required.")
               .NotNull()
               .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters.");
            
            RuleFor(e => e.ArabicPlaceHolder)
               .NotEmpty().WithMessage("{PropertyName} is required.")
               .NotNull()
               .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters.");
            
            RuleFor(e => e.EnglishPlaceHolder)
               .NotEmpty().WithMessage("{PropertyName} is required.")
               .NotNull()
               .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters.");
        }
    }
}
