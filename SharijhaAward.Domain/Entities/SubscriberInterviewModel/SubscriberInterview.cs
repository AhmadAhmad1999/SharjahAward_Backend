using SharijhaAward.Domain.Model.InterviewModel;
using SharijhaAward.Domain.Model.SubscriberModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Domain.Model.SubscriberInterviewModel
{
    public class SubscriberInterview
    {
        public int Id { get; set; }

        public Subscriber Subscriber { get; set; } = null!;

        [ForeignKey(nameof(Subscriber))]
        public Guid SubscriberId { get; set; }

        public Interview Interview { get; set; } = null!;

        [ForeignKey(nameof(Interview))]
        public Guid InterviewId { get; set;} 
    }
}
