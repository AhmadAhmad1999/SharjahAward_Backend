using MediatR;
using SharijhaAward.Application.Features.Classes.Queries.GetClassById;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.MeetingFeatures.Queries.GetMeetingById
{
    public class GetMeetingByIdQuery : IRequest<BaseResponse<GetMeetingByIdDto>>
    {
        public int Id { get; set; }
        public string? lang { get; set; }
    }
}
