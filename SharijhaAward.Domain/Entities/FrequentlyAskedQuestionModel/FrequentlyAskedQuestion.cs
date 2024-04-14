using System.ComponentModel.DataAnnotations.Schema;
using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.Common;
using SharijhaAward.Domain.Entities.CycleModel;
using SharijhaAward.Domain.Entities.IdentityModels;

namespace SharijhaAward.Domain.Entities.FAQModel; 

public class FrequentlyAskedQuestion : AuditableEntity
{
    public int Id { get; set; }
    // the arabic question 
    public string ArabicQuestion { get; set; } = string.Empty;
    // the english question
    public string EnglishQuestion { get; set; } = string.Empty;
    // the arabic answer
    public string ArabicAnswer { get; set; } = string.Empty;
    // the english answer 
    public string EnglishAnswer { get; set; } = string.Empty;

    
    // navigation property to the category
    [ForeignKey(nameof(Category))]
    public int CategoryId { get; set; }
    public Category Category { get; set; } = null!;
}