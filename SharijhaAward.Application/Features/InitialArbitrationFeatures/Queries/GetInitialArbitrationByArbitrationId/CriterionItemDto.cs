namespace SharijhaAward.Application.Features.InitialArbitrationFeatures.Queries.GetInitialArbitrationByArbitrationId
{
    public class CriterionItemDto
    {
        public string Name { get; set; } = null!;
        public int CriterionItemScore { get; set; }
        public string? StrengthPoint { get; set; }
        public string? ImprovementAreas { get; set; }
        public int ArbitrationScore { get; set; }
        public List<AttachmanetsDto>? CriterionItemAttachmanetsDto { get; set; }
        public List<ChairmanNotesOnInitialArbitrationDto> ChairmanNotesOnInitialArbitrationDtos { get; set; } = new List<ChairmanNotesOnInitialArbitrationDto>();
    }
}
