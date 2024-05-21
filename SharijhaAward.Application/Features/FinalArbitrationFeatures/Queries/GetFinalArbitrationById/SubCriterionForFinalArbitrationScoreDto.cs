using SharijhaAward.Application.Features.InitialArbitrationFeatures.Queries.GetInitialArbitrationByArbitrationId;

namespace SharijhaAward.Application.Features.FinalArbitrationFeatures.Queries.GetFinalArbitrationById
{
    public class SubCriterionForFinalArbitrationScoreDto
    {
        public string Title { get; set; } = null!;
        public int SubCriterionScore { get; set; }
        public string? StrengthPoint { get; set; }
        public string? ImprovementAreas { get; set; }
        public int ArbitrationScore { get; set; }
        public List<AttachmanetsDto>? SubCriterionAttachmanetsDto { get; set; }
        public List<ChairmanNotesOnFinalArbitrationScoreDto>? ChairmanNotesOnFinalArbitrationScoreDto { get; set; }
        public List<CriterionItemForFinalArbitrationScoreDto>? SubCriterionItemForFinalArbitrationScoreDtos { get; set; }
    }
}
