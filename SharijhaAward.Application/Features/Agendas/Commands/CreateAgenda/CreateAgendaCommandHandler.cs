using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
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
        private readonly IMapper _mapper;

        public CreateAgendaCommandHandler(
            IAsyncRepository<Agenda> agendaRepository, 
            IAsyncRepository<Cycle> cycleRepository, 
            IMapper mapper
            )
        {
            _agendaRepository = agendaRepository;
            _cycleRepository = cycleRepository;
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
            await _agendaRepository.AddAsync(agenda);
            msg = request.lang == "en"
                ? "Agenda has been added Successfully"
                : "تم اضافة الأجندة بنجاح";

            return new BaseResponse<object>(msg, true, 200);
            
        }
    }
}
