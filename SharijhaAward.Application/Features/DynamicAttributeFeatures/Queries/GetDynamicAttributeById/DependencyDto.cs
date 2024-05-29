namespace SharijhaAward.Application.Features.DynamicAttributeFeatures.Queries.GetDynamicAttributeById
{
    public class DependencyDto
    {
        public int Id { get; set; }
        public string Value { get; set; } = null!;
        public string? AttributeLabel { get; set; }
        public string Operation { get; set; } = null!;
    }
}
