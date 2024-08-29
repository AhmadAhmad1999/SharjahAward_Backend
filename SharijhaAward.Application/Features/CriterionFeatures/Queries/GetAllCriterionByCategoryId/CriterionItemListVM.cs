using SharijhaAward.Application.Features.TermsAndConditions.Queries.GetAllTermsByCategoryId;
using SharijhaAward.Domain.Constants.AttachmentConstant;

namespace SharijhaAward.Application.Features.CriterionFeatures.Queries.GetAllCriterionByCategoryId
{
    public class CriterionItemListVM
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public bool? rejected { get; set; }
        public int? SizeOfAttachmentInKB { get; set; }
        public int MaxAttachmentNumber { get; set; }
        public AttachmentType AttachmentType { get; set; }
        public List<AttachmentListVM> CriterionItemAttachments { get; set; } = new List<AttachmentListVM>();
    }
}
