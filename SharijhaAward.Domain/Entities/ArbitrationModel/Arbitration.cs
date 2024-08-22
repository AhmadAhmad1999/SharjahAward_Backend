using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.ArbitratorModel;
using SharijhaAward.Domain.Entities.IdentityModels;
using SharijhaAward.Domain.Entities.ProvidedFormModel;

namespace SharijhaAward.Domain.Entities.ArbitrationModel
{
    public class Arbitration : AuditableEntity
    {
        public int Id { get; set; }
        public FormStatus isAccepted { get; set; }
        public string? ReasonForRejecting { get; set; }
        public FormStatus isAcceptedFromChairman { get; set; }
        public int ArbitratorId { get; set; }
        public Arbitrator? Arbitrator { get; set; }
        public int ProvidedFormId { get; set; }
        public ProvidedForm? ProvidedForm { get; set; }
        public ArbitrationType Type { get; set; } = 0;
        public DateTime? DateOfArbitration { get; set; }
        public float FullScore { get; set; }
        public ArbitrationType ArbitrationAuditType { get; set; }
        public DateTime? DateOfArbitrationAuditing { get; set; }
        public string? ReasonForRejectingFromArbitrationAudit { get; set; }
        public FormStatus isAcceptedFromChairmanFromArbitrationAudit { get; set; }
        public int? DoneArbitrationUserId { get; set; }
        public User? DoneArbitrationUser { get; set; }
    }
}
