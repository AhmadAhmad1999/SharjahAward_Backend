namespace SharijhaAward.Application.Features.FinalArbitrationFeatures.Queries.GetFinalArbitrationById
{
    public class GetFinalArbitrationByIdMainDto
    {
        public int FinalArbitrationId { get; set; }
        public bool isChairman { get; set; }
        public List<MainCriterionForFinalArbitrationScoreDto> MainCriterions { get; set; } = new List<MainCriterionForFinalArbitrationScoreDto>();
    }
}
