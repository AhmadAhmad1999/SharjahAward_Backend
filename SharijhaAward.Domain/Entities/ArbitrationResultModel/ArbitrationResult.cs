using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.ProvidedFormModel;

namespace SharijhaAward.Domain.Entities.ArbitrationResultModel
{
    public class ArbitrationResult : AuditableEntity
    {
        public int Id { get; set; }
        public int ProvidedFormId { get; set; }
        public ProvidedForm? ProvidedForm { get; set; }
        public bool EligibleForCertification { get; set; }
        public bool EligibleForAStatement { get; set; }
        public bool EligibleToWin { get; set; }
        public bool GotCertification { get; set; }
        public bool GotStatement { get; set; }
        public bool Winner { get; set; }
        public DateTime? DateOfObtainingTheCertificate { get; set; }
        public DateTime? DateOfObtainingTheStatement { get; set; }
        public DateTime? WinningDate { get; set; }
    }
}
