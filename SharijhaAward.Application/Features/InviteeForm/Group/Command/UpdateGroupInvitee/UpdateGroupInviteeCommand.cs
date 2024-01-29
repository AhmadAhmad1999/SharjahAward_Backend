using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.InviteeForm.Group.Command.UpdateGroupInvitee
{
    public class UpdateGroupInviteeCommand : IRequest<Unit>
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string SchoolName { get; set; } = string.Empty;
        public string JobTitle { get; set; } = string.Empty;
        public int ExpectedNumberOfAttendees { get; set; }
        public int ActualNumberOfAttendees { get; set; }
    }
}
