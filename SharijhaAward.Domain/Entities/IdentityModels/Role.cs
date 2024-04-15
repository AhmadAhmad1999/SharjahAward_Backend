using SharijhaAward.Domain.Common;

namespace SharijhaAward.Domain.Entities.IdentityModels; 

public class Role : AuditableEntity  
{
    public int Id { get; set; }
    public string EnglishName { get; set; } = null!;
    public string ArabicName { get; set; } = null!;

    public List<UserRole> UserRoles { get; set; } = new();
}