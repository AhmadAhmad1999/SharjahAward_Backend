using SharijhaAward.Domain.Entities.Common;
using SharijhaAward.Domain.Entities.CriterionModel;
using SharijhaAward.Domain.Entities.IdentityModels;
using SharijhaAward.Domain.Entities.NoteModel;

namespace SharijhaAward.Domain.Entities.ArbitrationProcedureModel
{
    public class ArbitrationProcedure : AuditInformation<User>
    {
        public Guid Id { get; set; }
        public string ArabicGuidDescription { get; set; } = string.Empty;
        public string EnglishGuidDescription { get; set; }=string.Empty;
        public int Grade { get; set; }
        public string? StrengthPoints { get; set; }
        public string? ImprovementAreas { get; set; }
        public virtual List<Note> Notes { get; set; }=new();
        public virtual List<Criterion> Criteria { get; set; }=new();
    }
}
