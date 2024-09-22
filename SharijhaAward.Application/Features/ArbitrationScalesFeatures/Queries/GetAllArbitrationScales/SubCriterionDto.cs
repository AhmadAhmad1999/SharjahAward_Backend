namespace SharijhaAward.Application.Features.ArbitrationScalesFeatures.Queries.GetAllArbitrationScales
{
    public class SubCriterionDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public int Score { get; set; }
        public string ScoreInPercentageForm { get; set; } = null!;
        public bool AttachFilesOnSubCriterion { get; set; }
        public List<CriterionItemDto> CriterionItemDto { get; set; } = new List<CriterionItemDto>();
        public List<ArbitrationScaleCriterionDto> ArbitrationScaleCriterionDto { get; set; } = new List<ArbitrationScaleCriterionDto>();
    }
}
