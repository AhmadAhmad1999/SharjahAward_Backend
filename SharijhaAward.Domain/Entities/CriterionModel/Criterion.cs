using System.ComponentModel.DataAnnotations.Schema;
using SharijhaAward.Domain.Entities.ArbitrationProcedureModel;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.Common;
using SharijhaAward.Domain.Entities.IdentityModels;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Domain.Common;

namespace SharijhaAward.Domain.Entities.CriterionModel; 

public class Criterion: AuditableEntity
{
    public int Id { get; set; }
    public string ArabicTitle { get; set; } = string.Empty;
    public string EnglishTitle { get; set; } = string.Empty;
    public int Score { get; set; }
    public int SizeOfAttachmentInKB { get; set; }
    public int? ParentId { get; set; }
    public Criterion? Parent { get; set; } = null!;
    public int CategoryId { get; set; }
    public Category Category { get; set; } = null!;
    //public int ArbitrationProcedureId { get; set; }
    //public ArbitrationProcedure ArbitrationProcedure { get; set; } = null!;
}