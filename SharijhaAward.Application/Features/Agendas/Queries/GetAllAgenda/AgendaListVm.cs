using SharijhaAward.Domain.Constants.AgendaConstants;

namespace SharijhaAward.Application.Features.Agendas.Queries.GetAllAgenda
{
    public class AgendaListVm
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string ArabicTitle { get; set; } = string.Empty;
        public string EnglishTitle { get; set; } = string.Empty;
        public string Icon { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime CurrentDate { get; set; }
        public AgendaStatus Status { get; set; }
        public AgendaDateType DateType { get; set; }
        public bool IsPrivate { get; set; }
        public int CycleId { get; set; }
    }
}
