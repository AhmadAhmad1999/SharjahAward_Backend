using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.DigitalSignatureModel;
using SharijhaAward.Domain.Entities.ProvidedFormModel;
using SharijhaAward.Domain.Entities.TemplateModel;

namespace SharijhaAward.Domain.Entities.SavedCertificateModel
{
    public class SavedCertificate : AuditableEntity
    {
        public int Id { get; set; }
        public string FilePath { get; set; } = null!;
        public int ProvidedFormId { get; set; }
        public ProvidedForm? ProvidedForm { get; set; }
        public int TemplateId { get; set; }
        public Template? Template { get; set; }
        public int DigitalSignatureId { get; set; }
        public DigitalSignature? DigitalSignature { get; set; }
        public TemplateTypes TemplateType { get; set; }
    }
}
