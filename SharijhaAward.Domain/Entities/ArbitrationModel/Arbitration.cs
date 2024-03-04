using SharijhaAward.Domain.Entities.ArbitratorModel;
using SharijhaAward.Domain.Entities.ProvidedFormModel;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Domain.Entities.ArbitrationModel
{
    public class Arbitration
    {
        public int Id { get; set; }

        public Arbitrator Arbitrator { get; set; }

        [ForeignKey(nameof(Arbitrator))]
        public Guid ArbitratorId { get; set; }


        public ProvidedForm ProvidedForm { get; set; }

        [ForeignKey(nameof(ProvidedForm))]
        public int ProvidedFormId { get; set; }

    }
}
