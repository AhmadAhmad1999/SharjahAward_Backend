using MediatR;
using SharijhaAward.Application.Features.RelatedAccountFeatures.Queries.GetAllReceivedRequests;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.RelatedAccountFeatures.Queries.GetallSendedRequests
{
    public class GetallSendedRequestsQuery : IRequest<BaseResponse<List<GetAllReceivedRequestsListVM>>>
    {
        public string? token { get; set; }
        public string? lang { get; set; }
        public int page { get; set; }
        public int perPage { get; set; }
    }
}
