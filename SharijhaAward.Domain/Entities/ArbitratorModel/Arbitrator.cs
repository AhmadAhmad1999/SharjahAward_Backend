using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.ArbitrationModel;
using SharijhaAward.Domain.Entities.ArbitratorClassModel;

namespace SharijhaAward.Domain.Entities.ArbitratorModel
{
    public class Arbitrator : AuditableEntity
    {
        public int Id { get; set; }
        public string ArabicName { get; set; } = null!;
        public string EnglishName { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string Email { get; set; } = null!;
        public bool isChairman { get; set; } = false;
        public virtual List<Arbitration> Arbitration { get; set; }=new();
    }
}
