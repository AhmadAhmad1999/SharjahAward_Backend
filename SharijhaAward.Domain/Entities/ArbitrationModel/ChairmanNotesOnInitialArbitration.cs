using SharijhaAward.Domain.Common;

namespace SharijhaAward.Domain.Entities.ArbitrationModel
{
    public class ChairmanNotesOnInitialArbitration : AuditableEntity
    {
        public int Id { get; set; }
        public string Note { get; set; } = null!;
        public int InitialArbitrationId { get; set; }
        public InitialArbitration? InitialArbitration { get; set; }
    }
}
