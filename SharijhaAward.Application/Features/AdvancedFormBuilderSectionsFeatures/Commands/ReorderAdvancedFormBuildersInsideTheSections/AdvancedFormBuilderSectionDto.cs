namespace SharijhaAward.Application.Features.AdvancedFormBuilderSectionsFeatures.Commands.ReorderAdvancedFormBuildersInsideTheSections
{
    public class AdvancedFormBuilderSectionDto
    {
        public int SectionId { get; set; }
        public int OrderId { get; set; }
        public List<AdvancedFormBuilderDto> AdvancedFormBuilderDtos { get; set; } = new List<AdvancedFormBuilderDto>();
    }
}
