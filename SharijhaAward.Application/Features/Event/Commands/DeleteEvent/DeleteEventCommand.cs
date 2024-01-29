using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Event.Commands.DeleteEvent
{
    public class DeleteEventCommand : IRequest<Unit>
    {
        public Guid Id { get; set; }
    }
}
