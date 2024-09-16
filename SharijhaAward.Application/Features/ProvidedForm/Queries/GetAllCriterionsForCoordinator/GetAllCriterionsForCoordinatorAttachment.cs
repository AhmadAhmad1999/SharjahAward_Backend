namespace SharijhaAward.Application.Features.ProvidedForm.Queries.GetAllCriterionsForCoordinator
{
    public class GetAllCriterionsForCoordinatorAttachment
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string AttachementPath { get; set; } = string.Empty;
        public bool? IsAccepted { get; set; }
        public string? ReasonForRejecting { get; set; }
    }
}
