using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CoordinatorModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Coordinators.Queries.ExportToExcel
{
    public class CoordinatorExportToExcelQueryHandler
        : IRequestHandler<CoordinatorExportToExcelQuery, BaseResponse<byte[]>>
    {
        private readonly IAsyncRepository<Coordinator> _coordinatorRepository;
        private readonly IExcelHelper<CoordinatorExportVM> _excelHelper;
        private readonly IMapper _mapper;

        public CoordinatorExportToExcelQueryHandler(IExcelHelper<CoordinatorExportVM> excelHelper, IMapper mapper, IAsyncRepository<Coordinator> coordinatorRepository)
        {
            _mapper = mapper;
            _excelHelper = excelHelper;
            _coordinatorRepository = coordinatorRepository;
        }
        public async Task<BaseResponse<byte[]>> Handle(CoordinatorExportToExcelQuery request, CancellationToken cancellationToken)
        {
            var Coordinator = await _coordinatorRepository.ListAllAsync();

            var data = _mapper.Map<List<CoordinatorExportVM>>(Coordinator);

            var file = _excelHelper.ExportToExcel(data);

            return new BaseResponse<byte[]>("", true, 200, file);
        }
    }
}
