using FluentValidation;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.InviteeForm.Personal.Command.CreatePersonalInvitee
{
    public class CreatePersonalInviteeCommandValidator : AbstractValidator<CreatePersonalInviteeCommand>
    {
        public CreatePersonalInviteeCommandValidator()
        {
            RuleFor(p => p.Email)
                .EmailAddress()
                .NotEmpty();
            RuleFor(p => p.Employer)
                .NotNull()
                .NotEmpty().WithMessage("{PropertyName} is required.");
            RuleFor(p => p.Name)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull();
               
            RuleFor(p => p.JobTitle)
                .NotNull()
                .NotEmpty().WithMessage("{PropertyName} is required.");
            RuleFor(p => p.PhoneNumber)
                .NotNull()
                .NotEmpty().WithMessage("{PropertyName} is required.");
               
        }
    }
}
