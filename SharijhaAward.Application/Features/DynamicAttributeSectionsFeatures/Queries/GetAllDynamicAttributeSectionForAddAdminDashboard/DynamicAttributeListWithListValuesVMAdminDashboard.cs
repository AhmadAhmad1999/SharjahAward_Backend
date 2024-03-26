using SharijhaAward.Application.Features.DynamicAttributeFeatures.Queries.GetDynamicAttributeById;

namespace SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Queries.GetAllDynamicAttributeSectionForAddAdminDashboard
{
    public class DynamicAttributeListWithListValuesVMAdminDashboard
    {
        public int Id { get; set; }
        public string Label { get; set; } = null!;
        public string PlaceHolder { get; set; } = null!;
        public int AttributeDataTypeId { get; set; }
        public string AttributeDataTypeName { get; set; } = null!;
        public bool isRequired { get; set; }
        public string? InsertedValueAsString { get; set; }
        public string? InsertedValueAsBinaryFilePath { get; set; }
        public bool isAccepted { get; set; }
        public int? MaxSizeInKB { get; set; }
        public List<DynamicAttributeListValueListVM>? DynamicAttributeListValues { get; set; }
    }
}
