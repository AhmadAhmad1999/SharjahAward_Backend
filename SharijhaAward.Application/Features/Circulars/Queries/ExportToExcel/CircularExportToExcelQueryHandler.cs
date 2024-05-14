using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CircularModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Circulars.Queries.ExportToExcel
{
    public class CircularExportToExcelQueryHandler
        : IRequestHandler<CircularExportToExcelQuery, BaseResponse<byte[]>>
    {
        private readonly IAsyncRepository<Circular> _circularRepository;
        private readonly IExcelHelper<CircularExportDto> _excelHelper;
        private readonly IMapper _mapper;

        public CircularExportToExcelQueryHandler(IAsyncRepository<Circular> circularRepository, IExcelHelper<CircularExportDto> excelHelper, IMapper mapper)
        {
            _circularRepository = circularRepository;
            _excelHelper = excelHelper;
            _mapper = mapper;
        }

        public async Task<BaseResponse<byte[]>> Handle(CircularExportToExcelQuery request, CancellationToken cancellationToken)
        {
            var circular = await _circularRepository.ListAllAsync();

            var data = _mapper.Map<List<CircularExportDto>>(circular);

            var file = _excelHelper.ExportToExcel(data);

            return new BaseResponse<byte[]>("", true, 200, file);
        }
    }
}
