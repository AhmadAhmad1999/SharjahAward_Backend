using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.InitialArbitrationFeatures.Queries.GetInitialArbitrationByArbitrationId
{
    public class GetInitialArbitrationByArbitrationIdQuery : IRequest<BaseResponse<GetInitialArbitrationByArbitrationIdResponse>>
    {
        public int ArbitrationId { get; set; }
        public string? lang { get; set; }
        public string? Token { get; set; }
    }
}
