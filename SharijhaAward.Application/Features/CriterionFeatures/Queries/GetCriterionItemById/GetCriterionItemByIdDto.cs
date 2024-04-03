namespace SharijhaAward.Application.Features.CriterionFeatures.Queries.GetCriterionItemById
{
    public class GetCriterionItemByIdDto
    {
        public Guid Id { get; set; }
        public string ArabicName { get; set; } = string.Empty;
        public string EnglishName { get; set; } = string.Empty;
        public int Score { get; set; }
        public int ActualScore { get; set; }
        public int? SizeOfAttachmentInKB { get; set; }
    }
}
