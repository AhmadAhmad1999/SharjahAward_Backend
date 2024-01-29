using SharijhaAward.Domain.Model.NotificationModel;
using SharijhaAward.Domain.Model.SubscriberModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Domain.Model.SubscriberNotificationModel
{
    public class SubscriberNotification
    {
        public int Id { get; set; }

        public Notification Notification { get; set; }

        [ForeignKey(nameof(Notification))]
        public Guid notificationId { get; set; }

        public Subscriber Subscriber { get; set; }

        [ForeignKey(nameof(Subscriber))]
        public Guid SubscriberId { get; set;}

    }
}
