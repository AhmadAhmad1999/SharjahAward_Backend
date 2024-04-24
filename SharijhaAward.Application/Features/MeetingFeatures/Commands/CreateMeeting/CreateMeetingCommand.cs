using MediatR;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants;

namespace SharijhaAward.Application.Features.MeetingFeatures.Commands.CreateMeeting
{
    public class CreateMeetingCommand : IRequest<BaseResponse<object>>
    {
        public string ArabicName { get; set; } = null!;
        public string EnglishName { get; set; } = null!;
        public string ArabicDescription { get; set; } = null!;
        public string EnglishDescription { get; set; } = null!;
        public DateTime? Date { get; set; }
        public MeetingTypes Type { get; set; }
        public List<CreateMeetingUserDto> UsersInfo { get; set; } = new List<CreateMeetingUserDto>();
        public List<int> CategoriesIds { get; set; } = new List<int>();
        public string? lang { get; set; }
    }
}
