using MediatR;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitrationModel;

namespace SharijhaAward.Application.Features.InitialArbitrationFeatures.Queries.GetAllFromsForInitialArbitration
{
    public class GetAllFromsForInitialArbitrationQuery : IRequest<BaseResponse<GetAllFromsForInitialArbitrationFullResponse>>
    {
        public ArbitrationType? ArbitrationType { get; set; }
        public string? lang { get; set; }
        public string? Token { get; set; }
        public int page { get; set; }
        public int pageSize { get; set; }
    }
}
