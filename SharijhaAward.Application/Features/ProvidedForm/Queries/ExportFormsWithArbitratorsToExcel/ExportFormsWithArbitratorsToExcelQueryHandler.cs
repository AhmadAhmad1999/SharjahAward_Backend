using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Features.ProvidedForm.Queries.GetFormsWithArbitrators;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.ProvidedForm.Queries.ExportFormsWithArbitratorsToExcel
{
    public class ExportFormsWithArbitratorsToExcelQueryHandler
        : IRequestHandler<ExportFormsWithArbitratorsToExcelQuery, BaseResponse<byte[]>>
    {
        private readonly IMediator _mediator;
        private readonly IExcelHelper<FormsWithArbitratorsDto> _excelHelper;

        public ExportFormsWithArbitratorsToExcelQueryHandler(IMediator mediator, IExcelHelper<FormsWithArbitratorsDto> excelHelper)
        {
            _mediator = mediator;
            _excelHelper = excelHelper;
        }

        public async Task<BaseResponse<byte[]>> Handle(ExportFormsWithArbitratorsToExcelQuery request, CancellationToken cancellationToken)
        {
            var data = await _mediator.Send(new GetFormsWithArbitratorsQuery() { CycleId = request.CycleId });
            
            var file = _excelHelper.ExportToExcel(data.data!);

            return new BaseResponse<byte[]>("", true, 200, file);
        }
    }
}
