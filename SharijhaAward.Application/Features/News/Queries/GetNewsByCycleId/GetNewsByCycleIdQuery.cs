using MediatR;
using SharijhaAward.Application.Features.News.Queries.GetAllNews;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.News.Queries.GetNewsByCycleId
{
    public class GetNewsByCycleIdQuery : IRequest<BaseResponse<List<NewsListVM>>>
    {
        public int? CycleId { get; set; }
        public int page { get; set; } 
        public int pageSize { get; set; }
        public string? query { get; set; }
        public string lang { get; set; } = string.Empty;
    }
}
