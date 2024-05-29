namespace SharijhaAward.Application.Features.DynamicAttributePatterns.Queries.GetAllDynamicAttributePattern
{
    public class GetAllDynamicAttributePatternListVM
    {
        public int Id { get; set; }
        public string ArabicLabel { get; set; } = null!;
        public string EnglishLabel { get; set; } = null!;
        public string ArabicPlaceHolder { get; set; } = null!;
        public string EnglishPlaceHolder { get; set; } = null!;
    }
}
