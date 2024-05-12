using MediatR;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Cycles.Queries.GetAllCycles
{
    public class GetAllCyclesQuery : IRequest<BaseResponse<List<CycleListVM>>>
    {
        public string lang { get; set; } = string.Empty;
        public int page { get; set; } = 1;
        public int pageSize { get; set; } = 10;
        public List<Filter>? filters { get; set; }
    }
}
