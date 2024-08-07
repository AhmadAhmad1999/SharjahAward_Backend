namespace SharijhaAward.Application.Features.HomePageFeatures.Queries.GetAllHomePageData
{
    public class FormsInCategories
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = null!;
        public int FormsNumberInCategory { get; set; }
        public float FormsNumberInCategoryAsPercentage { get; set; }
    }
}
