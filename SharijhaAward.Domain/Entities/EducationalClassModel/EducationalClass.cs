using SharijhaAward.Domain.Common;

namespace SharijhaAward.Domain.Entities.EducationalClassModel; 

public class EducationalClass : AuditableEntity
{
    public Guid Id { get; set; }
    public string ArabicName { get; set; } = null!;
    public string EnglishName { get; set; } = null!;
}