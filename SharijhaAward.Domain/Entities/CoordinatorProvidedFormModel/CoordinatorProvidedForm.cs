﻿using SharijhaAward.Domain.Entities.CoordinatorModel;
using SharijhaAward.Domain.Entities.ProvidedFormModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Domain.Entities.CoordinatorProvidedFormModel
{
    public class CoordinatorProvidedForm
    {
        public int Id { get; set; }

        public Coordinator Coordinator { get; set; } = null!;

        [ForeignKey(nameof(Coordinator))]
        public Guid CoordinatorId { get; set; }


        public ProvidedForm ProvidedForm { get; set; } = null!;

        [ForeignKey(nameof(ProvidedForm))]
        public Guid ProvidedFormId { get; set; }


    }
}
