using MediatR;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Common;

namespace SharijhaAward.Application.Features.ProvidedForm.Queries.ExportFormsWithAllItsDataToExcel
{
    public class ExportFormsWithAllItsDataToExcelQuery : IRequest<BaseResponse<byte[]>>
    {
        public List<Filter>? filters { get; set; }
        public string? lang { get; set; }
    }
}
