using System.ComponentModel.DataAnnotations.Schema;
using SharijhaAward.Domain.Entities.Common;
using SharijhaAward.Domain.Entities.CycleModel;
using SharijhaAward.Domain.Entities.IdentityModels;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Domain.Common;

namespace SharijhaAward.Domain.Entities.CycleConditionModel; 

public class CycleCondition : AuditableEntity
{
    public Guid Id { get; set; }
    public string ArabicTitle { get; set; } = string.Empty;
    public string EnglishTitle { get; set; } = string.Empty;
    public Cycle Cycle { get; set; } = null!;
    [ForeignKey(nameof(Cycle))]
    public Guid CycleId { get; set; }
}