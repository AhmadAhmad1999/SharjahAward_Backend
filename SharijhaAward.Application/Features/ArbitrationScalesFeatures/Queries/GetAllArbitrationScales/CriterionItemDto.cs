namespace SharijhaAward.Application.Features.ArbitrationScalesFeatures.Queries.GetAllArbitrationScales
{
    public class CriterionItemDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public List<ArbitrationScaleCriterionDto> ArbitrationScaleCriterionDto { get; set; } = new List<ArbitrationScaleCriterionDto>();
    }
}
