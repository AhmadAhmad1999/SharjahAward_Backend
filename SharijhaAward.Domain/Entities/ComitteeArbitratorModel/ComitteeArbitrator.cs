using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.ArbitratorModel;
using SharijhaAward.Domain.Entities.CommitteeModel;

namespace SharijhaAward.Domain.Entities.ComitteeArbitratorModel
{
    public class ComitteeArbitrator : AuditableEntity
    {
        public int Id { get; set; }
        public int CommitteeId { get; set; }
        public Committee? Committee { get; set; }
        public int ArbitratorId { get; set; }
        public Arbitrator? Arbitrator { get; set; }
    }
}
