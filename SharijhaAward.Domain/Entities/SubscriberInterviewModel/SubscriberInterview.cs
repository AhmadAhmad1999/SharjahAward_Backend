using SharijhaAward.Domain.Entities.InterviewModel;
using SharijhaAward.Domain.Entities.SubscriberModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Domain.Entities.SubscriberInterviewModel
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
