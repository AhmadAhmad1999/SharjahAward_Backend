namespace SharijhaAward.Application.Features.DynamicAttributeFeatures.Queries.GetAllListDynamicAttributes
{
    public class GetAllListDynamicAttributesListVM
    {
        public int Id { get; set; }
        public string Label { get; set; } = null!;
        public List<DynamicAttributeListValueDto> Values { get; set; } = new List<DynamicAttributeListValueDto>();
    }
}
