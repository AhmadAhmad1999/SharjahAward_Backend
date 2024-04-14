using MediatR;
using SharijhaAward.Application.Features.InviteeForm.Personal.Queries.GetPersonalInviteeById;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.InviteeForm.ResendEmail
{
    public class ResendEmailQuery : IRequest<Unit>
    {
        public int InviteeId { get; set; }
        public string Type { get; set; }=string.Empty;
        public string? lang { get; set; }
        public string? ImagePath { get; set; }
    }
}
