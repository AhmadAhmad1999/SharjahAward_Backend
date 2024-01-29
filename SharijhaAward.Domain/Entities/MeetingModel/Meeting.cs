using SharijhaAward.Domain.Model.CategoryModel;
using SharijhaAward.Domain.Model.Common;
using SharijhaAward.Domain.Model.IdentityModels;
using SharijhaAward.Domain.Model.MeetingSubscriberModel;
using SharijhaAward.Domain.Model.MeetingUserModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Domain.Model.MeetingModel
{
    public class Meeting:AuditInformation<User>
    {
        public Guid Id { get; set; }
        public string ArabicTitle { get; set; }

        public string EnglishTitle { get; set; } 

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set;}

        public Category Category { get; set; }

        [ForeignKey (nameof(Category))]
        public Guid categoryId {  get; set; }


        public virtual List<MeetingUser> MeetingUsers { get; set; } = null!;

        public virtual List<MeetingSubscriber> MeetingSubscribers { get; set; } = null!;



    }
}
