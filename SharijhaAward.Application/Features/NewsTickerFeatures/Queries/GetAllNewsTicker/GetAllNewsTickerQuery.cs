using MediatR;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Common;

namespace SharijhaAward.Application.Features.NewsTickerFeatures.Queries.GetAllNewsTicker
{
    public class GetAllNewsTickerQuery : IRequest<BaseResponse<List<GetAllNewsTickerListVM>>>
    {
        public string? lang { get; set; }
        public List<Filter>? filters { get; set; }
        public int page { get; set; } = 1;
        public int perPage { get; set; } = 10;
        public bool? isActive { get; set; }
        public string? Text { get; set; }
    }
}
