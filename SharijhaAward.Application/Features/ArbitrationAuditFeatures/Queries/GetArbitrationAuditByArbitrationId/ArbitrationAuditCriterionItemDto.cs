using SharijhaAward.Application.Features.InitialArbitrationFeatures.Queries.GetInitialArbitrationByArbitrationId;

namespace SharijhaAward.Application.Features.ArbitrationAuditFeatures.Queries.GetArbitrationAuditByArbitrationId
{
    public class ArbitrationAuditCriterionItemDto
    {
        public int ArbitrationAuditId { get; set; }
        public int CriterionItemId { get; set; }
        public string Name { get; set; } = null!;
        public int CriterionItemScore { get; set; }
        public string? StrengthPoint { get; set; }
        public string? ImprovementAreas { get; set; }
        public int ArbitrationScore { get; set; }
        public List<AttachmanetsDto> CriterionItemAttachmanetsDto { get; set; } = new List<AttachmanetsDto>();
        public List<ChairmanNotesOnInitialArbitrationDto> ChairmanNotesOnArbitrationAuditDtos { get; set; } = new List<ChairmanNotesOnInitialArbitrationDto>();
    }
}
