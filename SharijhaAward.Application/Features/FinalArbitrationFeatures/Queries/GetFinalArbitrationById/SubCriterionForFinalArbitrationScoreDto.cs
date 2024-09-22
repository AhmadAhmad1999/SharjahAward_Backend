using SharijhaAward.Application.Features.InitialArbitrationFeatures.Queries.GetInitialArbitrationByArbitrationId;

namespace SharijhaAward.Application.Features.FinalArbitrationFeatures.Queries.GetFinalArbitrationById
{
    public class SubCriterionForFinalArbitrationScoreDto
    {
        public int SubCriterionId { get; set; }
        public int FinalArbitrationScoreId { get; set; }
        public string Title { get; set; } = null!;
        public int SubCriterionScore { get; set; }
        public string? StrengthPoint { get; set; }
        public string? ImprovementAreas { get; set; }
        public int ArbitrationScore { get; set; }
        public bool AttachFilesOnSubCriterion { get; set; }
        public List<AttachmanetsDto> SubCriterionAttachmanetsDto { get; set; } = new List<AttachmanetsDto>();
        public List<ChairmanNotesOnFinalArbitrationScoreDto> ChairmanNotesOnFinalArbitrationScoreDtos { get; set; } = new List<ChairmanNotesOnFinalArbitrationScoreDto>();
        public List<CriterionItemForFinalArbitrationScoreDto> SubCriterionItemForFinalArbitrationScoreDtos { get; set; } = new List<CriterionItemForFinalArbitrationScoreDto>();
    }
}
