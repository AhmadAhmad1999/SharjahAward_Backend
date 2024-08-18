using MediatR;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.News.Queries.GetAllNews
{
    public class GetAllNewsQuery : IRequest<BaseResponse<List<NewsListVM>>>
    {
        public string lang { get; set; } = string.Empty;
        public int page { get; set; } = 1;
        public int perPage { get; set; } = 10;
        public string? query { get; set; } = string.Empty;
        public bool Descending { get; set; } = true;
        public List<Filter>? filters { get; set; }
    }
}
