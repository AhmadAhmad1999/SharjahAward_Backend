using Microsoft.Extensions.DependencyInjection;
using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.EventModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Domain.Entities.InvitationModels
{
    public class GroupInvitee : AuditableEntity
    {
        public Guid Id { get; set; }
        public int UniqueIntegerId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string SchoolName { get; set; } = string.Empty;
        public string JobTitle { get; set; } = string.Empty;
        public int ExpectedNumberOfAttendees { get; set; }
        public int ActualNumberOfAttendees { get; set; }

        [ForeignKey(nameof(Event))]
        public Guid EventId { get; set; }
        public Event Event { get; set; } = null!;

        public List<Student>? Students { get; set; }
    }
}
