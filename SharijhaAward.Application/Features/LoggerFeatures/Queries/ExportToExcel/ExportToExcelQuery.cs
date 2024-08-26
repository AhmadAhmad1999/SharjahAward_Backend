using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.LoggerFeatures.Queries.ExportToExcel
{
    public class ExportToExcelQuery : IRequest<BaseResponse<byte[]>>
    {
    }
}
