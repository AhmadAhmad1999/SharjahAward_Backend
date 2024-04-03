namespace SharijhaAward.Application.Features.CriterionFeatures.Queries.GetAllCriterionsForDashBoardByCategoryId
{
    public class GetAllCriterionsForDashBoardCategoryIdDto
    {
        public Guid Id { get; set; }
        public string EnglishTitle { get; set; } = null!;
        public string ArabicTitle { get; set; } = null!;
        public int Score { get; set; }
        public List<GetAllSubCriterion> SubCriterions { get; set; } = new List<GetAllSubCriterion>();
    }
}
