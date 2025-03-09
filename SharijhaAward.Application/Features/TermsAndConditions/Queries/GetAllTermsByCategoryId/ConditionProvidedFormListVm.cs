namespace SharijhaAward.Application.Features.TermsAndConditions.Queries.GetAllTermsByCategoryId
{
    public class ConditionProvidedFormListVm
    {
        public bool IsAgree { get; set; } = false;
        public List<AttachmentListVM> Attachments { get; set; } = null!;
        public int TermAndConditionId { get; set; }
        public int ProvidedFormId { get; set; }
    }
}
