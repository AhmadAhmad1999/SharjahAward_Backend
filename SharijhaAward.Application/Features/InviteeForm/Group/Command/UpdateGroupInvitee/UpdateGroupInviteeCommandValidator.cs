using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.InviteeForm.Group.Command.UpdateGroupInvitee
{
    public class UpdateGroupInviteeCommandValidator : AbstractValidator<UpdateGroupInviteeCommand>
    {
        public UpdateGroupInviteeCommandValidator()
        {
            RuleFor(g => g.Name)
               .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters.");
            RuleFor(g => g.SchoolName)
               .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters.");
            RuleFor(g => g.Email)
                .EmailAddress();
            RuleFor(g => g.PhoneNumber)
                .MaximumLength(15).WithMessage("{PropertyName} must not exceed 50 characters.");
            RuleFor(g => g.JobTitle)
                .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters.");
            RuleFor(g => g.ExpectedNumberOfAttendees)
                .GreaterThan(0)
                .LessThan(int.MaxValue);
        }
    }
}
