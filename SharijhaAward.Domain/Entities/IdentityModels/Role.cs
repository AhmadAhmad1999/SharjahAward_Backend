using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.CircularModel;
using SharijhaAward.Domain.Entities.ResponsibilityModel;

namespace SharijhaAward.Domain.Entities.IdentityModels; 

public class Role : AuditableEntity  
{
    public int Id { get; set; }
    public string EnglishName { get; set; } = null!;
    public string ArabicName { get; set; } = null!;
    public bool HaveFullAccess { get; set; }
    public List<UserRole> UserRoles { get; set; } = new();
    public List<Responsibility>? Responsibility { get; set; }
}