using SharijhaAward.Domain.Entities.MeetingModel;
using SharijhaAward.Domain.Entities.SubscriberModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Domain.Entities.MeetingSubscriberModel
{
    public class MeetingSubscriber
    {
        public int Id { get; set; }

        public Subscriber Subscriber { get; set; }

        [ForeignKey(nameof(Subscriber))]
        public Guid subscriberId { get; set; }

        public Meeting Meeting { get; set; }

        [ForeignKey(nameof(Meeting))]
        public Guid meetingId { get; set; }
    }
}
