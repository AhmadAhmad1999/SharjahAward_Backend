using System.ComponentModel.DataAnnotations.Schema;
using SharijhaAward.Domain.Entities.ArbitrationProcedureModel;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.Common;
using SharijhaAward.Domain.Entities.IdentityModels;
using SharijhaAward.Domain.Entities.ScaleModel;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Domain.Common;

namespace SharijhaAward.Domain.Entities.CriterionModel; 

public class Criterion: AuditableEntity
{
    public Guid Id { get; set; }
    public string ArabicTitle { get; set; } = string.Empty;
    public string EnglishTitle { get; set; } = string.Empty;
    public int Score { get; set; }
    public Guid? ParentId { get; set; }
    public Criterion? Parent { get; set; } = null!;
    public Guid CategoryId { get; set; }
    public Category Category { get; set; } = null!;
    //public Guid ArbitrationProcedureId { get; set; }
    //public ArbitrationProcedure ArbitrationProcedure { get; set; } = null!;
    public virtual List<Scale> Scales { get; set; } = new();
}