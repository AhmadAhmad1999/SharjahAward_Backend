using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Event.Commands.CreateEvent
{
    public class CreateEventDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }=string.Empty;
    }
}
