using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.WinnersFeatures.Queries.ExportWinnersToExcel
{
    public class ExportWinnersToExcelQuery : IRequest<BaseResponse<byte[]>>
    {
    }
}
