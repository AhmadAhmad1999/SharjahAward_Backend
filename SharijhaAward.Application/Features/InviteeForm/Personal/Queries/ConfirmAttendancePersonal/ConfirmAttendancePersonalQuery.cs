using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.InviteeForm.Personal.Queries.ConfirmAttendancePersonal
{
    public class ConfirmAttendancePersonalQuery : IRequest<Unit>
    {
        public Guid Id {  get; set; }
    }
}
