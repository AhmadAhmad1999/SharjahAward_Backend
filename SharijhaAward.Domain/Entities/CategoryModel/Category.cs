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
    public string ArabicName { get; set; } = string.Empty;
    public string EnglishName { get; set; } = string.Empty;
    public string ArabicDescription { get; set; } = string.Empty;
    public string EnglishDescription { get; set; } = string.Empty;
    public string Icon { get; set; } = string.Empty;
    public Status Status { get; set; } = Status.InActive;
    public CategoryClassification CategoryClassification { get; set; }

    public int? FinalArbitrationQualificationMark { get; set; }
    public int? WinningScore { get; set; }

    public bool? RelatedToClasses { get; set; }
    public int? ExpectedNumberOfWinners { get; set; }
    public Category? Parent { get; set; }
    [ForeignKey(nameof(Parent))]
    public Guid? ParentId { get; set; }
    
    
    public  List<CategoryCommittee> CategoryCommittees { get; set; } = new();
    public virtual List<Committee> Committees { get; set; } = new();
    
    public virtual List<FrequentlyAskedQuestion> FrequentlyAskedQuestions { get; set; } = new();
    
    public Cycle Cycle { get; set; } = null!;
    [ForeignKey(nameof(Cycle))]
    public Guid CycleId { get; set; }
    
    public virtual List<TermAndCondition> TermsAndConditions { get; set; } = new();
    public virtual List<TrainingWorkshop> TrainingWorkshops { get; set; } = new();
    public virtual List<Criterion> Criterions { get; set; } = new();
    public virtual List<ProvidedForm> ProvidedForms { get; set; } = new();
    public virtual List<Meeting> Meetings { get; set; } = new();
    public virtual List<CategoryArbitrator> CategoryArbitrators { get; set; } = new();
}