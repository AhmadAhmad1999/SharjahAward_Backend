namespace SharijhaAward.Application.Features.InitialArbitrationFeatures.Queries.GetInitialArbitrationByArbitrationId
{
    public class CriterionItemDto
    {
        public int InitialArbitrationId { get; set; }
        public int CriterionItemId { get; set; }
        public string Name { get; set; } = null!;
        public int CriterionItemScore { get; set; }
        public string? StrengthPoint { get; set; }
        public string? ImprovementAreas { get; set; }
        public int ArbitrationScore { get; set; }
        public List<AttachmanetsDto> CriterionItemAttachmanetsDto { get; set; } = new List<AttachmanetsDto>();
        public List<ChairmanNotesOnInitialArbitrationDto> ChairmanNotesOnInitialArbitrationDtos { get; set; } = new List<ChairmanNotesOnInitialArbitrationDto>();
    }
}
