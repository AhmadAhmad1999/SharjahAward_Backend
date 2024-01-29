using SharijhaAward.Domain.Model.Common;
using SharijhaAward.Domain.Model.CriterionModel;
using SharijhaAward.Domain.Model.IdentityModels;
using SharijhaAward.Domain.Model.NoteModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Domain.Model.ArbitrationProcedureModel
{
    public class ArbitrationProcedure:AuditInformation<User>
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
