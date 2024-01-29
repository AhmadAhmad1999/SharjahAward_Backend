using SharijhaAward.Domain.Model.ArbitrationModel;
using SharijhaAward.Domain.Model.ArbitratorClassModel;
using SharijhaAward.Domain.Model.ArbitratorInterviewModel;
using SharijhaAward.Domain.Model.CategoryArbitratorModel;
using SharijhaAward.Domain.Model.Common;
using SharijhaAward.Domain.Model.IdentityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Domain.Model.ArbitratorModel
{
    public class Arbitrator:AuditInformation<User>
    {
        public Guid Id { get; set; }

        public string ArabicName { get; set; }=string.Empty;

        public string EnglishName { get; set; } = string.Empty;

        public string PhoneNumber { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;


        public virtual List<CategoryArbitrator> CategoryArbitrators { get; set; } = new();

        public virtual List<ArbitratorClass> ArbitratorClasses { get; set; } = new();
    
        public virtual List<Arbitration> Arbitration { get; set; }=new();

        public virtual List<ArbitratorInterview> ArbitratorInterviews { get; set; } = new();
    }
}
