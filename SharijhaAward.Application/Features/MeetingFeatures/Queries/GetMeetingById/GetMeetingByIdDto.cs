using SharijhaAward.Domain.Constants;

namespace SharijhaAward.Application.Features.MeetingFeatures.Queries.GetMeetingById
{
    public class GetMeetingByIdDto
    {
        public string ArabicName { get; set; } = null!;
        public string EnglishName { get; set; } = null!;
        public string ArabicDescription { get; set; } = null!;
        public string EnglishDescription { get; set; } = null!;
        public DateTime? Date { get; set; }
        public MeetingTypes Type { get; set; }
        public List<MeetingUserDto> UsersInfo { get; set; } = new List<MeetingUserDto>();
        public List<int> CategoriesIds { get; set; } = new List<int>();
    }
}
