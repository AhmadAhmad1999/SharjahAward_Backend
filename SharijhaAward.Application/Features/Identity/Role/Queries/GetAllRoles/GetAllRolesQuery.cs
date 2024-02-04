using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Identity.Role.Queries.GetAllRoles
{
    public class GetAllRolesQuery : IRequest <List<RoleListVm>>
    {
    }
}
