namespace SharijhaAward.Application.Features.AdvancedFormBuilderPatterns.Queries.GetAllAdvancedFormBuilderPattern
{
    public class GetAllAdvancedFormBuilderPatternListVM
    {
        public int Id { get; set; }
        public string ArabicLabel { get; set; } = null!;
        public string EnglishLabel { get; set; } = null!;
        public string ArabicPlaceHolder { get; set; } = null!;
        public string EnglishPlaceHolder { get; set; } = null!;
    }
}
