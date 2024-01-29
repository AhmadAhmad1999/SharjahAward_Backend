using SharijhaAward.Domain.Model.ArbitratorModel;
using SharijhaAward.Domain.Model.CycleClassModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Domain.Model.ArbitratorClassModel
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
