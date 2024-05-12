using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.ArbitratorModel;
using SharijhaAward.Domain.Entities.ProvidedFormModel;

namespace SharijhaAward.Domain.Entities.ArbitrationModel
{
    public class Arbitration : AuditableEntity
    {
        public int Id { get; set; }
        public bool isAccepted { get; set; }
        public bool isAcceptedFromChairman { get; set; }
        public int ArbitratorId { get; set; }
        public Arbitrator? Arbitrator { get; set; }
        public int ProvidedFormId { get; set; }
        public ProvidedForm? ProvidedForm { get; set; }
    }
}
