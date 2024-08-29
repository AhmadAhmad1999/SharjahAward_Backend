using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitrationModel;
using SharijhaAward.Domain.Entities.ArbitratorFormModel;
using SharijhaAward.Domain.Entities.ArbitratorModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Arbitrators.Queries.ExportToExcel
{
    public class ArbitratorExportToExcelQueryHandler
        : IRequestHandler<ArbitratorExportToExcelQuery, BaseResponse<byte[]>>
    {
        private readonly IAsyncRepository<Arbitrator> _arbitratorRepository;
        private readonly IExcelHelper<ArbitratorExportVM> _excelHelper;
        private readonly IAsyncRepository<ArbitratorForm> _arbitratorFormRepository;
        private readonly IMapper _mapper;

        public ArbitratorExportToExcelQueryHandler(IAsyncRepository<ArbitratorForm> arbitratorFormRepository, IAsyncRepository<Arbitrator> arbitratorRepository, IExcelHelper<ArbitratorExportVM> excelHelper, IMapper mapper)
        {
            _arbitratorRepository = arbitratorRepository;
            _arbitratorFormRepository = arbitratorFormRepository;
            _excelHelper = excelHelper;
            _mapper = mapper;
        }

        public async Task<BaseResponse<byte[]>> Handle(ArbitratorExportToExcelQuery request, CancellationToken cancellationToken)
        {

            var Arbitrators = request.formId! == null 
                ? await _arbitratorRepository.ListAllAsync()
                : await _arbitratorFormRepository
                        .Where(a => a.ProvidedFormId == request.formId)
                        .Select(f => f.Arbitrator)
                        .ToListAsync();

            var data = _mapper.Map<List<ArbitratorExportVM>>(Arbitrators);

            var file = _excelHelper.ExportToExcel(data);

            return new BaseResponse<byte[]>("", true, 200, file);
        }
    }
}
