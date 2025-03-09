using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.IdentityModels;
using SharijhaAward.Domain.Entities.ProvidedFormModel;

namespace SharijhaAward.Domain.Entities.ArbitrationModel
{
    public class UserNoteOnFormForArbitration : AuditableEntity
    {
        public int Id { get; set; }
        public string Note { get; set; } = null!;
        public int ChairmanId { get; set; }
        public User? Chairman { get; set; }
        public int ProvidedFormId { get; set; }
        public ProvidedForm? ProvidedForm { get; set; }
        public ArbitrationStep ArbitrationStep { get; set; }
    }
}
