using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.InviteeForm.Personal.Command.UpdatePersonalInvitee
{
    public class UpdatePersonalInviteeCommandValidator : AbstractValidator<UpdatePersonalInviteeCommand>
    {
        public UpdatePersonalInviteeCommandValidator()
        {
            RuleFor(p => p.Email)
              .EmailAddress()
              .NotEmpty();
            RuleFor(p => p.Employer)
                .NotNull()
                .NotEmpty().WithMessage("{PropertyName} is required.");
            RuleFor(p => p.Name)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MinimumLength(10)
                .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters.");
            RuleFor(p => p.JobTitle)
                .NotNull()
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .MinimumLength(10);
            RuleFor(p => p.PhoneNumber)
                .NotNull()
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .MaximumLength(15).WithMessage("{PropertyName} must not exceed 15 number.");
        }
    }
}
