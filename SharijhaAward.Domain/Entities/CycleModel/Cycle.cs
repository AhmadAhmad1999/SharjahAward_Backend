using System.ComponentModel.DataAnnotations;
using SharijhaAward.Domain.Constants.Common;
using SharijhaAward.Domain.Entities.AgendaModel;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.Common;
using SharijhaAward.Domain.Entities.CycleConditionModel;
using SharijhaAward.Domain.Entities.IdentityModels;
using SharijhaAward.Domain.Entities.NewsModel;

namespace SharijhaAward.Domain.Entities.CycleModel;
public class Cycle  {
    // id of the cycle
    public Guid Id { get; set; }
    // year of the cycle
    // e.g 2023-2024 just take the smaller one 
    public int Year { get; set; }
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
    public Status Status { get; set; } = Status.InActive;
    
    // Number of individual categories in which subscriber can entitled.
    [Range(ValidationConstants.IndividualCategoryNumberMinValue, ValidationConstants.IndividualCategoryNumberMaxValue)]
    public int IndividualCategoryNumber { get; set; } = 0; 
    
    // Number of group categories in which subscriber can entitled.
    [Range(ValidationConstants.GroupCategoryNumberMinValue, ValidationConstants.GroupCategoryNumberMaxValue)]
    public int GroupCategoryNumber { get; set; } = 0;
    
    // Minimum amount for obtaining a statement.
    [Range(ValidationConstants.MinAmountForStatementMinValue, ValidationConstants.MinAmountForStatementMaxValue)]
    public int MinAmountForStatement { get; set; } = 0;
    
    // Margin of Difference between the results of the arbitrators.
    [Range(ValidationConstants.ArbitratorsResultsMarginMinValue, ValidationConstants.ArbitratorsResultsMarginMaxValue)]
    public int ArbitratorsResultsMargin { get; set; } = 0;
    
    // navigation property to the category
    public virtual List<Category> Categories { get; set; } = new();
    
    // navigation property to the cycle condition
    public virtual List<CycleCondition> CycleConditions { get; set; } = new();
    
    // navigation property to the Agenda 
    public virtual List<Agenda> Agendas { get; set; } = new();
    
    // navigation property to the News
    public virtual List<News> News { get; set; } = new();
}