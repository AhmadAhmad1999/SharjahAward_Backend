using SharijhaAward.Domain.Constants;
using SharijhaAward.Domain.Constants.CoordinatorConstant;
using SharijhaAward.Domain.Model.Common;
using SharijhaAward.Domain.Model.CoordinatorProvidedFormModel;
using SharijhaAward.Domain.Model.IdentityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Domain.Model.CoordinatorModel
{
    public class Coordinator:AuditInformation<User>
    {
        public Guid Id { get; set; }

        public string ArabicName { get; set; }=string.Empty;
        public string EnglishName { get; set; }=string.Empty;
        public string Email { get; set; } =string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public Gender Gender { get; set; }
        public string PassportNumber { get; set; } = string.Empty;

        public string IdentityNumber { get; set; } = string.Empty;

        public EducationType EducationType { get; set; }

        public virtual List<CoordinatorProvidedForm> CoordinatorProvidedForms { get; set; } = new();
    }
}
