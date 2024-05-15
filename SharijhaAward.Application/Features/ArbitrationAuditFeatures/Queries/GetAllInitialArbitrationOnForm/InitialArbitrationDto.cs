namespace SharijhaAward.Application.Features.ArbitrationAuditFeatures.Queries.GetAllInitialArbitrationOnForm
{
    public class InitialArbitrationDto
    {
        public int Id { get; set; }
        public int? CriterionId { get; set; }
        public string? Criterion_Name { get; set; }
        public int? CriterionItemId { get; set; }
        public string? CriterionItemName { get; set; }
        public string? StrengthPoint { get; set; }
        public string? ImprovementAreas { get; set; }
        public int ArbitrationScore { get; set; }
        public List<ChairmanNotesOnInitialArbitrationDto> ChairmanNotesOnInitialArbitrationDtos { get; set; } = new List<ChairmanNotesOnInitialArbitrationDto>();
    }
}
