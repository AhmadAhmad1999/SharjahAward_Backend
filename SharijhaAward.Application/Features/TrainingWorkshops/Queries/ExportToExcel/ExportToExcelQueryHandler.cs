using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.Cycles.Queries.ExportToExcel;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.TrainingWorkshopModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.TrainingWorkshops.Queries.ExportToExcel
{
    public class ExportToExcelQueryHandler
        : IRequestHandler<ExportToExcelQuery, BaseResponse<byte[]>>
    {
        private readonly IAsyncRepository<TrainingWorkshop> _trainingWorkshopRepository;
        private readonly IExcelHelper<TrainingWorkshopExportDto> _excelHelper;
        private readonly IMapper _mapper;

        public ExportToExcelQueryHandler(IAsyncRepository<TrainingWorkshop> trainingWorkshopRepository, IExcelHelper<TrainingWorkshopExportDto> excelHelper, IMapper mapper)
        {
            _trainingWorkshopRepository = trainingWorkshopRepository;
            _excelHelper = excelHelper;
            _mapper = mapper;
        }

        public async Task<BaseResponse<byte[]>> Handle(ExportToExcelQuery request, CancellationToken cancellationToken)
        {
            var trainingWorkshops = await _trainingWorkshopRepository.ListAllAsync();

            var data = _mapper.Map<List<TrainingWorkshopExportDto>>(trainingWorkshops);

            var file = _excelHelper.ExportToExcel(data);

            return new BaseResponse<byte[]>("", true, 200, file);
        }
    }
}
