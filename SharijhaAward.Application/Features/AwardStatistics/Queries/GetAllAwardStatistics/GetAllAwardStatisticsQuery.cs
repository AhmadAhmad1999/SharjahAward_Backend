using MediatR;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.AwardStatisticModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.AwardStatistics.Queries.GetAllAwardStatistics
{
    public class GetAllAwardStatisticsQuery : IRequest<BaseResponse<List<AwardStatisticListVM>>>
    {
        public int page { get; set; }
        public int perPage { get; set; }
        public int? CycleId { get; set; }
        public string? lang { get; set; }
    }
}
