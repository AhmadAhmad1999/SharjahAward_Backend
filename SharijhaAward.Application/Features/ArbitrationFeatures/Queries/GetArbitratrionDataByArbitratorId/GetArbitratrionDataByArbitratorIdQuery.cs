using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.ArbitrationFeatures.Queries.GetArbitratrionDataByArbitratorId
{
    public class GetArbitratrionDataByArbitratorIdQuery : IRequest<BaseResponse<GetArbitratrionDataByArbitratorIdDto>>
    {
        public int Id { get; set; }
        public string? lang { get; set; }
    }
}
