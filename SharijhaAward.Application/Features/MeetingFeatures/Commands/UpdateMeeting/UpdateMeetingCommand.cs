using MediatR;
using SharijhaAward.Application.Features.MeetingFeatures.Commands.CreateMeeting;
using SharijhaAward.Application.Helpers.ArabicNameValidationAttributeHelper;
using SharijhaAward.Application.Helpers.EnglishNameValidationAttributeHelper;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants;

namespace SharijhaAward.Application.Features.MeetingFeatures.Commands.UpdateMeeting
{
    public class UpdateMeetingCommand : IRequest<BaseResponse<object>>
    {
        public int Id { get; set; }
        [ArabicNameValidation]
        public string ArabicName { get; set; } = null!;
        [EnglishNameValidation]
        public string EnglishName { get; set; } = null!;
        public string ArabicDescription { get; set; } = null!;
        public string EnglishDescription { get; set; } = null!;
        public string? ArabicText { get; set; }
        public string? EnglishText { get; set; }
        public DateTime Date { get; set; }
        public MeetingTypes Type { get; set; }
        public List<CreateMeetingUserDto> UsersInfo { get; set; } = new List<CreateMeetingUserDto>();
        public List<int> CategoriesIds { get; set; } = new List<int>();
        public string? lang { get; set; }
    }
}
