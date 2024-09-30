using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.IdentityModels;

namespace SharijhaAward.Domain.Entities.ArbitrationModel
{
    public class ChairmanNotesOnArbitrationAudit : AuditableEntity
    {
        public int Id { get; set; }
        public string Note { get; set; } = null!;
        public int ChairmanId { get; set; }
        public User? Chairman { get; set; }
        public int ArbitrationAuditId { get; set; }
        public ArbitrationAudit? ArbitrationAudit { get; set; }
    }
}
