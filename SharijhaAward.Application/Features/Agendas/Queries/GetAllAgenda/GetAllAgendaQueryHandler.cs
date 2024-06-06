using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
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
            var agendas = await _agendaRepository
                .OrderByDescending(x => x.CreatedAt, request.page, request.perPage).Where(a=>!a.IsPrivate)
                .ToListAsync();

            var data = _mapper.Map<List<AgendaListVm>>(agendas);
         
            for(int i=0; i < data.Count; i++)
            {
                data[i].Title = request.lang == "en" ? data[i].EnglishTitle : data[i].ArabicTitle;
            }
            
            int count = await _agendaRepository.GetCountAsync(a => a.isDeleted == false);
            Pagination pagination = new Pagination(request.page,request.perPage,count);
            
            return new BaseResponse<List<AgendaListVm>>("", true, 200, data, pagination);
        }
    }
}
