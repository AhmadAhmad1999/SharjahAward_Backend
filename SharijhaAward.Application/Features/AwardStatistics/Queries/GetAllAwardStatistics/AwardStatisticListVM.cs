using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.AwardStatistics.Queries.GetAllAwardStatistics
{
    public class AwardStatisticListVM
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string EnglishTitle { get; set; } = string.Empty;
        public string ArabicTitle { get; set; } = string.Empty;
        public int StatisticValue { get; set; }
        public int CycleId { get; set; }
        public int CycleNumber { get; set; }
    }
}
