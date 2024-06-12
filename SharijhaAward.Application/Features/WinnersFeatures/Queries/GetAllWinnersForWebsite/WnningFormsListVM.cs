using SharijhaAward.Domain.Constants;

namespace SharijhaAward.Application.Features.WinnersFeatures.Queries.GetAllWinnersForWebsite
{
    public class WnningFormsListVM
    {
        public int FormId { get; set; }
        public string SubscriberName { get; set; } = null!;
        public Gender Gender { get; set; }
        public string? ProfileImagePath { get; set; }
    }
}
