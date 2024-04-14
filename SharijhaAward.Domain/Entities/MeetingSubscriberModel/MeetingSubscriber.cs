using SharijhaAward.Domain.Entities.IdentityModels;
using SharijhaAward.Domain.Entities.MeetingModel;
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

        public User? User { get; set; }

        [ForeignKey(nameof(User))]
        public int UserId { get; set; }

        public Meeting Meeting { get; set; }

        [ForeignKey(nameof(Meeting))]
        public int meetingId { get; set; }
    }
}
