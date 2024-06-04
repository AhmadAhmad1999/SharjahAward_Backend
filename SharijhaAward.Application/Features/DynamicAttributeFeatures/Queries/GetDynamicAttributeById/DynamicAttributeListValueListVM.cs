namespace SharijhaAward.Application.Features.DynamicAttributeFeatures.Queries.GetDynamicAttributeById
{
    public class DynamicAttributeListValueListVM
    {
        public int Id { get; set; }
        public string ArabicValue { get; set; } = null!;
        public string EnglishValue { get; set; } = null!;
        public string Value { get; set; } = null!;
    }
}
