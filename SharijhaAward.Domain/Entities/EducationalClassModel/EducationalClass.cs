using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.CycleModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace SharijhaAward.Domain.Entities.EducationalClassModel; 

public class EducationalClass : AuditableEntity
{
    public int Id { get; set; }
    public string ArabicName { get; set; } = null!;
    public string EnglishName { get; set; } = null!;
}