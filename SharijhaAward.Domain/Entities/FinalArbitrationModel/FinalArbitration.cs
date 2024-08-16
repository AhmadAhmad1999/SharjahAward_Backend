using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.ArbitrationModel;
using SharijhaAward.Domain.Entities.ArbitratorModel;
using SharijhaAward.Domain.Entities.ProvidedFormModel;

namespace SharijhaAward.Domain.Entities.FinalArbitrationModel
{
    public class FinalArbitration : AuditableEntity
    {
        public int Id { get; set; }
        public string? ReasonForRejecting { get; set; }
        public FormStatus isAcceptedFromChairman { get; set; }
        public int ArbitratorId { get; set; }
        public Arbitrator? Arbitrator { get; set; }
        public int ProvidedFormId { get; set; }
        public ProvidedForm? ProvidedForm { get; set; }
        public ArbitrationType Type { get; set; } = 0;
        public DateTime? DateOfArbitration { get; set; }
        public float FullScore { get; set; }
        public float FinalScore { get; set; }
    }
}
