using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.ContactUsModels;
using SharijhaAward.Domain.Entities.IdentityModels;
using System.ComponentModel.DataAnnotations.Schema;

namespace SharijhaAward.Domain.Entities.RoleMessageTypeModel
{
    public class RoleMessageType : AuditableEntity
    {
        public int Id { get; set; }

        public MessageType MessageType { get; set; } = null!;
        [ForeignKey(nameof(Type))]
        public int MessageTypeId { get; set; }

        public Role Role { get; set; } = null!;
        [ForeignKey(nameof(Role))]
        public int RoleId { get; set; }

    }
}
