using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.ArbitrationModel;
using SharijhaAward.Domain.Entities.ArbitratorClassModel;
using SharijhaAward.Domain.Entities.ArbitratorInterviewModel;

namespace SharijhaAward.Domain.Entities.ArbitratorModel
{
    public class Arbitrator : AuditableEntity
    {
        public Guid Id { get; set; }
        public string ArabicName { get; set; }=string.Empty;
        public string EnglishName { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public virtual List<ArbitratorClass> ArbitratorClasses { get; set; } = new();
        public virtual List<Arbitration> Arbitration { get; set; }=new();
        public virtual List<ArbitratorInterview> ArbitratorInterviews { get; set; } = new();
    }
}
