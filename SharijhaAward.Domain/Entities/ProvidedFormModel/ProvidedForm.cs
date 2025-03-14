﻿using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Constants.ProvidedFromConstants;
using SharijhaAward.Domain.Entities.CategoryEducationalClassModel;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.EducationalEntityModel;
using SharijhaAward.Domain.Entities.EducationalInstitutionModel;
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
        public bool? IsAccepted { get; set; }
        public string? ReasonOfRejection { get; set; }
        public bool? needSing { get; set; }
        public DateTime? SubmitedAt { get; set; }
        public List<int>? RejectedSteps { get; set; }
        public User User { get; set; } = null!;

        [ForeignKey(nameof(User))]
        public int userId { get; set; }
        
        public Category Category { get; set; } = null!;

        [ForeignKey(nameof(Category))]
        public int categoryId { get; set; }
        public int? CategoryEducationalClassId { get; set; }
        public CategoryEducationalClass? CategoryEducationalClass { get; set; }
        public int? EducationalEntityId { get; set; }
        public EducationalEntity? EducationalEntity { get; set; }
        public int? EducationalInstitutionId { get; set; }
        public EducationalInstitution? EducationalInstitution { get; set; }
        public string Formlanguage { get; set; } = string.Empty;
        public bool EligibileForInterview { get; set; }
        //public List<CoordinatorForm> CoordinatorProvidedForms { get; set; } = null!;
        //public List<ArbitratorForm> ArbitratorProvidedForms { get; set; } = null!;

        //public virtual List<Arbitration> Arbitrations { get; set; } = new();

        // public virtual List<FormCondition> FormConditions { get; set; } = new();

        //public virtual List<CoordinatorProvidedForm> CoordinatorProvidedForms { get; set; } = new();
    }
}
