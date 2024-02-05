using SharijhaAward.Domain.Entities.ArbitratorModel;
using SharijhaAward.Domain.Entities.CycleClassModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Domain.Entities.ArbitratorClassModel
{
    public class ArbitratorClass
    {
        public  int  Id { get; set; }

        public CycleClass CycleClass { get; set; } = null!;

        [ForeignKey(nameof(CycleClass))]
        public int CycleClassId { get; set; }


        public Arbitrator Arbitrator { get; set; } = null!;

        [ForeignKey(nameof(Arbitrator))]
        public Guid ArbitratorClassId { get; set; }

    }
}
