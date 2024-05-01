using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Arbitrators.Queries.ExportToExcel
{
    public class ArbitratorExportToExcelQuery : IRequest<BaseResponse<byte[]>>
    {
    }
}
