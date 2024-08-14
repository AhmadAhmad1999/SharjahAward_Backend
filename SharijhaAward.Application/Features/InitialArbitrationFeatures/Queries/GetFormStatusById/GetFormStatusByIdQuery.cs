using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.InitialArbitrationFeatures.Queries.GetFormStatusById
{
    public class GetFormStatusByIdQuery : IRequest<BaseResponse<GetFormStatusByIdDto>>
    {
        public int ArbitrationId { get; set; }
        public string lang { get; set; } = string.Empty;
    }
}
