namespace SharijhaAward.Application.Features.CriterionFeatures.Commands.CreateCriterion
{
    public class CreateSubCriterionDto
    {
        public string ArabicTitle { get; set; } = string.Empty;
        public string EnglishTitle { get; set; } = string.Empty;
        public int Score { get; set; }
        public int? SizeOfAttachmentInKB { get; set; }
        public int MaxAttachmentNumber { get; set; }
        public List<CreateCriterionItemDto>? CreateCriterionItemDto { get; set; }
        // public int ParentId { get; set; } // This is The Main Criterian Id..
        // public int CategoryId { get; set; } // We Can Get This From The Main Criterian Create Command Object..
    }
}
