using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.IdentityModels;

namespace SharijhaAward.Domain.Entities.ArbitrationModel
{
    public class ChairmanNotesOnInitialArbitration : AuditableEntity
    {
        public int Id { get; set; }
        public string Note { get; set; } = null!;
        public int ChairmanId { get; set; }
        public User? Chairman { get; set; }
        public int InitialArbitrationId { get; set; }
        public InitialArbitration? InitialArbitration { get; set; }
    }
}
