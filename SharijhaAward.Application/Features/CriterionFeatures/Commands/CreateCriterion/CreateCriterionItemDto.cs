namespace SharijhaAward.Application.Features.CriterionFeatures.Commands.CreateCriterion
{
    public class CreateCriterionItemDto
    {
        public string ArabicName { get; set; } = string.Empty;
        public string EnglishName { get; set; } = string.Empty;
        public int Score { get; set; }
        // public int ActualScore { get; set; }
        //public Guid CriterionId { get; set; } // We Can Get This Id From The CreateSubCriterionDto Object After Add It To The Database..
    }
}
