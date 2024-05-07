using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.CycleModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Domain.Entities.AwardStatisticModel
{
    public class AwardStatistic : AuditableEntity
    {
        public int Id { get; set; }
        public string EnglishTitle { get; set; } = string.Empty;
        public string ArabicTitle { get; set; } = string.Empty;
        public int StatisticValue { get; set; }
        public Cycle Cycle { get; set; } = null!;

        [ForeignKey(nameof(Cycle))]
        public int CycleId { get; set; }
    }
}
