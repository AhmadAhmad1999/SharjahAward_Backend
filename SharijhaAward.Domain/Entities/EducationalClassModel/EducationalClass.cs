using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.CycleModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace SharijhaAward.Domain.Entities.EducationalClassModel; 

public class EducationalClass : AuditableEntity
{
    public Guid Id { get; set; }
    public string ArabicName { get; set; } = null!;
    public string EnglishName { get; set; } = null!;
    [ForeignKey(nameof(Cycle))]
    public Guid CycleId { get; set; }
    public Cycle? Cycle { get; set; }
}