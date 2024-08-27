using System.ComponentModel.DataAnnotations;
using AutoMapper;
using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Constants.Common;
using SharijhaAward.Domain.Entities.AgendaModel;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.Common;
using SharijhaAward.Domain.Entities.CycleConditionModel;
using SharijhaAward.Domain.Entities.EducationalClassModel;
using SharijhaAward.Domain.Entities.IdentityModels;
using SharijhaAward.Domain.Entities.NewsModel;

namespace SharijhaAward.Domain.Entities.CycleModel;
public class Cycle : AuditableEntity
{
    // id of the cycle
    public int Id { get; set; }
    // year of the cycle
    public int CycleNumber {  get; set; }
    // e.g 2023-2024 just take the smaller one 
    public string Year { get; set; } = string.Empty;
    // the arabic name of the cycle.
    [MinLength(ValidationConstants.ArabicNameMinLength)]
    [MaxLength(ValidationConstants.ArabicNameMaxLength)]
    public string ArabicName { get; set; } = string.Empty;
    // the english name of the cycle.
    [MinLength(ValidationConstants.EnglishNameMinLength)]
    [MaxLength(ValidationConstants.EnglishNameMaxLength)]
    public string EnglishName { get; set; } = string.Empty;
    // the status of the cycle (active, inactive)
    // the initial state of the cycle is inactive.
    public Status Status { get; set; } = Status.Close;
    public DateTime RegistrationPortalOpeningDate { get; set; }
    public DateTime RegistrationPortalClosingDate { get; set; }
    public DateTime? SubscriberPortalClosingDate { get; set; }
    public DateTime? InitialArbitrationStartDate { get; set; }
    public DateTime? InitialArbitrationEndDate { get; set; }
    public DateTime? FinalArbitrationStartDate { get; set; }
    public DateTime? FinalArbitrationEndDate { get; set; }
    // Number of individual categories in which subscriber can entitled.
    [Range(ValidationConstants.IndividualCategoryNumberMinValue, ValidationConstants.IndividualCategoryNumberMaxValue)]
    public int IndividualCategoryNumber { get; set; } = 0; 
    public int TheUpperLimitForObtainingInformation {  get; set; }
    public int MarginOfDifferenceBetweenArbitrators {  get; set; }

    // Number of group categories in which subscriber can entitled.
    [Range(ValidationConstants.GroupCategoryNumberMinValue, ValidationConstants.GroupCategoryNumberMaxValue)]
    public int GroupCategoryNumber { get; set; } = 0;
    // navigation property to the category
    //public virtual List<Category> Categories { get; set; } = new();
    
    // navigation property to the cycle condition
    //public virtual List<CycleCondition> CycleConditions { get; set; } = new();
    
    // navigation property to the Agenda 
    //public virtual List<Agenda> Agendas { get; set; } = new();
    
    // navigation property to the News
   
}