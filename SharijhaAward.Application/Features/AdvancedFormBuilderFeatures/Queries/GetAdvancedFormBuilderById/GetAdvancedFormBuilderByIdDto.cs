namespace SharijhaAward.Application.Features.AdvancedFormBuilderFeatures.Queries.GetAdvancedFormBuilderById
{
    public class GetAdvancedFormBuilderByIdDto
    {
        public int Id { get; set; }
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
        public int AdvancedFormBuilderSectionId { get; set; }
        public string? AdvancedFormBuilderSectionName { get; set; }
        public int? MaxSizeInKB { get; set; }
        public AdvancedFormBuilderGeneralValidationDto? GeneralValidation { get; set; }
        public List<AdvancedFormBuilderDependencyValidationDto> ListOfDependencies { get; set; } = new List<AdvancedFormBuilderDependencyValidationDto>();
        public List<AdvancedFormBuilderListValueListVM>? Values { get; set; }
    }
}
