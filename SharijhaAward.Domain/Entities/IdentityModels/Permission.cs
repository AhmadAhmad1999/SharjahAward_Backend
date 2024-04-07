using SharijhaAward.Domain.Common;

namespace SharijhaAward.Domain.Entities.IdentityModels; 
public class Permission : AuditableEntity
{
    public Guid Id { get; set; }
    public string Name { get; set; } = null!;
}