using SharijhaAward.Application.Features.DynamicAttributeFeatures.Queries.GetAllDynamicAttributesBySectionId;

namespace SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Queries.GetDynamicAttributeSectionById
{
    public class GetDynamicAttributeSectionByIdDto
    {
        public int Id { get; set; }
        public string ArabicName { get; set; } = null!;
        public string EnglishName { get; set; } = null!;
        public List<DynamicAttributeListVM> DynamicAttributes { get; set; } = new List<DynamicAttributeListVM>();
    }
}
