using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.InviteeForm.Personal.Queries.ExportToExcel
{
    public class PersonalExportQuery : IRequest<List<PersonalExportVM>>
    {
    }
}
