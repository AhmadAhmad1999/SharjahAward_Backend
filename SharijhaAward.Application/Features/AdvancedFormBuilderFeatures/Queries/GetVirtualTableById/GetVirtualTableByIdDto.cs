namespace SharijhaAward.Application.Features.AdvancedFormBuilderFeatures.Queries.GetVirtualTableById
{
    public class GetVirtualTableByIdDto
    {
        public int Id { get; set; }
        public string ArabicTitle { get; set; } = null!;
        public string EnglishTitle { get; set; } = null!;
        public string Title { get; set; } = null!;
    }
}
