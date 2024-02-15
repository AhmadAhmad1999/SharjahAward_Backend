using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Event.Queries.GetAllEvents
{
    public class GetAllEventsQuery : IRequest<List<EventListVM>>
    {
        public string lang { get; set; }=string.Empty;
        public int page {  get; set; }
        public int pageSize { get; set; }
    }
}
