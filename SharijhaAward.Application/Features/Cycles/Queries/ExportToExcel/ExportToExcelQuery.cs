using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Cycles.Queries.ExportToExcel
{
    public class ExportToExcelQuery : IRequest<BaseResponse<byte[]>>
    {
    }
}
