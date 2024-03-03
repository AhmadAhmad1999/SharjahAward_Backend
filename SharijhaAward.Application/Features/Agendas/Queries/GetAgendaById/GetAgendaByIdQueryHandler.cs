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

namespace SharijhaAward.Application.Features.Agendas.Queries.GetAgendaById
{
    public class GetAgendaByIdQueryHandler
        : IRequestHandler<GetAgendaByIdQuery, BaseResponse<AgendaDto>>
    {
        private readonly IAsyncRepository<Agenda> _agendaRepository;
        private readonly IMapper _mapper;

        public GetAgendaByIdQueryHandler(IAsyncRepository<Agenda> agendaRepository, IMapper mapper)
        {
            _agendaRepository = agendaRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<AgendaDto>> Handle(GetAgendaByIdQuery request, CancellationToken cancellationToken)
        {
            var agenda = await _agendaRepository.GetByIdAsync(request.Id);

            if(agenda == null)
            {
                string msg = request.lang == "en"
                    ? "The Agenda is Not Found"
                    : "الأجندة غير موجودة";

                return new BaseResponse<AgendaDto>(msg, false, 404);
            }
            else
            {
                var data = _mapper.Map<AgendaDto>(agenda);

                data.Title = request.lang == "en" ? data.EnglishTitle : data.ArabicTitle; 

                return new BaseResponse<AgendaDto>("", true, 200, data);
            }
        }
    }
}
