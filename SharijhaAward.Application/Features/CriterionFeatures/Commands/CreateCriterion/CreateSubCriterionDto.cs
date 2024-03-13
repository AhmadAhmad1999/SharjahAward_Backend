namespace SharijhaAward.Application.Features.CriterionFeatures.Commands.CreateCriterion
{
    public class CreateSubCriterionDto
    {
        public string ArabicTitle { get; set; } = string.Empty;
        public string EnglishTitle { get; set; } = string.Empty;
        public int Score { get; set; }
        public int? SizeOfAttachmentInKB { get; set; }
        public List<CreateCriterionItemDto>? CreateCriterionItemDto { get; set; }
        // public Guid ParentId { get; set; } // This is The Main Criterian Id..
        // public Guid CategoryId { get; set; } // We Can Get This From The Main Criterian Create Command Object..
    }
}
