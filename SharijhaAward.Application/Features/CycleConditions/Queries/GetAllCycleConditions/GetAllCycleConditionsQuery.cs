using MediatR;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.CycleConditions.Queries.GetAllCycleConditions
{
    public class GetAllCycleConditionsQuery : IRequest<BaseResponse<List<CycleConditionListVM>>>
    {
        public int page { get; set; } = 1;
        public int perPage { get; set; } = 10;
        public List<Filter>? filters { get; set; }
        public string lang { get; set; } = string.Empty;
        public int? CycleId { get; set; }


    }
}
