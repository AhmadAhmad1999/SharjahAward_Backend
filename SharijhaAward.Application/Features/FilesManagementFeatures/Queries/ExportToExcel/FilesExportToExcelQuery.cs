using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.FilesManagementFeatures.Queries.ExportToExcel
{
    public class FilesExportToExcelQuery : IRequest<BaseResponse<byte[]>>
    {
        public int FilterId { get; set; }
    }
}
