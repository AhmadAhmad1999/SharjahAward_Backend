using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.ContactUsPages.Queries.ForwordEmail
{
    public class ForwordEmailQuery : IRequest<BaseResponse<object>>
    {
        public int MsgId { get; set; }
        public int? TypeId { get; set; }
        public string? token { get; set; } = string.Empty;
        public string? To { get; set; } = string.Empty;
        public string lang { get; set; } = string.Empty;
    }
}
