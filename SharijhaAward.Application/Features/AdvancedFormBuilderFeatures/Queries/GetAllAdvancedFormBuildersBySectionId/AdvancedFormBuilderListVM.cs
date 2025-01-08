namespace SharijhaAward.Application.Features.AdvancedFormBuilderFeatures.Queries.GetAllAdvancedFormBuildersBySectionId
{
    public class AdvancedFormBuilderListVM
    {
        public int Id { get; set; }
        public string Label { get; set; } = null!;
        public string PlaceHolder { get; set; } = null!;
        public string Status { get; set; } = null!;
        public string AttributeDataTypeName { get; set; } = null!;
        public bool ViewInTable { get; set; }
    }
}
