
using SharijhaAward.Domain.Model.IdentityModels;
using SharijhaAward.Domain.Model.NotificationModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Domain.Model.UserNotificationModel
{
    public class UserNotification
    {
        public int Id { get; set; }

        public Notification Notification { get; set; }
        
        [ForeignKey(nameof(Notification))]
        public Guid notificationId { get; set; }

        public User User { get; set; }

        [ForeignKey(nameof(User))]
        public Guid UserId { get; set; }
    }
}
