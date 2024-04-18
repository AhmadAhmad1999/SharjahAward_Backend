using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.ArbitrationModel;
using SharijhaAward.Domain.Entities.ArbitratorClassModel;
using SharijhaAward.Domain.Entities.ArbitratorInterviewModel;

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
        public virtual List<ArbitratorClass> ArbitratorClasses { get; set; } = new();
        public virtual List<Arbitration> Arbitration { get; set; }=new();
        public virtual List<ArbitratorInterview> ArbitratorInterviews { get; set; } = new();
    }
}
