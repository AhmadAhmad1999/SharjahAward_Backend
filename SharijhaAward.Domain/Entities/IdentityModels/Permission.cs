
using SharijhaAward.Domain.Entities.IdentityModels;
using System.ComponentModel.DataAnnotations.Schema;

namespace SharijhaAward.Domain.Entities.IdentityModels; 

public class Permission  {
    public Guid Id { get; set; }
    public string Name { get; set; } = null!;

    public RolePermission? Role { get; set; } = null!;
    [ForeignKey(nameof(Role))]
    public int? RolePermissionId { get; set; }
}