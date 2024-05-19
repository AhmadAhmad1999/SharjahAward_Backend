using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Constants;
using SharijhaAward.Domain.Constants.ProvidedFromConstants;
using SharijhaAward.Domain.Entities.ArbitrationModel;
using SharijhaAward.Domain.Entities.CategoryEducationalClassModel;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.IdentityModels;
using System.ComponentModel.DataAnnotations.Schema;

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
        public int TotalStep { get; set; } = 6;
        public float FinalScore {  get; set; }
        public bool IsAccepted { get; set; }
        public string? ReasonForRejection { get; set; }

        public User User { get; set; } = null!;

        [ForeignKey(nameof(User))]
        public int userId { get; set; }
        
        public Category Category { get; set; } = null!;

        [ForeignKey(nameof(Category))]
        public int categoryId { get; set; }
        public int? CategoryEducationalClassId { get; set; }
        public CategoryEducationalClass? CategoryEducationalClass { get; set; }

        //public virtual List<Arbitration> Arbitrations { get; set; } = new();

        // public virtual List<FormCondition> FormConditions { get; set; } = new();

        //public virtual List<CoordinatorProvidedForm> CoordinatorProvidedForms { get; set; } = new();
    }
}
