using AutoMapper;
using MediatR;
using NPOI.OpenXmlFormats.Vml;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Features.WinnersFeatures.Queries.GetAllWinnersDashboard;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.WinnersFeatures.Queries.ExportWinnersToExcel
{
    public class ExportWinnersToExcelQueryHandler
        : IRequestHandler<ExportWinnersToExcelQuery, BaseResponse<byte[]>>
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;
        private readonly IExcelHelper<GetAllWinnersDashboardListVM> _excelHelper;

        public ExportWinnersToExcelQueryHandler(IMediator mediator, IMapper mapper, IExcelHelper<GetAllWinnersDashboardListVM> excelHelper)
        {
            _mediator = mediator;
            _mapper = mapper;
            _excelHelper = excelHelper;
        }

        public async Task<BaseResponse<byte[]>> Handle(ExportWinnersToExcelQuery request, CancellationToken cancellationToken)
        {
            var winners = await _mediator.Send(new GetAllWinnersDashboardQuery()
            {
                GetDataRandomly = false,
                page = 1,
                PerPage = -1
            });

            var data = _mapper.Map<List<GetAllWinnersDashboardListVM>>(winners.data);

            var file = _excelHelper.ExportToExcel(data);

            return new BaseResponse<byte[]>("", true, 200, file);
        }
    }
}
