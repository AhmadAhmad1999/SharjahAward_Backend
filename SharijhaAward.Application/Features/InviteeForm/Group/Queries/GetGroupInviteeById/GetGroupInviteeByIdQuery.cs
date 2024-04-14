using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.InviteeForm.Group.Queries.GetGroupInviteeById
{
    public class GetGroupInviteeByIdQuery : IRequest<GroupInviteeVM>
    {
        public int Id { get; set; }
    }
}
