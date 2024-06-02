using SharijhaAward.Domain.Constants.AgendaConstants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Agendas.Queries.ExportToExcel
{
    public class AgendaExportDto
    {
        public int Id { get; set; }
        public string ArabicTitle { get; set; } = string.Empty;
        public string EnglishTitle { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime CurrentDate { get; set; }
        public DateTime EndDate { get; set; }
        public AgendaStatus Status { get; set; }
        public AgendaDateType DateType { get; set; }
    }
}
