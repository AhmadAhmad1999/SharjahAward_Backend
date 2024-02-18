using Microsoft.AspNetCore.Identity;
using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.IdentityModels;
using System.ComponentModel.DataAnnotations.Schema;

namespace SharijhaAward.Domain.Entities.IdentityModels; 

public class Role : AuditableEntity  {
    public Guid RoleId { get; set; }
    public string RoleName { get; set; }=string.Empty;

    public RolePermission? Permission { get; set; } = null!;
    [ForeignKey(nameof(Permission))]
    public int? RolePermissionId { get; set; }

    public List<User> Users { get; set; } = new();
}