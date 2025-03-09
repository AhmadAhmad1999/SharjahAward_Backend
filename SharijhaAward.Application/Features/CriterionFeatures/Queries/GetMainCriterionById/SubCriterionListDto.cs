using SharijhaAward.Domain.Constants.AttachmentConstant;

namespace SharijhaAward.Application.Features.CriterionFeatures.Queries.GetMainCriterionById
{
    public class SubCriterionListDto
    {
        public int Id { get; set; }
        public string ArabicTitle { get; set; } = string.Empty;
        public string EnglishTitle { get; set; } = string.Empty;
        public int Score { get; set; }
        public int? SizeOfAttachmentInKB { get; set; }
        public int? MaxAttachmentNumber { get; set; }
        public List<AttachmentType> AttachmentType { get; set; } = new List<AttachmentType>();
        public bool AttachFilesOnSubCriterion { get; set; }
        public List<CriterionItemListDto>? CriterionItems { get; set; }
    }
}
