namespace SharijhaAward.Application.Features.ArbitrationScalesFeatures.Queries.GetAllArbitrationScales
{
    public class MainCriterionDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public List<SubCriterionDto> SubCriterionDto { get; set; } = new List<SubCriterionDto>();
    }
}
