using SharijhaAward.Application.Features.AdvancedFormBuilderFeatures.Queries.GetAdvancedFormBuilderById;
using SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Queries.GetAllDynamicAttributeSectionsForAdd;

namespace SharijhaAward.Application.Features.AdvancedFormBuilderSectionsFeatures.Queries.GetAllAdvancedFormBuilderSectionsForAdd
{
    public class AdvancedFormBuilderListWithListValuesVM
    {
        public int Id { get; set; }
        public string Label { get; set; } = null!;
        public string ArabicTitle { get; set; } = null!;
        public string EnglishTitle { get; set; } = null!;
        public string PlaceHolder { get; set; } = null!;
        public int AttributeDataTypeId { get; set; }
        public string AttributeDataTypeName { get; set; } = null!;
        public bool isRequired { get; set; }
        public string? InsertedValueAsString { get; set; }
        public string? InsertedValueAsBinaryFilePath { get; set; }
        public int RowId { get; set; }
        public bool? isAccepted { get; set; }
        public string? ReasonForRejecting { get; set; }
        public int? MaxSizeInKB { get; set; }
        public List<AdvancedFormBuilderListValueListVM>? AdvancedFormBuilderListValues { get; set; }
        public List<ViewWhenForAddDto>? ViewWhenForAddDtos { get; set; }
    }
}
