using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants.AgendaConstants;
using SharijhaAward.Domain.Entities.AgendaModel;
using SharijhaAward.Domain.Entities.CycleModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Agendas.Commands.CreateAgenda
{
    public class CreateAgendaCommandHandler
        : IRequestHandler<CreateAgendaCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Agenda> _agendaRepository;
        private readonly IAsyncRepository<Cycle> _cycleRepository;
        private readonly IFileService _fileService;
        private readonly IMapper _mapper;

        public CreateAgendaCommandHandler(
            IAsyncRepository<Agenda> agendaRepository, 
            IAsyncRepository<Cycle> cycleRepository,
            IFileService fileService,
            IMapper mapper
            )
        {
            _agendaRepository = agendaRepository;
            _cycleRepository = cycleRepository;
            _fileService = fileService;
            _mapper = mapper;
        }

        public async Task<BaseResponse<object>> Handle(CreateAgendaCommand request, CancellationToken cancellationToken)
        {
            Agenda agenda = _mapper.Map<Agenda>(request);
            Cycle cycle = await _cycleRepository.GetByIdAsync(request.CycleId);
            string msg;
            if( cycle == null )
            {
                msg = request.lang == "en"
                    ? "Cycle Not Found"
                    : "الدورة غير موجودة";

                return new BaseResponse<object>(msg, false, 404);
            }
            agenda.Icon = await _fileService.SaveFileAsync(request.Icon);

            var countOfAgenda = await _agendaRepository.GetCountAsync(a => !a.isDeleted);
           
            if (countOfAgenda > 0)
            {
                var LastAgenda = await _agendaRepository.LastOrDefaultAsync(a => true);
                var FirstAgenda = await _agendaRepository.FirstOrDefaultAsync(a => true);

                if (agenda.StartDate != null && agenda.EndDate != null)
                {
                    if (agenda.StartDate.Value.Date! <= LastAgenda!.EndDate!.Value.Date
                        || agenda.EndDate!.Value.Date >= FirstAgenda!.StartDate!.Value.Date)
                    {
                        msg = request.lang == "en"
                            ? "Edite The Date to be In Range"
                            : " الرجاء تعديل التاريخ ليكون ضمن المجال ";

                        return new BaseResponse<object>(msg, false, 400);
                    }

                    // Set Satet of Agenda
                    if (agenda.StartDate.Value.Date <= DateTime.Now.Date && agenda.EndDate.Value.Date >= DateTime.Now.Date)
                        agenda.Status = AgendaStatus.Active;
                    else if (agenda.StartDate.Value.Date < DateTime.Now.Date && agenda.EndDate.Value.Date < DateTime.Now.Date)
                        agenda.Status = AgendaStatus.Previous;
                    else agenda.Status = AgendaStatus.Later;
                }
                else
                {
                    if( agenda.CurrentDate!.Value.Date <= LastAgenda!.EndDate!.Value.Date 
                        || agenda.CurrentDate!.Value.Date >= FirstAgenda!.StartDate!.Value.Date )
                    {
                        msg = request.lang == "en"
                           ? "Edite The Date to be In Range"
                           : " الرجاء تعديل التاريخ ليكون ضمن المجال ";

                        return new BaseResponse<object>(msg, false, 400);
                    }

                    if (agenda.CurrentDate != null && agenda.CurrentDate.Value.Date == DateTime.Now.Date)
                        agenda.Status = AgendaStatus.Active;
                    else if (agenda.CurrentDate!.Value.Date < DateTime.Now.Date)
                        agenda.Status = AgendaStatus.Previous;
                    else
                        agenda.Status = AgendaStatus.Later;
                }
            }

            await _agendaRepository.AddAsync(agenda);
            msg = request.lang == "en"
                ? "Agenda has been added Successfully"
                : "تم اضافة الأجندة بنجاح";

            return new BaseResponse<object>(msg, true, 200);
            
        }
    }
}
