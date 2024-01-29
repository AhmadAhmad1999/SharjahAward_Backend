using Microsoft.AspNetCore.Identity;

namespace SharijhaAward.Domain.Model.IdentityModels; 

public class Role : IdentityRole<Guid> {
    public List<Permission> Permissions { get; set; } = new();
}