using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.LoggerModel;

namespace SharijhaAward.Application.Features.LoggerFeatures.Queries.ExportToExcel
{
    public class ExportToExcelHandler : IRequestHandler<ExportToExcelQuery, BaseResponse<byte[]>>
    {
        private readonly IAsyncRepository<LogUserAction> _LogUserActionRepository;
        private readonly IExcelHelper<LoggerDto> _ExcelHelper;
        private readonly IMapper _Mapper;

        public ExportToExcelHandler(IAsyncRepository<LogUserAction> LogUserActionRepository, 
            IExcelHelper<LoggerDto> ExcelHelper, 
            IMapper Mapper)
        {
            _LogUserActionRepository = LogUserActionRepository;
            _ExcelHelper = ExcelHelper;
            _Mapper = Mapper;
        }

        public async Task<BaseResponse<byte[]>> Handle(ExportToExcelQuery Request, CancellationToken cancellationToken)
        {
            List<LoggerDto> LogUserActionEntities = _Mapper.Map<List<LoggerDto>>(await _LogUserActionRepository
                .Include(x => x.User!)
                .ToListAsync());

            byte[] File = _ExcelHelper.ExportToExcel(LogUserActionEntities);

            return new BaseResponse<byte[]>("", true, 200, File);
        }
    }
}
