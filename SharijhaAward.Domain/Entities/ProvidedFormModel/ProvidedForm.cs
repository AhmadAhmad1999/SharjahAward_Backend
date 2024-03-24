using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Constants;
using SharijhaAward.Domain.Constants.ProvidedFromConstants;
using SharijhaAward.Domain.Entities.ArbitrationModel;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.Common;
using SharijhaAward.Domain.Entities.CoordinatorProvidedFormModel;
using SharijhaAward.Domain.Entities.CycleModel;
using SharijhaAward.Domain.Entities.FormConditionModel;
using SharijhaAward.Domain.Entities.IdentityModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Domain.Entities.ProvidedFormModel
{
    public class ProvidedForm : AuditableEntity
    {
        public int Id { get; set; }    
        public int PercentCompletion { get; set; }
        public int CycleNumber { get; set; }
        public string CycleYear { get; set; } = string.Empty;
        public ProvidedFormType Type { get; set; } 
        public ProvidedFormStatus Status { get; set; } 
        public SubscriberType SubscriberType { get; set; }
        public int CurrentStep {  get; set; }
        public int TotalStep { get; set; } = 7;
        public float FinalScore {  get; set; }
        public User User { get; set; } = null!;

        [ForeignKey(nameof(User))]
        public Guid userId { get; set; }
        
        public Category Category { get; set; } = null!;

        [ForeignKey(nameof(Category))]
        public Guid categoryId { get; set; }

        //public virtual List<Arbitration> Arbitrations { get; set; } = new();

       // public virtual List<FormCondition> FormConditions { get; set; } = new();
    
        //public virtual List<CoordinatorProvidedForm> CoordinatorProvidedForms { get; set; } = new();
    }
}
