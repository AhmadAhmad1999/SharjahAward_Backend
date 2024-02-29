using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;
using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Constants.CategoryConstants;
using SharijhaAward.Domain.Constants.Common;
using SharijhaAward.Domain.Entities.CategoryArbitratorModel;
using SharijhaAward.Domain.Entities.CategoryCommitteeModel;
using SharijhaAward.Domain.Entities.CommitteeModel;
using SharijhaAward.Domain.Entities.Common;
using SharijhaAward.Domain.Entities.CriterionModel;
using SharijhaAward.Domain.Entities.CycleModel;
using SharijhaAward.Domain.Entities.FAQModel;
using SharijhaAward.Domain.Entities.IdentityModels;
using SharijhaAward.Domain.Entities.MeetingModel;
using SharijhaAward.Domain.Entities.ProvidedFormModel;
using SharijhaAward.Domain.Entities.TermsAndConditionsModel;
using SharijhaAward.Domain.Entities.TrainingManualModel;
using SharijhaAward.Domain.Entities.TrainingWorkshopModel;

namespace SharijhaAward.Domain.Entities.CategoryModel; 

public class Category : AuditableEntity
{
    public Guid Id { get; set; }
    // arabic name of the category
    public string ArabicName { get; set; } = string.Empty;
    // english name of the category
    public string EnglishName { get; set; } = string.Empty;
    // arabic description of the category
    public string ArabicDescription { get; set; } = string.Empty;
    // english description of the category
    public string EnglishDescription { get; set; } = string.Empty;
    // icon of the category => file 
    public string Icon { get; set; } = string.Empty;
    // classification of the category individual or group
    public CategoryClassification CategoryClassification { get; set; }
    // Subscriber portal closing date
    public DateTime? SubscriberPortalClosingDate { get; set; }
    // Initial Arbitration State Date
    public DateTime? InitialArbitrationStartDate { get; set; } 
    // Initial Arbitration End Date
    public DateTime? InitialArbitrationEndDate { get; set; }
    // Final Arbitration Start Date
    public DateTime? FinalArbitrationStartDate { get; set; }
    // Final Arbitration End Date
    public DateTime? FinalArbitrationEndDate { get; set; }
    // Final Arbitration Qualification Mark
    public int FinalArbitrationQualificationMark { get; set; }
    // Winning Score 
    public int WinningScore { get; set; }
    // status of the category (active, inactive)
    public Status Status { get; set; } = Status.InActive;
    // flag indicates if the category related to educational classes
    public bool RelatedToClasses { get; set; }
    // expected number of winners 
    public int ExpectedNumberOfWinners { get; set; }
    // navigation property to itself 
    // this indicates of category is main category or subcategory
    public Category? Parent { get; set; }
    [ForeignKey(nameof(Parent))]
    public Guid? ParentId { get; set; }
    
    
    // navigation property to the committee table
    public  List<CategoryCommittee> CategoryCommittees { get; set; } = new();
    public virtual List<Committee> Committees { get; set; } = new();
    
    
    // navigation property to the asked question 
    public virtual List<FrequentlyAskedQuestion> FrequentlyAskedQuestions { get; set; } = new();
    
    // navigation property to the cycle
    public Cycle Cycle { get; set; } = null!;
    [ForeignKey(nameof(Cycle))]
    public Guid CycleId { get; set; }
    
    
    // navigation to TermsAndConditions
    public virtual List<TermAndCondition> TermsAndConditions { get; set; } = new();
    
    
    // navigation property to the Training Manual
    public virtual List<TrainingWorkshop> TrainingWorkshops { get; set; } = new();
    
    
    // navigation property to the criterion 
    public virtual List<Criterion> Criterions { get; set; } = new();

    // navigation property to the Provided Forms
    public virtual List<ProvidedForm> ProvidedForms { get; set; } = new();
    // navigation property to the Meeting
    public virtual List<Meeting> Meetings { get; set; } = new();

    public virtual List<CategoryArbitrator> CategoryArbitrators { get; set; } = new();
}