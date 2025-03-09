using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Constants;

namespace SharijhaAward.Domain.Entities.ArbitratorModel
{
    public class Arbitrator : AuditableEntity
    {
        public int Id { get; set; }
        public string ArabicName { get; set; } = null!;
        public string EnglishName { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string Email { get; set; } = null!;
        public ArbitrationLanguage ArbitrationLanguage { get; set; }
        public bool isChairman { get; set; } = false;
        public bool isSubcommitteeOfficer { get; set; } = false;
    }
}
