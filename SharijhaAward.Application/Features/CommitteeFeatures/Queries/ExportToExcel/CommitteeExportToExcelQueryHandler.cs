using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitratorModel;
using SharijhaAward.Domain.Entities.CommitteeModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.CommitteeFeatures.Queries.ExportToExcel
{
    public class CommitteeExportToExcelQueryHandler
        : IRequestHandler<CommitteeExportToExcelQuery, BaseResponse<byte[]>>
    {
        private readonly IAsyncRepository<Committee> _committeeRepository;
        private readonly IAsyncRepository<Arbitrator> _arbitratorRepository;
        private readonly IExcelHelper<CommitteeExportDto> _excelHelper;
        private readonly IMapper _mapper;

        public CommitteeExportToExcelQueryHandler(IAsyncRepository<Arbitrator> arbitratorRepository, IAsyncRepository<Committee> committeeRepository, IExcelHelper<CommitteeExportDto> excelHelper, IMapper mapper)
        {
            _committeeRepository = committeeRepository;
            _arbitratorRepository = arbitratorRepository;
            _excelHelper = excelHelper;
            _mapper = mapper;
        }

        public async Task<BaseResponse<byte[]>> Handle(CommitteeExportToExcelQuery request, CancellationToken cancellationToken)
        {
            var Commitees = await _committeeRepository.ListAllAsync();
            
            var data = _mapper.Map<List<CommitteeExportDto>>(Commitees);
            
            var arbitrator = await _arbitratorRepository.ListAllAsync();
            
            foreach (var commitee in data)
            {
               
                if(arbitrator != null) 
                {
                    commitee.ChairmanArabicName = arbitrator.FirstOrDefault(a=>a.Id == commitee.ChairmanId)!.ArabicName;
                    commitee.ChairmanEnglishName = arbitrator.FirstOrDefault(a => a.Id == commitee.ChairmanId)!.EnglishName;
                }
            }

            var file = _excelHelper.ExportToExcel(data);

            return new BaseResponse<byte[]>("", true, 200, file);
        }
    }
}
