using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.CycleConditions.Queries.ExportToExcel
{
    public class ExportToExcelQuery : IRequest<BaseResponse<byte[]>>
    {
    }
}
