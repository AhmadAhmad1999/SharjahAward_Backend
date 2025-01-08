using MediatR;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants;

namespace SharijhaAward.Application.Features.Event.Queries.GetAllInviteesByEventId
{
    public class GetAllInviteesByEventIdQuery : IRequest<BaseResponse<List<GetAllInviteesByEventIdListVM>>>
    {
        public int EventId { get; set; }
        public InviteeTypes InviteeType { get; set; }
        public string? lang { get; set; }
        public int page { get; set; } = 1;
        public int perPage { get; set; } = 10;
        public string? Email { get; set; }
    }
}
