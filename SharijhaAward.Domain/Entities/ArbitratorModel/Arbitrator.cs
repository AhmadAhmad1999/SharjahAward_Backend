using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Constants;
using SharijhaAward.Domain.Entities.ArbitrationModel;
using SharijhaAward.Domain.Entities.ArbitratorClassModel;
using SharijhaAward.Domain.Entities.CircularModel;

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
        //public virtual List<Arbitration> Arbitration { get; set; }=new();
        //public List<CircularArbitrator>? CircularArbitrators { get; set; }
        //public List<CircularChairman>? CircularChairmans { get; set; }
    }
}
