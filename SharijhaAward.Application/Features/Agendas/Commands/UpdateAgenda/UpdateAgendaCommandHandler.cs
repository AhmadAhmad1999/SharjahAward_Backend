using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
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

            if (agendaToUpdate == null)
            {
                msg = request.lang == "en"
                    ? "Agenda is not Found"
                    : "الأجندة غير موجودة";

                return new BaseResponse<object>(msg, false, 404);
            }
            var Icon = agendaToUpdate.Icon;
            _mapper.Map(request, agendaToUpdate, typeof(UpdateAgendaCommand), typeof(Agenda));

            if (request.UpdateOnIcone)
                agendaToUpdate.Icon = await _fileService.SaveFileAsync(request.Icon!);
            else
                agendaToUpdate.Icon = Icon;

            var countOfAgenda = await _agendaRepository.GetCountAsync(a => !a.isDeleted);

            if (countOfAgenda > 0)
            {
                var AllAgenda = await _agendaRepository.ListAllAsync();
                var LastAgenda = await _agendaRepository.OrderBy(a => a.CreatedAt).LastOrDefaultAsync(a => true);
                var FirstAgenda = await _agendaRepository.OrderBy(a => a.CreatedAt).FirstOrDefaultAsync(a => true);

                if (request.CurrentDate > request.EndDate || request.CurrentDate < request.StartDate)
                {
                    msg = request.lang == "en"
                        ? "Invalid Input in date"
                        : "الوقت المدخل غير صحيح";

                    return new BaseResponse<object>(msg, false, 400);
                }

                if (request.StartDate >= FirstAgenda!.StartDate && request.EndDate <= LastAgenda!.EndDate)
                {
                    msg = request.lang == "en"
                      ? "Please Edite The Date To be In Range"
                      : "الرجاء تعديل التاريخ ليكون ضمن المجال";

                    return new BaseResponse<object>(msg, false, 400);
                }
                if (request.CurrentDate != agendaToUpdate.CurrentDate)
                {
                    for (int i = 0; i < AllAgenda.Count(); i++)
                    {
                        if (request.CurrentDate == AllAgenda[i].CurrentDate)
                        {
                            msg = request.lang == "en"
                                ? "This Date is already exist"
                                : "وقت الفعالية محجوز بالفعل";

                            return new BaseResponse<object>(msg, false, 400);
                        }

                        // Set Satet of Agenda
                        if (agendaToUpdate.StartDate >= DateTime.Now && agendaToUpdate.EndDate <= DateTime.Now)
                            agendaToUpdate.Status = AgendaStatus.Active;
                        else if (agendaToUpdate.StartDate < DateTime.Now && agendaToUpdate.EndDate < DateTime.Now)
                            agendaToUpdate.Status = AgendaStatus.Previous;
                        else agendaToUpdate.Status = AgendaStatus.Later;
                    }
                }
            }
            await _agendaRepository.UpdateAsync(agendaToUpdate);

            msg = request.lang == "en"
                ? "Agenda has been Updated"
                : "تم تعديل الأجندة بنجاح";

            return new BaseResponse<object>(msg, true, 200);
        }
    }
}
