using SharijhaAward.Application.Features.DynamicAttributeFeatures.Queries.GetAllDynamicAttributesBySectionId;

namespace SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Queries.GetAllDynamicAttributeSectionsForView
{
    public class DynamicAttributeSectionListVM
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool TableTypeSection { get; set; }
        public List<DynamicAttributeListVM> DynamicAttributes { get; set; } = new List<DynamicAttributeListVM>();
    }
}
