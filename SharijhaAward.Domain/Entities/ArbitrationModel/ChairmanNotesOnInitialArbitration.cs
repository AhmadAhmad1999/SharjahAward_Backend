using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.ArbitratorModel;

namespace SharijhaAward.Domain.Entities.ArbitrationModel
{
    public class ChairmanNotesOnInitialArbitration : AuditableEntity
    {
        public int Id { get; set; }
        public string Note { get; set; } = null!;
        public int ChairmanId { get; set; }
        public Arbitrator? Chairman { get; set; }
        public int InitialArbitrationId { get; set; }
        public InitialArbitration? InitialArbitration { get; set; }
    }
}
