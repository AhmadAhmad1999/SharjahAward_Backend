using SharijhaAward.Application.Features.AdvancedFormBuilderFeatures.Queries.GetAllAdvancedFormBuildersBySectionId;

namespace SharijhaAward.Application.Features.AdvancedFormBuilderSectionsFeatures.Queries.GetAdvancedFormBuilderSectionById
{
    public class GetAdvancedFormBuilderSectionByIdDto
    {
        public int Id { get; set; }
        public string ArabicName { get; set; } = null!;
        public string EnglishName { get; set; } = null!;
        public bool TableTypeSection { get; set; }
        public List<AdvancedFormBuilderListVM> AdvancedFormBuilders { get; set; } = new List<AdvancedFormBuilderListVM>();
    }
}
