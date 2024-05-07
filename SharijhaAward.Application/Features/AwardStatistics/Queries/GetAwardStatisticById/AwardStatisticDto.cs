using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.AwardStatistics.Queries.GetAwardStatisticById
{
    public class AwardStatisticDto
    {
        public int Id { get; set; }
        public string EnglishTitle { get; set; } = string.Empty;
        public string ArabicTitle { get; set; } = string.Empty;
        public int StatisticValue { get; set; }
        public int CycleId { get; set; }
    }
}
