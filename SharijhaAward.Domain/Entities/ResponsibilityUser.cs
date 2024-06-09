using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.IdentityModels;
using SharijhaAward.Domain.Entities.ResponsibilityModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Domain.Entities
{
    public class ResponsibilityUser : AuditableEntity
    {
        public int Id {  get; set; }
        public User User { get; set; } = null!;
        [ForeignKey(nameof(User))]
        public int UserId { get; set; }

        public Responsibility Responsibility { get; set; } = null!;
        [ForeignKey(nameof(Responsibility))]
        public int ResponsibilityId {  get; set; }

        public bool IsAccept {  get; set; }

    }
}
