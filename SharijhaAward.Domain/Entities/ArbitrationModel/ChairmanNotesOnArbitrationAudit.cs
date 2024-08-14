using SharijhaAward.Domain.Common;

namespace SharijhaAward.Domain.Entities.ArbitrationModel
{
    public class ChairmanNotesOnArbitrationAudit : AuditableEntity
    {
        public int Id { get; set; }
        public string Note { get; set; } = null!;
        public int ArbitrationAuditId { get; set; }
        public ArbitrationAudit? ArbitrationAudit { get; set; }
    }
}
