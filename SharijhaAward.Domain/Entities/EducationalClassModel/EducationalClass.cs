using SharijhaAward.Domain.Model.Common;
using SharijhaAward.Domain.Model.IdentityModels;

namespace SharijhaAward.Domain.Model.EducationalClassModel; 

public class EducationalClass : AuditInformation<User>{
    public Guid Id { get; set; }
    // the arabic name of the educational class 
    public string ArabicName { get; set; } = string.Empty;
    // the english name of educational class
    public string EnglishName { get; set; } = string.Empty;
}