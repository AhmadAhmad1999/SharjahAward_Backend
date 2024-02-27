using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.AgendaModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Agendas.Queries.GetAllAgenda
{
    public class GetAllAgendaQueryHandler
        : IRequestHandler<GetAllAgendaQuery, BaseResponse<List<AgendaListVm>>>
    {
        private readonly IAsyncRepository<Agenda> _agendaRepository;
        private readonly IMapper _mapper;

        public GetAllAgendaQueryHandler(IAsyncRepository<Agenda> agendaRepository, IMapper mapper)
        {
            _agendaRepository = agendaRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<List<AgendaListVm>>> Handle(GetAllAgendaQuery request, CancellationToken cancellationToken)
        {
            var agendas = await _agendaRepository.GetPagedReponseAsync(request.page, request.pageSize);
            string msg;
            if (agendas.Count == 0)
            {
                msg = request.lang == "en"
                    ? "There is no Agendas"
                    : "لا يوجد أجندة";

                return new BaseResponse<List<AgendaListVm>>(msg, false, 404);
            }
            else
            {
                List<AgendaListVm> data = new List<AgendaListVm>();
                for(int i = 0; i < agendas.Count; i++)
                {
                    AgendaListVm listVm = new AgendaListVm();
                    listVm.Id = agendas[i].Id;
                    listVm.Title = request.lang == "en" ? agendas[i].EnglishTitle : agendas[i].ArabicTitle;
                    listVm.EnglishTitle = agendas[i].EnglishTitle;
                    listVm.ArabicTitle = agendas[i].ArabicTitle;
                    listVm.IsActive = agendas[i].IsActive;
                    listVm.CycleId = agendas[i].CycleId;
                    listVm.Date = agendas[i].Date;
                    listVm.Icon = agendas[i].Icon;

                    data.Add(listVm);
                }
                _mapper.Map<List<AgendaListVm>>(data);

                msg = request.lang == "en"
                    ? "Agendas Retrived Succsessfully"
                    : "تم إسترجاع الأجندة بنجاح";

                return new BaseResponse<List<AgendaListVm>>(msg, true, 200, data);
            }
        }
    }
}
