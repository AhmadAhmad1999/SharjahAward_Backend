namespace SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Commands.ReorderDynamicAttributesInsideTheSections
{
    public class DynamicAttributeSectionsDto
    {
        public int SectionId { get; set; }
        public List<int> DynamicAttributesIds { get; set; } = new List<int>();
    }
}
