namespace SharijhaAward.Application.Features.Responsibilities.Queries.GetAllResponsibilitiesByUserId
{
    public class GetAllResponsibilitiesByUserIdListVM
    {
        public int ResponsibilityId { get; set; }
        public string Description { get; set; } = string.Empty;
        public bool isAccept { get; set; }
    }
}
