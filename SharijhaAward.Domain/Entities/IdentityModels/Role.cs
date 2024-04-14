using SharijhaAward.Domain.Common;

namespace SharijhaAward.Domain.Entities.IdentityModels; 

public class Role : AuditableEntity  
{
    public int Id { get; set; }
    public string RoleName { get; set; }=string.Empty;

    public List<UserRole> UserRoles { get; set; } = new();
}