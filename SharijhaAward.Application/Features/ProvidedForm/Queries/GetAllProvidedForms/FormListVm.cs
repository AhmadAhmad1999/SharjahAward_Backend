using SharijhaAward.Domain.Constants.ProvidedFromConstants;

namespace SharijhaAward.Application.Features.ProvidedForm.Queries.GetAllProvidedForms
{
    public class FormListVm
    {
        public int Id { get; set; }
        public string? SubscriberName { get; set; }
        public string? subscriberCode { get; set; }
        public int PercentCompletion { get; set; }
        public int CycleNumber { get; set; }
        public string CycleYear { get; set; } = string.Empty;
        public ProvidedFormType Type { get; set; }
        public ProvidedFormStatus Status { get; set; }
        public SubscriberType SubscriberType { get; set; }
        public int CurrentStep { get; set; }
        public int TotalStep { get; set; }
        public string CategoryName { get; set; } = string.Empty;
        public string SubCategoryName { get; set; } = string.Empty;
        public float FinalScore { get; set; }
        public bool? IsAccepted { get; set; }
        public string ReasonOfRejection { get; set; } = string.Empty;
        public int categoryId { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool? SucceedToFinalArbitration { get; set; }
        public bool? needSing { get; set; }
        public List<int>? RejectedSteps { get; set; }

    }
}
