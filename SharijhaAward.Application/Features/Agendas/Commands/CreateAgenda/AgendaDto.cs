using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Agendas.Commands.CreateAgenda
{
    public class AgendaDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string ArabicTitle { get; set; } = string.Empty;
        public string EnglishTitle { get; set; } = string.Empty;
        public string Icon { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public bool IsActive { get; set; }
        public Guid CycleId { get; set; }
    }
}
