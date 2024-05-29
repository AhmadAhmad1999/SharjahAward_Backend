using SharijhaAward.Application.Features.AdvancedFormBuilderFeatures.Queries.GetAllAdvancedFormBuildersBySectionId;

namespace SharijhaAward.Application.Features.AdvancedFormBuilderSectionsFeatures.Queries.GetAllAdvancedFormBuilderSectionsForView
{
    public class AdvancedFormBuilderSectionListVM
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool TableTypeSection { get; set; }
        public List<AdvancedFormBuilderListVM> AdvancedFormBuilders { get; set; } = new List<AdvancedFormBuilderListVM>();
    }
}
