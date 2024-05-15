namespace SharijhaAward.Application.Features.InitialArbitrationFeatures.Queries.GetInitialArbitrationByArbitrationId
{
    public class MainCriterionDto
    {
        public string Title { get; set; } = null!;
        public List<SubCriterionDto> SubCriterionDtos { get; set; } = new List<SubCriterionDto>();
    }
}
