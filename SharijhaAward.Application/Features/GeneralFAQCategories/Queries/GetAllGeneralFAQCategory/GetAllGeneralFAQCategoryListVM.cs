
namespace SharijhaAward.Application.Features.GeneralFAQCategories.Queries.GetAllGeneralFAQCategory
{
    public class GetAllGeneralFAQCategoryListVM
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public List<GetAllGeneralFAQListVM> GeneralFAQListVM { get; set; } = new List<GetAllGeneralFAQListVM>();
    }
}
