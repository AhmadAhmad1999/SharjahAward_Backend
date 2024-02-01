using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Event.Queries.GetEventWithInvitees
{
    public class GetEventWithInviteesQuery : IRequest<EventInviteesVM>
    {
        public Guid Id { get; set; }
        public string lang { get; set; }=string.Empty;

    }
}
