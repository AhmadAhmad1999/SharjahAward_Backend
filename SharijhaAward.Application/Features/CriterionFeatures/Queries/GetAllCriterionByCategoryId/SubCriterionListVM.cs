using SharijhaAward.Application.Features.TermsAndConditions.Queries.GetAllTermsByCategoryId;
using SharijhaAward.Domain.Constants.AttachmentConstant;

namespace SharijhaAward.Application.Features.CriterionFeatures.Queries.GetAllCriterionByCategoryId
{
    public class SubCriterionListVM
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public int? SizeOfAttachmentInKB { get; set; }
        public int? MaxAttachmentNumber { get; set; }
        public AttachmentType? AttachmentType { get; set; }
        public List<AttachmentListVM> SubCriterionAttachments { get; set; } = new List<AttachmentListVM>();
        public List<CriterionItemListVM> CriterionItemListVM { get; set; } = new List<CriterionItemListVM>();
    }
}
