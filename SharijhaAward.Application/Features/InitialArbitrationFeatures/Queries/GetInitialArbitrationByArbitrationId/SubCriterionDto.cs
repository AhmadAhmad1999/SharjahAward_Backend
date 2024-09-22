namespace SharijhaAward.Application.Features.InitialArbitrationFeatures.Queries.GetInitialArbitrationByArbitrationId
{
    public class SubCriterionDto
    {
        public int InitialArbitrationId { get; set; }
        public int SubCriterionId { get; set; }
        public string Title { get; set; } = null!; 
        public int SubCriterionScore { get; set; } 
        public string? StrengthPoint { get; set; } 
        public string? ImprovementAreas { get; set; }
        public int ArbitrationScore { get; set; }
        public bool AttachFilesOnSubCriterion { get; set; }
        public List<AttachmanetsDto> SubCriterionAttachmanetsDto { get; set; } = new List<AttachmanetsDto>();
        public List<ChairmanNotesOnInitialArbitrationDto> ChairmanNotesOnInitialArbitrationDtos { get; set; } = new List<ChairmanNotesOnInitialArbitrationDto>();
        public List<CriterionItemDto> SubCriterionItemDtos { get; set; } = new List<CriterionItemDto>();
    }
}
