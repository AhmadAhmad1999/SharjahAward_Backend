using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.InviteeForm.Personal.Queries.GetPersonalInviteeById
{
    public class GetPersonalInviteeByIdQuery : IRequest<PersonalInviteeVM>
    {
        public int Id { get; set; }
    }
}
