using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.Circulars.Queries.ExportToExcel
{
    public class CircularExportToExcelQuery : IRequest<BaseResponse<byte[]>>
    {
    }
}
