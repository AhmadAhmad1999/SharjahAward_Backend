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
        public Guid CycleId { get; set; }
        public string lang { get; set; } = string.Empty;
        public int page {  get; set; }
        public int pageSize { get; set; }
    }
}
