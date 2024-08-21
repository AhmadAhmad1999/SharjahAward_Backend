using MediatR;
using SharijhaAward.Application.Features.Arbitrators.Queries.GetAllArbitrators;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Arbitrators.Queries.GetArbitratorsByFormId
{
    public class GetArbitratorsByFormIdQuery : IRequest<BaseResponse<List<ArbitratorsListVM>>>
    {
        public int formId { get; set; }
        public int page { get; set; } = 1;
        public int perPage { get; set; } = 10;
        public string token { get; set; } = string.Empty;
        public string? lang { get; set; }
    }
}
