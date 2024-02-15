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
            RuleFor(g => g.Name);

            RuleFor(g => g.SchoolName);
              
            RuleFor(g => g.Email)
                .EmailAddress();
            RuleFor(g => g.PhoneNumber);

            RuleFor(g => g.JobTitle);

            RuleFor(g => g.ExpectedNumberOfAttendees)
                .GreaterThan(0)
                .LessThan(int.MaxValue);
        }
    }
}
