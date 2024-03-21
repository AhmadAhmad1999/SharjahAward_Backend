using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants.AgendaConstants;
using SharijhaAward.Domain.Entities.AgendaModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Agendas.Commands.UpdateAgenda
{
    public class UpdateAgendaCommandHandler
        : IRequestHandler<UpdateAgendaCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Agenda> _agendaRepository;
        private readonly IFileService _fileService;
        private readonly IMapper _mapper;

        public UpdateAgendaCommandHandler(IFileService fileService, IAsyncRepository<Agenda> agendaRepository, IMapper mapper)
        {
            _agendaRepository = agendaRepository;
            _fileService = fileService;
            _mapper = mapper;
        }

        public async Task<BaseResponse<object>> Handle(UpdateAgendaCommand request, CancellationToken cancellationToken)
        {
            var agendaToUpdate = await _agendaRepository.GetByIdAsync(request.Id);
            string msg; 

            if(agendaToUpdate == null)
            {
                msg = request.lang == "en"
                    ? "Agenda is not Found"
                    : "الأجندة غير موجودة";

                return new BaseResponse<object>(msg,false,404);
            }
            _mapper.Map(request, agendaToUpdate, typeof(UpdateAgendaCommand), typeof(Agenda));
           
            if (request.UpdateOnIcone)
                agendaToUpdate.Icon = await _fileService.SaveFileAsync(request.Icon!);
          
            // Set Satet of Agenda
            if (agendaToUpdate.StartDate >= DateTime.Now && agendaToUpdate.EndDate <= DateTime.Now)
                agendaToUpdate.Status = AgendaStatus.Active;
            else if (agendaToUpdate.StartDate < DateTime.Now && agendaToUpdate.EndDate < DateTime.Now)
                agendaToUpdate.Status = AgendaStatus.Previous;
            else agendaToUpdate.Status = AgendaStatus.Later;

            await _agendaRepository.UpdateAsync(agendaToUpdate);

            msg = request.lang == "en"
                ? "Agenda has been Updated"
                : "تم تعديل الأجندة بنجاح";

            return new BaseResponse<object>(msg, true, 200);
        }
    }
}
