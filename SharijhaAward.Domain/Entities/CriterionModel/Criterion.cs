using System.ComponentModel.DataAnnotations.Schema;
using SharijhaAward.Domain.Entities.ArbitrationProcedureModel;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.Common;
using SharijhaAward.Domain.Entities.IdentityModels;
using SharijhaAward.Domain.Entities.ScaleModel;
using Microsoft.EntityFrameworkCore;

namespace SharijhaAward.Domain.Entities.CriterionModel; 

public class Criterion: AuditInformation<User> {
    public Guid Id { get; set; }
    // the arabic title of the criterion 
    public string ArabicTitle { get; set; } = string.Empty;
    // the english title of the criterion
    public string EnglishTitle { get; set; } = string.Empty;
    // the score of the criterion
    public int Score { get; set; }
    
    [DeleteBehavior(DeleteBehavior.NoAction)]
    public Criterion Parent { get; set; } = null!;
    [ForeignKey(nameof(Parent))]
    public Guid ParentId { get; set; }
    
    // navigation property to the category 
    public Category Category { get; set; } = null!;
    [ForeignKey(nameof(Category))]
    public Guid CategoryId { get; set; } 

    public ArbitrationProcedure ArbitrationProcedure { get; set; } = null!;
    [ForeignKey(nameof(ArbitrationProcedure))]
    public Guid ArbitrationProcedureId { get; set; }
    
    // navigation property to the scale
    public virtual List<Scale> Scales { get; set; } = new();


}