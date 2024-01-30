using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Event.Queries.GetEventById
{
    public class EventDtoArabic : EventDto 
    {
        public string ArabicName { get; set; } = string.Empty;
        public string ArabicDescription { get; set; } = string.Empty;
    }
}
