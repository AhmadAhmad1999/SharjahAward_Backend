namespace SharijhaAward.Application.Features.DynamicAttributeFeatures.Queries.GetAllDynamicAttributesBySectionId
{
    public class DynamicAttributeListVM
    {
        public int Id { get; set; }
        public string Key { get; set; } = null!;
        public string Label { get; set; } = null!;
        public string PlaceHolder { get; set; } = null!;
        public string Status { get; set; } = null!;
        public string AttributeDataTypeName { get; set; } = null!;
    }
}
