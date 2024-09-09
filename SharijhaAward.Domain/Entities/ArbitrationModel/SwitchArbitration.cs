using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.ArbitratorModel;
using SharijhaAward.Domain.Entities.ProvidedFormModel;

namespace SharijhaAward.Domain.Entities.ArbitrationModel
{
    public class SwitchArbitration : AuditableEntity
    {
        public int Id { get; set; }
        public int OldArbitratorId { get; set; }
        public Arbitrator? OldArbitrator { get; set; }
        public int NewArbitratorId { get; set; }
        public Arbitrator? NewArbitrator { get; set; }
        public int ProvidedFormId { get; set; }
        public ProvidedForm? ProvidedForm { get; set; }
    }
}
