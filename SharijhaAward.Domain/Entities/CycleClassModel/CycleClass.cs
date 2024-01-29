using SharijhaAward.Domain.Model.ArbitratorClassModel;
using SharijhaAward.Domain.Model.CycleModel;
using SharijhaAward.Domain.Model.EducationalClassModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Domain.Model.CycleClassModel
{
    public class CycleClass
    {
        public int Id { get; set; }

        public Cycle Cycle { get; set; }
        [ForeignKey(nameof(Cycle))]
        public Guid CycleId { get; set; }

        public EducationalClass EducationalClass { get; set; }
        [ForeignKey(nameof(EducationalClass))]
        public Guid EducationalClassId { get; set; }


        public virtual List<ArbitratorClass> ArbitratorClasses { get; set; } = new();

    }
}
