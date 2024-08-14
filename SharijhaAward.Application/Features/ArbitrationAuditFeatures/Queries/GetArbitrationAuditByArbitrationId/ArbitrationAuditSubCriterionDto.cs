using SharijhaAward.Application.Features.InitialArbitrationFeatures.Queries.GetInitialArbitrationByArbitrationId;

namespace SharijhaAward.Application.Features.ArbitrationAuditFeatures.Queries.GetArbitrationAuditByArbitrationId
{
    public class ArbitrationAuditSubCriterionDto
    {
        public int ArbitrationAuditId { get; set; }
        public int SubCriterionId { get; set; }
        public string Title { get; set; } = null!;
        public int SubCriterionScore { get; set; }
        public string? StrengthPoint { get; set; }
        public string? ImprovementAreas { get; set; }
        public int ArbitrationScore { get; set; }
        public List<AttachmanetsDto> SubCriterionAttachmanetsDto { get; set; } = new List<AttachmanetsDto>();
        public List<ChairmanNotesOnInitialArbitrationDto> ChairmanNotesOnArbitrationAuditDtos { get; set; } = new List<ChairmanNotesOnInitialArbitrationDto>();
        public List<ArbitrationAuditCriterionItemDto> SubCriterionItemDtos { get; set; } = new List<ArbitrationAuditCriterionItemDto>();
    }
}
