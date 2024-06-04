using SharijhaAward.Application.Features.TermsAndConditions.Queries.GetAllTermsByCategoryId;

namespace SharijhaAward.Application.Features.CriterionFeatures.Queries.GetAllCriterionByCategoryId
{
    public class SubCriterionListVM
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public int? SizeOfAttachmentInKB { get; set; }
        public int? MaxAttachmentNumber { get; set; }
        public List<AttachmentListVM> SubCriterionAttachments { get; set; } = new List<AttachmentListVM>();
        public List<CriterionItemListVM> CriterionItemListVM { get; set; } = new List<CriterionItemListVM>();
    }
}
