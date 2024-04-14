﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.InviteeForm.Personal.Command.CreatePersonalInvitee
{
    public class CreatePersonalInviteeCommand : IRequest<CreateInviteeResponse>
    {
        public string Name { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Employer { get; set; } = string.Empty;
        public string JobTitle { get; set; } = string.Empty;
        public string TypeOfInvitee { get; set; } = string.Empty;
        public int EventId { get; set; }
        public string? lang { get; set; }
        public string? ImagePath { get; set; }
    }
}
