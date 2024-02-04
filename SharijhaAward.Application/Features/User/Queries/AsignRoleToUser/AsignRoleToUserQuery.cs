using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.User.Queries.AsignRoleToUser
{
    public class AsignRoleToUserQuery : IRequest<Unit>
    {
        public Guid userId {  get; set; }
        public Guid roleId { get; set; }
    }
}
