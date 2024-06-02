using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.TrainingWorkshops.Queries.ExportToExcel;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.AgendaModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Agendas.Queries.ExportToExcel
{
    public class ExportToExcelQueryHandler
        : IRequestHandler<ExportToExcelQuery, BaseResponse<byte[]>>
    {
        private readonly IAsyncRepository<Agenda> _agendaRepository;
        private readonly IExcelHelper<AgendaExportDto> _excelHelper;
        private readonly IMapper _mapper;

        public ExportToExcelQueryHandler(IAsyncRepository<Agenda> agendaRepository, IExcelHelper<AgendaExportDto> excelHelper, IMapper mapper)
        {
            _agendaRepository = agendaRepository;
            _excelHelper = excelHelper;
            _mapper = mapper;
        }

        public async Task<BaseResponse<byte[]>> Handle(ExportToExcelQuery request, CancellationToken cancellationToken)
        {
            var agendas = await _agendaRepository.ListAllAsync();

            var data = _mapper.Map<List<AgendaExportDto>>(agendas);

            var file = _excelHelper.ExportToExcel(data);

            return new BaseResponse<byte[]>("", true, 200, file);
        }
    }
}
