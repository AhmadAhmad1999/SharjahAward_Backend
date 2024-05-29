using SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Queries.GetAllDynamicAttributeSectionsForAdd;

namespace SharijhaAward.Application.Features.AdvancedFormBuilderSectionsFeatures.Queries.GetAllAdvancedFormBuilderSectionsForAdd
{
    public class GetAllAdvancedFormBuilderSectionsForAddListVM
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool TableTypeSection { get; set; }
        public List<AdvancedFormBuilderListWithListValuesVM> AdvancedFormBuilders { get; set; } = new List<AdvancedFormBuilderListWithListValuesVM>();
    }
}
