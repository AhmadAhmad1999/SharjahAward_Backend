namespace SharijhaAward.Application.Features.CriterionFeatures.Queries.GetAllCriterionByCategoryId
{
    public class MainCriterionListVM
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public List<SubCriterionListVM> SubCriterionListVM { get; set; } = new List<SubCriterionListVM>();
    }
}
