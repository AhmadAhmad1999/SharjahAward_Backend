using System.ComponentModel.DataAnnotations.Schema;
using SharijhaAward.Domain.Entities.Common;
using SharijhaAward.Domain.Entities.CycleModel;
using SharijhaAward.Domain.Entities.IdentityModels;
using Microsoft.EntityFrameworkCore;

namespace SharijhaAward.Domain.Entities.CycleConditionModel; 

public class CycleCondition : AuditInformation<User>{
    public Guid Id { get; set; }
    // arabic title of the condition
    public string ArabicTitle { get; set; } = string.Empty;
    // english title of the condition  
    public string EnglishTitle { get; set; } = string.Empty;
    
    // navigation property to the cycle table. 
    public Cycle Cycle { get; set; } = null!;
    public Guid CycleId { get; set; }
}