using SharijhaAward.Domain.Model.ArbitrationProcedureModel;
using SharijhaAward.Domain.Model.IdentityModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Domain.Model.NoteModel
{
    public class Note
    {
        public int Id { get; set; }

        public string ArabicText { get; set; } = string.Empty;
        public string EnglishText { get; set; } = string.Empty;

        public ArbitrationProcedure ArbitrationProcedure { get; set; } = null!;

        [ForeignKey(nameof(ArbitrationProcedure))]
        public Guid ArbitrationId { get; set; }

        public User User { get; set; } = null!;
        
        [ForeignKey(nameof(User))]
        public Guid UserId { get; set; }

    }
}
