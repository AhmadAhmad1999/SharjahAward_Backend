using SharijhaAward.Domain.Model.Common;
using SharijhaAward.Domain.Model.EducationalInstitutionModel;
using SharijhaAward.Domain.Model.IdentityModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Domain.Model.EducationalEntityModel
{
    public class EducationalEntity: AuditInformation<User>
    {
        public Guid Id { get; set; }

        public string Name { get; set; }=string.Empty;

        public EducationalInstitution EducationalInstitution { get; set; } = null!;
        
        [ForeignKey(nameof(EducationalInstitution))]
        public int EducationalInstitutionId {  get; set; }
    }
}
