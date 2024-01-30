using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Event.Queries.GetEventById
{
    public class EventDtoEnglish : EventDto
    {
        public string EnglishName { get; set; } = string.Empty;
        public string EnglishDescription { get; set; } = string.Empty;
    }
}
