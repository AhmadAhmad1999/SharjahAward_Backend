using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.Common;
using SharijhaAward.Domain.Entities.IdentityModels;
using SharijhaAward.Domain.Entities.MeetingSubscriberModel;
using SharijhaAward.Domain.Entities.MeetingUserModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Domain.Entities.MeetingModel
{
    public class Meeting:AuditInformation<User>
    {
        public int Id { get; set; }
        public string ArabicTitle { get; set; }

        public string EnglishTitle { get; set; } 

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set;}

        public Category Category { get; set; }

        [ForeignKey (nameof(Category))]
        public int categoryId {  get; set; }


        public virtual List<MeetingUser> MeetingUsers { get; set; } = null!;

        public virtual List<MeetingSubscriber> MeetingSubscribers { get; set; } = null!;



    }
}
