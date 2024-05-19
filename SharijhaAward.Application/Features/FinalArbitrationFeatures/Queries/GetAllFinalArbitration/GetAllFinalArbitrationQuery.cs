using MediatR;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitrationModel;

namespace SharijhaAward.Application.Features.FinalArbitrationFeatures.Queries.GetAllFinalArbitration
{
    public class GetAllFinalArbitrationQuery : IRequest<BaseResponse<List<GetAllFinalArbitrationListVM>>>
    {
        public ArbitrationType? Type { get; set; }
        public string? Token { get; set; }
        public string? lang { get; set; }
        public int page { get; set; }
        public int pageSize { get; set; }
    }
}
