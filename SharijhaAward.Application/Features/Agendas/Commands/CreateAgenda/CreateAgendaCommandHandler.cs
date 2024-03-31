using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
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
                var AllAgenda = await _agendaRepository.ListAllAsync();
                var LastAgenda = await _agendaRepository.OrderBy(a=>a.CreatedAt).LastOrDefaultAsync(a =>true);
                var FirstAgenda = await _agendaRepository.OrderBy(a => a.CreatedAt).FirstOrDefaultAsync(a => true);
               
                if(request.CurrentDate > request.EndDate || request.CurrentDate < request.StartDate)
                {
                    msg = request.lang == "en"
                        ? "Invalid Input in date"
                        : "الوقت المدخل غير صحيح";

                    return new BaseResponse<object>(msg, false, 400);
                }

                if(request.StartDate >= FirstAgenda!.StartDate && request.EndDate <= LastAgenda!.EndDate)
                {
                    msg = request.lang == "en"
                      ? "Please Edite The Date To be In Range"
                      : "الرجاء تعديل التاريخ ليكون ضمن المجال";

                    return new BaseResponse<object>(msg, false, 400);
                }

                for (int i = 0; i < AllAgenda.Count(); i++)
                {
                    if (request.CurrentDate == AllAgenda[i].CurrentDate)
                    {
                        msg = request.lang == "en"
                            ? "This Date is already exist"
                            : "وقت الفعالية محجوز بالفعل";

                        return new BaseResponse<object>(msg, false, 400);
                    }
                }

                // Set Satet of Agenda
                if (agenda.StartDate.Date <= DateTime.Now.Date && agenda.EndDate.Date >= DateTime.Now.Date)
                        agenda.Status = AgendaStatus.Active;
                    else if (agenda.StartDate.Date < DateTime.Now.Date && agenda.EndDate.Date < DateTime.Now.Date)
                        agenda.Status = AgendaStatus.Previous;
                    else agenda.Status = AgendaStatus.Later;
                
            }

            await _agendaRepository.AddAsync(agenda);
            msg = request.lang == "en"
                ? "Agenda has been added Successfully"
                : "تم اضافة الأجندة بنجاح";

            return new BaseResponse<object>(msg, true, 200);
            
        }
    }
}
