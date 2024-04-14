using SharijhaAward.Domain.Entities.ArbitratorInterviewModel;
using SharijhaAward.Domain.Entities.Common;
using SharijhaAward.Domain.Entities.IdentityModels;
using SharijhaAward.Domain.Entities.SubscriberInterviewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Domain.Entities.InterviewModel
{
    public class Interview:AuditInformation<User>
    {
        public int Id { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public virtual List<SubscriberInterview> SubscriberInterviews { get; set; } = new();

        public virtual List<ArbitratorInterview> ArbitratorInterviews { get; set; } = new();
    }
}
