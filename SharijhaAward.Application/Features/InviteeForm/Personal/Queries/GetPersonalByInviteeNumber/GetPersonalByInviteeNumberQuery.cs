using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.InviteeForm.Personal.Queries.GetPersonalByInviteeNumber
{
    public class GetPersonalByInviteeNumberQuery : IRequest<PersonalDto>
    {
        public int InviteeNumber { get; set; }  
    }
}
