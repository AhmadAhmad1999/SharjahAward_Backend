using SharijhaAward.Application.Features.TermsAndConditions.Queries.GetAllTermsByCategoryId;
using SharijhaAward.Domain.Constants.AttachmentConstant;

namespace SharijhaAward.Application.Features.CriterionFeatures.Queries.GetAllCriterionByCategoryId
{
    public class SubCriterionListVM
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public bool? rejected { get; set; }
        public int? SizeOfAttachmentInKB { get; set; }
        public int? MaxAttachmentNumber { get; set; }
        public List<AttachmentType> AttachmentType { get; set; } = new List<AttachmentType>();
        public bool AttachFilesOnSubCriterion { get; set; }
        public List<AttachmentListVM> SubCriterionAttachments { get; set; } = new List<AttachmentListVM>();
        public List<CriterionItemListVM> CriterionItemListVM { get; set; } = new List<CriterionItemListVM>();
    }
}
