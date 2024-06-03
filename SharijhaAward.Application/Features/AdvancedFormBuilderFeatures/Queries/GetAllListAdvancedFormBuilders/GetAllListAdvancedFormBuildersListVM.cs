using SharijhaAward.Application.Features.DynamicAttributeFeatures.Queries.GetAllListDynamicAttributes;

namespace SharijhaAward.Application.Features.AdvancedFormBuilderFeatures.Queries.GetAllListAdvancedFormBuilders
{
    public class GetAllListAdvancedFormBuildersListVM
    {
        public int Id { get; set; }
        public string Label { get; set; } = null!;
        public List<AdvancedFormBuilderListValueDto> Values { get; set; } = new List<AdvancedFormBuilderListValueDto>();
    }
}
