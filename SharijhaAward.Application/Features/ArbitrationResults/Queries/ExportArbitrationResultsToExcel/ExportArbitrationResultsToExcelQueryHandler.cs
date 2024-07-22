using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.ArbitrationResults.Queries.GetAllArbitrationResults;
using SharijhaAward.Application.Features.WinnersFeatures.Queries.GetAllWinnersDashboard;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.ArbitrationResults.Queries.ExportArbitrationResultsToExcel
{
    public class ExportArbitrationResultsToExcelQueryHandler
        : IRequestHandler<ExportArbitrationResultsToExcelQuery, BaseResponse<byte[]>>
    {
        private readonly IExcelHelper<GetAllArbitrationResultsListVM> _excelHelper;
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;

        public ExportArbitrationResultsToExcelQueryHandler(IExcelHelper<GetAllArbitrationResultsListVM> excelHelper, IMapper mapper, IMediator mediator)
        {
            _excelHelper = excelHelper;
            _mapper = mapper;
            _mediator = mediator;
        }

        public async Task<BaseResponse<byte[]>> Handle(ExportArbitrationResultsToExcelQuery request, CancellationToken cancellationToken)
        {
            var ArbitrationResults = await _mediator.Send(new GetAllArbitrationResultsQuery()
            {
                page = 1,
                PerPage = -1
            });

            var data = _mapper.Map<List<GetAllArbitrationResultsListVM>>(ArbitrationResults.data);

            var file = _excelHelper.ExportToExcel(data);

            return new BaseResponse<byte[]>("", true, 200, file);
        }
    }
}
