namespace SharijhaAward.Application.Features.ArbitrationScalesFeatures.Queries.GetAllArbitrationScales
{
    public class SubCriterionDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public List<CriterionItemDto> CriterionItemDto { get; set; } = new List<CriterionItemDto>();
        public List<ArbitrationScaleCriterionDto> ArbitrationScaleCriterionDto { get; set; } = new List<ArbitrationScaleCriterionDto>();
    }
}
