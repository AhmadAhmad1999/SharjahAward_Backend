using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.InitialArbitrationFeatures.Queries.GetAllFromsForInitialArbitration
{
    public class GetAllFromsForInitialArbitrationQuery : IRequest<BaseResponse<List<GetAllFromsForInitialArbitrationListVM>>>
    {
        public string? lang { get; set; }
        public string? Token { get; set; }
        public int page { get; set; }
        public int pageSize { get; set; }
    }
}
