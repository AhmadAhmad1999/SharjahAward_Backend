using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.ArbitratorModel;

namespace SharijhaAward.Domain.Entities.CircularModel
{
    public class CiruclarSubcommitteeOfficer : AuditableEntity
    {
        public int Id { get; set; }
        public int CircularId { get; set; }
        public Circular? Circular { get; set; }
        public int SubcommitteeOfficerId { get; set; }
        public Arbitrator? SubcommitteeOfficer { get; set; }
        public bool IsRead { get; set; } = false;
    }
}
