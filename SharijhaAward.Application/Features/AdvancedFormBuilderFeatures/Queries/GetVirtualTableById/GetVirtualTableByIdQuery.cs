using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.AdvancedFormBuilderFeatures.Queries.GetVirtualTableById
{
    public class GetVirtualTableByIdQuery : IRequest<BaseResponse<GetVirtualTableByIdDto>>
    {
        public string PrivateHashKey { get; set; } = null!;
        public string lang { get; set; } = string.Empty;
    }
}
