namespace SharijhaAward.Application.Features.FinalArbitrationFeatures.Queries.GetFinalArbitrationById
{
    public class MainCriterionForFinalArbitrationScoreDto
    {
        public string Title { get; set; } = null!;
        public List<SubCriterionForFinalArbitrationScoreDto> SubCriterionForFinalArbitrationScoreDtos { get; set; } = new List<SubCriterionForFinalArbitrationScoreDto>();
    }
}
