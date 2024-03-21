using SharijhaAward.Domain.Constants.AgendaConstants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Agendas.Queries.GetAllAgenda
{
    public class AgendaListVm
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string ArabicTitle { get; set; } = string.Empty;
        public string EnglishTitle { get; set; } = string.Empty;
        public string Icon { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public AgendaStatus Status { get; set; }
        public AgendaDateType DateType { get; set; }
        public Guid CycleId { get; set; }
    }
}
