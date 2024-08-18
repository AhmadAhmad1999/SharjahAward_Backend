using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.LoggerFeatures.Queries.GetHistoryByController
{
    public class GetHistoryByControllerQuery : IRequest<BaseResponse<List<GetHistoryByControllerListVM>>>
    {
        public string ControllerName { get; set; } = null!;
        public string? lang { get; set; }
        public string? Token { get; set; }
        public bool ShowAll { get; set; } = false;
        public int page { get; set; } = 1;
        public int perPage { get; set; } = 10;
    }
}
