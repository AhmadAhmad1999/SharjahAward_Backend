using SharijhaAward.Domain.Common;

namespace SharijhaAward.Domain.Entities.IdentityModels; 

public class Role : AuditableEntity  
{
    public Guid RoleId { get; set; }
    public string RoleName { get; set; }=string.Empty;

    public List<User> Users { get; set; } = new();
}