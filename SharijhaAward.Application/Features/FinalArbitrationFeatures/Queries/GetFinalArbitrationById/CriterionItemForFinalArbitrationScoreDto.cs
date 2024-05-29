using SharijhaAward.Application.Features.InitialArbitrationFeatures.Queries.GetInitialArbitrationByArbitrationId;

namespace SharijhaAward.Application.Features.FinalArbitrationFeatures.Queries.GetFinalArbitrationById
{
    public class CriterionItemForFinalArbitrationScoreDto
    {
        public int CriterionItemId { get; set; }
        public int FinalArbitrationScoreId { get; set; }
        public string Name { get; set; } = null!;
        public int CriterionItemScore { get; set; }
        public string? StrengthPoint { get; set; }
        public string? ImprovementAreas { get; set; }
        public int ArbitrationScore { get; set; }
        public List<AttachmanetsDto> CriterionItemAttachmanetsDto { get; set; } = new List<AttachmanetsDto>();
        public List<ChairmanNotesOnFinalArbitrationScoreDto> ChairmanNotesOnFinalArbitrationScoreDtos { get; set; } = new List<ChairmanNotesOnFinalArbitrationScoreDto>();
    }
}
