using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.AwardStatistics.Commands.CreateAwardStatistic
{
    public class CreateAwardStatisticCommand : IRequest<BaseResponse<object>>
    {
        public string EnglishTitle { get; set; } = string.Empty;
        public string ArabicTitle { get; set; } = string.Empty;
        public int StatisticValue { get; set; }
        public int CycleId { get; set; }
        public string? lang { get; set; }
    }
}
