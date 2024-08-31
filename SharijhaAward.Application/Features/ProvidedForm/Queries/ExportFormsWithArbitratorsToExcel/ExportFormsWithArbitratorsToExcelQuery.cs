using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.ProvidedForm.Queries.ExportFormsWithArbitratorsToExcel
{
    public class ExportFormsWithArbitratorsToExcelQuery : IRequest<BaseResponse<byte[]>>
    {
        public int? CycleId { get; set; }
    }
}
