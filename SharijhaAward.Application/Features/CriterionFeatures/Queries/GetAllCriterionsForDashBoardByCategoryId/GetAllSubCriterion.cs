namespace SharijhaAward.Application.Features.CriterionFeatures.Queries.GetAllCriterionsForDashBoardByCategoryId
{
    public class GetAllSubCriterion
    {
        public int Id { get; set; }
        public string EnglishTitle { get; set; } = null!;
        public string ArabicTitle { get; set; } = null!;
        public int Score { get; set; }
        public int SizeOfAttachmentInKB { get; set; }
        public int? MaxAttachmentNumber { get; set; }
        public List<GetAllSubCriterionItems> CriterionItems { get; set; } = new List<GetAllSubCriterionItems>();
    }
}
