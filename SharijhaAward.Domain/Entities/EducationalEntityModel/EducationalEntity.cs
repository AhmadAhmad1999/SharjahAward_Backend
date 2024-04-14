﻿using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.Common;
using SharijhaAward.Domain.Entities.EducationalInstitutionModel;
using SharijhaAward.Domain.Entities.IdentityModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Domain.Entities.EducationalEntityModel
{
    public class EducationalEntity: AuditableEntity
    {
        public int Id { get; set; }
        public string ArabicName { get; set; } = string.Empty;
        public string EnglishName { get; set; } = string.Empty;
        public List<EducationalInstitution> Institutions { get; set; } = null!;
    }
}
