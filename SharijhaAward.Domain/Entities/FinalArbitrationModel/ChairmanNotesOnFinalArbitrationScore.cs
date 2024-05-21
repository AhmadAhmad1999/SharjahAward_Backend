using SharijhaAward.Domain.Common;

namespace SharijhaAward.Domain.Entities.FinalArbitrationModel
{
    public class ChairmanNotesOnFinalArbitrationScore : AuditableEntity
    {
        public int Id { get; set; }
        public string Note { get; set; } = null!;
        public int FinalArbitrationScoreId { get; set; }
        public FinalArbitrationScore? FinalArbitrationScore { get; set; }
    }
}
