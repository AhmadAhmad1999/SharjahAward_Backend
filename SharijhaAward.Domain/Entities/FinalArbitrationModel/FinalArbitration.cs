using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.ArbitrationModel;
using SharijhaAward.Domain.Entities.ArbitratorModel;

namespace SharijhaAward.Domain.Entities.FinalArbitrationModel
{
    public class FinalArbitration : AuditableEntity
    {
        public int Id { get; set; }
        public int FinalScore { get; set; }
        public int ArbitrationId { get; set; }
        public Arbitration? Arbitration { get; set; }
        public int ArbitratorId { get; set; }
        public Arbitrator? Arbitrator { get; set; }
        public bool isAcceptedFromChairman { get; set; }
        public string? ReasonForRejecting { get; set; }
    }
}
