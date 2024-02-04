namespace SharijhaAward.Domain.Entities.CycleModel; 

public static class ValidationConstants {
    //----------------- Arabic Name --------------------//
    public const int ArabicNameMinLength = 3;
    public const int ArabicNameMaxLength = 50;
    
    //----------------- English Name --------------------//
    public const int EnglishNameMinLength = 3;
    public const int EnglishNameMaxLength = 50;
    
    //----------------- IndividualCategoryNumber --------------------//
    public const int IndividualCategoryNumberMinValue = 0;
    public const int IndividualCategoryNumberMaxValue = int.MaxValue;
    
    
    //----------------- GroupCategoryNumber --------------------//
    public const int GroupCategoryNumberMinValue = 0;
    public const int GroupCategoryNumberMaxValue = int.MaxValue;
    
    
    //----------------- MinAmountForStatement --------------------//
    public const int MinAmountForStatementMinValue = 0;
    public const int MinAmountForStatementMaxValue = int.MaxValue;
    
    //----------------- ArbitratorsResultsMargin --------------------//
    public const int ArbitratorsResultsMarginMinValue = 0;
    public const int ArbitratorsResultsMarginMaxValue = int.MaxValue;
    
}