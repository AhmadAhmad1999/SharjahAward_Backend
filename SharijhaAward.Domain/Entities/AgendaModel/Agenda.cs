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
    public Guid Id { get; set; }
    public string ArabicTitle { get; set; } = string.Empty;
    public string EnglishTitle { get; set; } = string.Empty;
    public string Icon { get; set; } = string.Empty;
    public DateTime Date { get; set; }
    public bool IsActive { get; set; }
    [ForeignKey(nameof(Cycle))]
    public Guid CycleId { get; set; }
    public Cycle Cycle { get; set; } = null!;
}