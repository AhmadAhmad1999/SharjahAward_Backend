using SharijhaAward.Domain.Entities.DynamicAttributeModel;

namespace SharijhaAward.Application.Features.DynamicAttributeFeatures.Queries.GetDynamicAttributeById
{
    public class GetDynamicAttributeByIdDto
    {
        public int Id { get; set; }
        public string Key { get; set; } = null!;
        public string ArabicLabel { get; set; } = null!;
        public string EnglishLabel { get; set; } = null!;
        public string ArabicPlaceHolder { get; set; } = null!;
        public string EnglishPlaceHolder { get; set; } = null!;
        public bool IsRequired { get; set; } = false;
        public bool IsUnique { get; set; } = false;
        public bool LinkedToAnotherAttribute { get; set; } = false;
        public string Status { get; set; } = null!;
        public int AttributeDataTypeId { get; set; }
        public string? AttributeDataTypeName { get; set; }
        public int DynamicAttributeSectionId { get; set; }
        public string? DynamicAttributeSectionName { get; set; }
        public GeneralValidationDto? GeneralValidation { get; set; }
        public List<DependencyValidationDto> ListOfDependencies { get; set; } = new List<DependencyValidationDto>();
        public List<DynamicAttributeListValueListVM>? Values { get; set; }
    }
}
