using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.MeetingFeatures.Queries.GetAllMeetings
{
    public class GetAllMeetingsQuery : IRequest<BaseResponse<List<GetAllMeetingsListVM>>>
    {
        public string? lang { get; set; }
        public int page { get; set; }
        public int pageSize { get; set; }
    }
}
