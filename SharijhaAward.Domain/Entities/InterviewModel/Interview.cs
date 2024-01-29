using SharijhaAward.Domain.Model.ArbitratorInterviewModel;
using SharijhaAward.Domain.Model.Common;
using SharijhaAward.Domain.Model.IdentityModels;
using SharijhaAward.Domain.Model.SubscriberInterviewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Domain.Model.InterviewModel
{
    public class Interview:AuditInformation<User>
    {
        public Guid Id { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public virtual List<SubscriberInterview> SubscriberInterviews { get; set; } = new();

        public virtual List<ArbitratorInterview> ArbitratorInterviews { get; set; } = new();
    }
}
