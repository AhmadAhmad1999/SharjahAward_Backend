using SharijhaAward.Domain.Constants.ProvidedFromConstants;

namespace SharijhaAward.Application.Features.Classes.Queries.GetAllProvidedFormByClassId
{
    public class GetAllProvidedFormByClassIdListVM
    {
        public int Id { get; set; }
        public int PercentCompletion { get; set; }
        public int CycleNumber { get; set; }
        public string CycleYear { get; set; } = string.Empty;
        public ProvidedFormType Type { get; set; }
        public ProvidedFormStatus Status { get; set; }
        public SubscriberType SubscriberType { get; set; }
        public int CurrentStep { get; set; }
        public int TotalStep { get; set; }
        public string CategoryName { get; set; } = string.Empty;
        public float FinalScore { get; set; }
        public Guid categoryId { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
