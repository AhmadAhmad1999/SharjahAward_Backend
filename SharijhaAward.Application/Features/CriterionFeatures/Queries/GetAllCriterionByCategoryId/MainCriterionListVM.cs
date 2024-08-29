namespace SharijhaAward.Application.Features.CriterionFeatures.Queries.GetAllCriterionByCategoryId
{
    public class MainCriterionListVM
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public bool? rejected { get; set; }
        public List<SubCriterionListVM> SubCriterionListVM { get; set; } = new List<SubCriterionListVM>();
    }
}
