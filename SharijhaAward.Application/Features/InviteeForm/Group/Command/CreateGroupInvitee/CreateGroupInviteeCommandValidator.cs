using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.InviteeForm.Group.Command.CreateGroupInvitee
{
    public class CreateGroupInviteeCommandValidator : AbstractValidator<CreateGroupInviteeCommand>
    {
        public CreateGroupInviteeCommandValidator()
        {
            RuleFor(g=>g.Name)
               .NotEmpty().WithMessage("{PropertyName} is required.")
               .NotNull()
               .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters.");
            RuleFor(g=>g.SchoolName)
               .NotEmpty().WithMessage("{PropertyName} is required.")
               .NotNull()
               .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters.");
            RuleFor(g => g.Email)
                .EmailAddress()
                .NotNull()
                .NotEmpty().WithMessage("{PropertyName} is required.");
            RuleFor(g => g.PhoneNumber)
                .NotNull()
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .MaximumLength(15).WithMessage("{PropertyName} must not exceed 50 characters.");
            RuleFor(g => g.JobTitle)
                .NotNull()
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters.");
            RuleFor(g => g.ExpectedNumberOfAttendees)
                .NotNull()
                .GreaterThan(0)
                .LessThan(int.MaxValue);


        }
    }
}
