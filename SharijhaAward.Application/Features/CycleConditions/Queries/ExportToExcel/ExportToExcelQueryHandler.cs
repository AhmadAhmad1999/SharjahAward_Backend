using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.Cycles.Queries.ExportToExcel;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CycleConditionModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.CycleConditions.Queries.ExportToExcel
{
    public class ExportToExcelQueryHandler
        : IRequestHandler<ExportToExcelQuery, BaseResponse<byte[]>>
    {
        private readonly IAsyncRepository<CycleCondition> _cycleConditionRepository;
        private readonly IExcelHelper<CycleConditionExportDto> _excelHelper;
        private readonly IMapper _mapper;
        
        public ExportToExcelQueryHandler(IAsyncRepository<CycleCondition> cycleConditionRepository, IExcelHelper<CycleConditionExportDto> excelHelper, IMapper mapper)
        {
            _cycleConditionRepository = cycleConditionRepository;
            _excelHelper = excelHelper;
            _mapper = mapper;
        }

        public async Task<BaseResponse<byte[]>> Handle(ExportToExcelQuery request, CancellationToken cancellationToken)
        {
            var cycleConditions = await _cycleConditionRepository.ListAllAsync();

            var data = _mapper.Map<List<CycleConditionExportDto>>(cycleConditions);

            var file = _excelHelper.ExportToExcel(data);

            return new BaseResponse<byte[]>("", true, 200, file);
        }
    }
}
