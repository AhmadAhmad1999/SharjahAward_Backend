using SharijhaAward.Domain.Model.ArbitratorModel;
using SharijhaAward.Domain.Model.ProvidedFormModel;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Domain.Model.ArbitrationModel
{
    public class Arbitration
    {
        public int Id { get; set; }

        public Arbitrator Arbitrator { get; set; }

        [ForeignKey(nameof(Arbitrator))]
        public Guid ArbitratorId { get; set; }


        public ProvidedForm ProvidedForm { get; set; }

        [ForeignKey(nameof(ProvidedForm))]
        public Guid ProvidedFormId { get; set; }

    }
}
