using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.CategoryModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace SharijhaAward.Domain.Entities.TrainingWorkshopModel; 

public class TrainingWorkshop : AuditableEntity
{
    public int Id { get; set; }
    
    public string ArabicTitle { get; set; } = string.Empty;
    
    public string EnglishTitle { get; set; } = string.Empty; 
    public string ArabicDescription { get; set; } = string.Empty;
    
    public string EnglishDescription { get; set; } = string.Empty;
    
    public string Thumbnail { get; set; } = string.Empty;

    public Category Category { get; set; } = null!;

    [ForeignKey(nameof(Category))]
    public int CategoryId { get; set; }
}