namespace SharijhaAward.Application.Features.AdvancedFormBuilderPatterns.Queries.GetAdvancedFormBuilderPatternById
{
    public class GetAdvancedFormBuilderPatternByIdDto
    {
        public int Id { get; set; }
        public string ArabicLabel { get; set; } = null!;
        public string EnglishLabel { get; set; } = null!;
        public string ArabicPlaceHolder { get; set; } = null!;
        public string EnglishPlaceHolder { get; set; } = null!;
        public bool IsRequired { get; set; } = false;
        public bool IsUnique { get; set; } = false;
        public List<GetAdvancedFormBuilderPatternByIdValues> Values { get; set; } = new List<GetAdvancedFormBuilderPatternByIdValues>();
    }
}
