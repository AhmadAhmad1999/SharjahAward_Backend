using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Constants.AgendaConstants;
using SharijhaAward.Domain.Constants.Common;
using SharijhaAward.Domain.Entities.Common;
using SharijhaAward.Domain.Entities.CycleModel;
using SharijhaAward.Domain.Entities.IdentityModels;
using System.ComponentModel.DataAnnotations.Schema;

namespace SharijhaAward.Domain.Entities.AgendaModel; 

public class Agenda : AuditableEntity
{
    public int Id { get; set; }
    public string ArabicTitle { get; set; } = string.Empty;
    public string EnglishTitle { get; set; } = string.Empty;
    public string Icon { get; set; } = string.Empty;
    public bool IsPrivate { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public DateTime CurrentDate { get; set; }
    public AgendaStatus Status { get; set; }
    public AgendaDateType DateType { get; set; }
    public Cycle Cycle { get; set; } = null!;
    [ForeignKey(nameof(Cycle))]
    public int CycleId { get; set; }
   
}