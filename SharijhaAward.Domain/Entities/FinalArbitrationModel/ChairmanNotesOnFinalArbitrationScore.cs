using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.IdentityModels;

namespace SharijhaAward.Domain.Entities.FinalArbitrationModel
{
    public class ChairmanNotesOnFinalArbitrationScore : AuditableEntity
    {
        public int Id { get; set; }
        public string Note { get; set; } = null!;
        public int ChairmanId { get; set; }
        public User? Chairman { get; set; }
        public int FinalArbitrationScoreId { get; set; }
        public FinalArbitrationScore? FinalArbitrationScore { get; set; }
    }
}
