namespace SharijhaAward.Application.Features.InterviewFeatures.Queries.GetAllChangeStatusRequestsByProvidedFormId
{
    public class GetAllChangeStatusRequestsByProvidedFormIdListVM
    {
        public int RequestedById { get; set; }
        public string RequestedByName { get; set; } = string.Empty;
        public string RequestedByEmail { get; set; } = string.Empty;
        public string? Note { get; set; }
    }
}
