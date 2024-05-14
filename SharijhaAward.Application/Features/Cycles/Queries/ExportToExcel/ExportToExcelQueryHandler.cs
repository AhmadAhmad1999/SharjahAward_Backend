using AutoMapper;
using MediatR;
using QRCoder.Extensions;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CycleModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Cycles.Queries.ExportToExcel
{
    public class ExportToExcelQueryHandler
        : IRequestHandler<ExportToExcelQuery, BaseResponse<byte[]>>
    {
        private readonly IAsyncRepository<Cycle> _cycleRepository;
        private readonly IExcelHelper<CycleExportDto> _excelHelper;
        private readonly IMapper _mapper;

        public ExportToExcelQueryHandler(IAsyncRepository<Cycle> cycleRepository, IExcelHelper<CycleExportDto> excelHelper, IMapper mapper)
        {
            _cycleRepository = cycleRepository;
            _excelHelper = excelHelper;
            _mapper = mapper;
        }

        async Task<BaseResponse<byte[]>> IRequestHandler<ExportToExcelQuery, BaseResponse<byte[]>>.Handle(ExportToExcelQuery request, CancellationToken cancellationToken)
        {
            var cycles = await _cycleRepository.ListAllAsync();

            var data = _mapper.Map<List<CycleExportDto>>(cycles);

            var file = _excelHelper.ExportToExcel(data);

            return new BaseResponse<byte[]>("", true, 200, file);
        }
    }
}
