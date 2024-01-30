using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Event.Queries.GetEventById
{
    public class GetEventByIdQuery : IRequest<EventDto>
    {
        public Guid Id { get; set; }
      
    }
}
