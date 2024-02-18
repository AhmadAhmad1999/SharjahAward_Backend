using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.InviteeForm.Group.Queries.ExportGroupToExcel
{
    public class ExportGroupToExcelQuery : IRequest<List<GroupExportVM>>
    {
    }
}
