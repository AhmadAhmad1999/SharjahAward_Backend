using MediatR;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Common;

namespace SharijhaAward.Application.Features.News.Queries.GetAllNews
{
    public class GetAllNewsQuery : IRequest<BaseResponse<List<NewsListVM>>>
    {
        public string lang { get; set; } = string.Empty;
        public int page { get; set; } = 1;
        public int perPage { get; set; } = 10;
        public string? query { get; set; } = string.Empty;
        public bool Descending { get; set; } = true;
        public DateOnly? DateOnlyFilter { get; set; }
        public TimeOnly? TimeOnlyFilter { get; set; }
        public List<Filter>? filters { get; set; }
    }
}
