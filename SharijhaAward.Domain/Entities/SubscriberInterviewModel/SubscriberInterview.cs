using SharijhaAward.Domain.Entities.IdentityModels;
using SharijhaAward.Domain.Entities.InterviewModel;
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

        public User User { get; set; } = null!;

        [ForeignKey(nameof(User))]
        public Guid UserId { get; set; }

        public Interview Interview { get; set; } = null!;

        [ForeignKey(nameof(Interview))]
        public Guid InterviewId { get; set;} 
    }
}
