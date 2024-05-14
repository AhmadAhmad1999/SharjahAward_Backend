namespace SharijhaAward.Application.Features.InitialArbitrationFeatures.Queries.GetInitialArbitrationByArbitrationId
{
    public class SubCriterionDto
    {
        public string Title { get; set; } = null!; 
        public int SubCriterionScore { get; set; } 
        public string? StrengthPoint { get; set; } 
        public string? ImprovementAreas { get; set; }
        public int ArbitrationScore { get; set; }
        public List<AttachmanetsDto>? SubCriterionAttachmanetsDto { get; set; }
        public List<ChairmanNotesOnInitialArbitrationDto>? ChairmanNotesOnInitialArbitrationDtos { get; set; }
        public List<CriterionItemDto>? SubCriterionItemDtos { get; set; }
    }
}
