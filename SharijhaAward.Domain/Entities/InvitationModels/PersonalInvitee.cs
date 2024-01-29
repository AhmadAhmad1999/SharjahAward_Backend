using SharijhaAward.Domain.Entities.EventModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Domain.Entities.InvitationModels
{
    public class PersonalInvitee
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Employer { get; set; } = string.Empty;
        public string JobTitle {  get; set; } = string.Empty;
        public bool IsAttend { get; set; } = false;
        public Event Event { get; set; } = null!;
        [ForeignKey(nameof(Event))]
        public Guid EventId { get; set; }
        
    }
}
