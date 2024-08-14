using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.ArbitrationAuditFeatures.Queries.GetArbitrationAuditByArbitrationId
{
    public class GetArbitrationAuditByArbitrationIdQuery : IRequest<BaseResponse<GetArbitrationAuditByArbitrationIdResponse>>
    {
        public int ArbitrationId { get; set; }
        public string? lang { get; set; }
        public string? Token { get; set; }
    }
}
