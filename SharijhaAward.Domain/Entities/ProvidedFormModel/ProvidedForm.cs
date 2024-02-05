using SharijhaAward.Domain.Constants;
using SharijhaAward.Domain.Constants.ProvidedFromConstants;
using SharijhaAward.Domain.Entities.ArbitrationModel;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.Common;
using SharijhaAward.Domain.Entities.CoordinatorProvidedFormModel;
using SharijhaAward.Domain.Entities.CycleModel;
using SharijhaAward.Domain.Entities.FormConditionModel;
using SharijhaAward.Domain.Entities.IdentityModels;
using SharijhaAward.Domain.Entities.SubscriberModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Domain.Entities.ProvidedFormModel
{
    public class ProvidedForm : AuditInformation<User>
    {
        public Guid Id { get; set; }    

        public  required string Arabic_Name { get; set; }

        public required string English_Name { get; set; }

        public required string Male { get; set; }

        public  required string Email { get; set; }

        public string PhoneNumber { get; set; } = string.Empty;

        public string Identity_Number { get; set; } = string.Empty;

        public EducationType EducationType { get; set; } = new();

        public ProvidedFormStatus Status { get; set; }

        public Subscriber Subscriber { get; set; } = null!;

        [ForeignKey(nameof(Subscriber))]
        public Guid subscriberId { get; set; }
        
        public Category Category { get; set; } = null!;

        [ForeignKey(nameof(Category))]
        public Guid categoryId { get; set; }

        public virtual List<Arbitration> Arbitrations { get; set; } = new();

        public virtual List<FormCondition> FormConditions { get; set; } = new();
    
        public virtual List<CoordinatorProvidedForm> CoordinatorProvidedForms { get; set; } = new();
    }
}
