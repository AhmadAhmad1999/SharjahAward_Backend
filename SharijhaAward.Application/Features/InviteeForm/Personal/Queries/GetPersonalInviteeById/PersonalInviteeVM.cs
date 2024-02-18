using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.InviteeForm.Personal.Queries.GetPersonalInviteeById
{
    public class PersonalInviteeVM
    {
        public Guid Id { get; set; }
        public int UniqueIntegerId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Employer { get; set; } = string.Empty;
        public string JobTitle { get; set; } = string.Empty;
        public string TypeOfInvitee { get; set; } = string.Empty;
        public bool IsAttend { get; set; }
        public Guid EventId { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
