using SharijhaAward.Domain.Common;

namespace SharijhaAward.Domain.Entities.EducationalClassModel; 

public class EducationalClass : AuditableEntity
{
    public Guid Id { get; set; }
    public string Name { get; set; } = null!;
}