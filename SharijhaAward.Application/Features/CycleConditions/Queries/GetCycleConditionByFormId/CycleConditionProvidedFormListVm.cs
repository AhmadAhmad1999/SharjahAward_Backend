namespace SharijhaAward.Application.Features.CycleConditions.Queries.GetCycleConditionByCycleId
{
    public class CycleConditionProvidedFormListVm
    {
        public bool IsAgree { get; set; } = false;
        public int CycleConditionId { get; set; }
        public int ProvidedFormId { get; set; }
        public List<CycleConditionAttachmentListVm> Attachments { get; set; } = null!;
    }
}
