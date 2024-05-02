namespace SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Commands.ReorderDynamicAttributesInsideTheSections
{
    public class DynamicAttributeSectionsDto
    {
        public int SectionId { get; set; }
        public int OrderId { get; set; }
        public List<DynamicAttributesDto> DynamicAttributesDtos { get; set; } = new List<DynamicAttributesDto>();
    }
}
