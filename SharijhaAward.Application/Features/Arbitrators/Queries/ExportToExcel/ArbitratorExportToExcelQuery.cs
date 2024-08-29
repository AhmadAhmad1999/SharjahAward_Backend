using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.Arbitrators.Queries.ExportToExcel
{
    public class ArbitratorExportToExcelQuery : IRequest<BaseResponse<byte[]>>
    {
        public int? formId { get; set; }
    }
}
