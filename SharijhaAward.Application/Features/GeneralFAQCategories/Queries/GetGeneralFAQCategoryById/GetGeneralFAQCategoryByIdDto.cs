
using SharijhaAward.Application.Features.GeneralFAQCategories.Queries.GetAllGeneralFAQCategory;

namespace SharijhaAward.Application.Features.GeneralFAQCategories.Queries.GetGeneralFAQCategoryById
{
    public class GetGeneralFAQCategoryByIdDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public List<GetAllGeneralFAQListVM> GeneralFAQListVM { get; set; } = new List<GetAllGeneralFAQListVM>();
    }
}
