using MediatR;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.ArbitrationModel;

namespace SharijhaAward.Application.Features.InitialArbitrationFeatures.Queries.GetAllFromsForInitialArbitration
{
    public class GetAllFromsForInitialArbitrationQuery : IRequest<BaseResponse<GetAllFromsForInitialArbitrationFullResponse>>
    {
        public ArbitrationType? ArbitrationType { get; set; }
        public string? lang { get; set; }
        public string? Token { get; set; }
        public bool? asChairman { get; set; }
        public bool AsFullAccess { get; set; }
        public int page { get; set; } = 1;
        public int perPage { get; set; } = 10;
        public List<Filter>? filters { get; set; }
    }
}
