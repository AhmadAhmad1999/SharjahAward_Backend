using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Helpers.ExportReportForAdvancedFormBuilder
{
    public class ExportReportForAdvancedFormBuilderCommand : IRequest<BaseResponse<List<object>>>
    {
        public int VirtualTableForSectionId { get; set; }
        public string? lang { get; set; }
        public bool ExportDataToExcel { get; set; }
        public int page { get; set; } = 1;
        public int pageSize { get; set; } = 10;
    }
}
