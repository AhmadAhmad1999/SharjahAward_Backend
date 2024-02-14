﻿using FluentValidation;
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
              .EmailAddress();
            RuleFor(p => p.Name)
                .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters.");
            RuleFor(p => p.PhoneNumber)
                .MaximumLength(15).WithMessage("{PropertyName} must not exceed 15 number.");
        }
    }
}
