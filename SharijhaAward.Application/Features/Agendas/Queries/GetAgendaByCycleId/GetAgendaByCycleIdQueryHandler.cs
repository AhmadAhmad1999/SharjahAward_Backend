using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.Agendas.Queries.GetAllAgenda;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.AgendaModel;
using SharijhaAward.Domain.Entities.CycleModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Agendas.Queries.GetAgendaByCycleId
{
    public class GetAgendaByCycleIdQueryHandler
        : IRequestHandler<GetAgendaByCycleIdQuery, BaseResponse<List<AgendaListVm>>>
    {
        private readonly IAsyncRepository<Agenda> _agendaRepository;
        private readonly IAsyncRepository<Cycle> _cycleRepository;
        private readonly IMapper _mapper;

        public GetAgendaByCycleIdQueryHandler(IAsyncRepository<Agenda> agendaRepository, IAsyncRepository<Cycle> cycleRepository, IMapper mapper)
        {
            _agendaRepository = agendaRepository;
            _cycleRepository = cycleRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<List<AgendaListVm>>> Handle(GetAgendaByCycleIdQuery request, CancellationToken cancellationToken)
        {
            var Cycle = request.CycleId == null
                ? await _cycleRepository.FirstOrDefaultAsync(a => a.Status == Domain.Constants.Common.Status.Active)
                : await _cycleRepository.FirstOrDefaultAsync(a => a.Id == request.CycleId);

            if (Cycle == null)
            {
               string msg = request.lang == "en"
                ? "There is no Active Cycle yet"
                : "لا يوجد دورات فعالة ";

                return new BaseResponse<List<AgendaListVm>>(msg, false, 400);
            }
            var Agendas = await _agendaRepository.GetWhereThenPagedReponseAsync(a => a.CycleId == Cycle.Id && !a.IsPrivate, request.page,request.pageSize);
             
            var data = _mapper.Map<List<AgendaListVm>>(Agendas).OrderBy(a => a.StartDate).ToList();

            for(int i = 0; i < data.Count(); i++)
            {
                data[i].Title = request.lang == "en"
                    ? data[i].EnglishTitle
                    : data[i].ArabicTitle;
            }
            var count = await _agendaRepository.GetCountAsync(a => !a.isDeleted && a.CycleId == Cycle.Id);
            Pagination pagination = new Pagination(request.page, request.pageSize, count);
            
            return new BaseResponse<List<AgendaListVm>>("", true, 200, data,pagination);
        }
    }
}
