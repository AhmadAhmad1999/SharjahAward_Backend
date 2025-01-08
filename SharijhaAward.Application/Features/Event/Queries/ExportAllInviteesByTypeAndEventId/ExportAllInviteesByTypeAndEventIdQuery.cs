using MediatR;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants;

namespace SharijhaAward.Application.Features.Event.Queries.ExportAllInviteesByTypeAndEventId
{
    public class ExportAllInviteesByTypeAndEventIdQuery : IRequest<BaseResponse<ExportAllInviteesByTypeAndEventIdResponse>>
    {
        public bool GetColumnsNamesOnly { get; set; }
        public int EventId { get; set; }
        public InviteeTypes InviteeType { get; set; }
        public string? lang { get; set; }
        public int page { get; set; } = 1;
        public int perPage { get; set; } = 10;
    }
}
