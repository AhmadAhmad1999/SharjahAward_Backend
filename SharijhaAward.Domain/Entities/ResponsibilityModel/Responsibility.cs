using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.IdentityModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Domain.Entities.ResponsibilityModel
{
    public class Responsibility : AuditableEntity
    {
        public int Id { get; set; }
        public string Description { get; set; } = string.Empty;
        public Role Role { get; set; } = null!;
        [ForeignKey(nameof(Role))]
        public int RoleId { get; set; }
        public List<ResponsibilityUser>? ResponsibilityUsers { get; set; }

    }
}
