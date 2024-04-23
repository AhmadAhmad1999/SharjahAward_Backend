using SharijhaAward.Domain.Constants;

namespace SharijhaAward.Application.Features.MeetingFeatures.Queries.GetAllMeetings
{
    public class GetAllMeetingsListVM
    {
        public int Id { get; set; }
        public string ArabicName { get; set; } = null!;
        public string EnglishName { get; set; } = null!;
        public string ArabicDescription { get; set; } = null!;
        public string EnglishDescription { get; set; } = null!;
        public DateTime? Date { get; set; }
        public MeetingTypes Type { get; set; }
        public bool isImplemented { get; set; }
    }
}
