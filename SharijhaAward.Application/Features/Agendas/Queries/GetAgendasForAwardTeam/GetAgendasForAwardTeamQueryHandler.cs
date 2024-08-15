using Aspose.Pdf;
using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.Agendas.Queries.GetAllAgenda;
using SharijhaAward.Application.Features.News.Queries.ExportToExcel;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.AgendaModel;
using SharijhaAward.Domain.Entities.CycleModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Agendas.Queries.GetAgendasForAwardTeam
{
    public class GetAgendasForAwardTeamQueryHandler
        : IRequestHandler<GetAgendasForAwardTeamQuery, BaseResponse<List<AgendaListVm>>>
    {
        private readonly IAsyncRepository<Agenda> _agendaRepository;
        private readonly IAsyncRepository<Cycle> _cycleRepository;
        private readonly IUserRepository _userRepository;
        private readonly IJwtProvider _jwtProvider;
        private readonly IMapper _mapper;

        public GetAgendasForAwardTeamQueryHandler(IAsyncRepository<Agenda> agendaRepository, IAsyncRepository<Cycle> cycleRepository, IUserRepository userRepository, IJwtProvider jwtProvider, IMapper mapper)
        {
            _agendaRepository = agendaRepository;
            _cycleRepository = cycleRepository;
            _userRepository = userRepository;
            _jwtProvider = jwtProvider;
            _mapper = mapper;
        }

        public async Task<BaseResponse<List<AgendaListVm>>> Handle(GetAgendasForAwardTeamQuery request, CancellationToken cancellationToken)
        {
            var AdminId = _jwtProvider.GetUserIdFromToken(request.token!);

            var Admin = AdminId != null
                ? await _userRepository.GetByIdAsync(int.Parse(AdminId))
                : null;

            if(Admin == null)
            {
                return new BaseResponse<List<AgendaListVm>>("UnAuth", false, 401);
            }

            var Cycle = request.CycleId == null
               ? await _cycleRepository.FirstOrDefaultAsync( a => a.Status == Domain.Constants.Common.Status.Active)
               : await _cycleRepository.FirstOrDefaultAsync(a => a.Id == request.CycleId);


            if (Cycle == null)
            {
                string msg = request.lang == "en"
                 ? "There is no Active Cycle yet"
                 : "لا يوجد دورات فعالة ";

                return new BaseResponse<List<AgendaListVm>>(msg, false, 400);
            }
            FilterObject filterObject = new FilterObject() { Filters = request.filters };

            var Agendas = await _agendaRepository.GetWhereThenPagedReponseAsync(a => a.CycleId == Cycle.Id , filterObject, request.page, request.perPage);
            
            foreach (var agenda in Agendas)
            {
                if (DateTime.Now >= agenda.StartDate && DateTime.Now <= agenda.EndDate)
                {
                    agenda.Status = Domain.Constants.AgendaConstants.AgendaStatus.Active;
                }
                else if (DateTime.Now > agenda.StartDate && DateTime.Now > agenda.EndDate)
                {
                    agenda.Status = Domain.Constants.AgendaConstants.AgendaStatus.Previous;
                }
                else if (DateTime.Now < agenda.StartDate && DateTime.Now < agenda.EndDate)
                {
                    agenda.Status = Domain.Constants.AgendaConstants.AgendaStatus.Later;
                }
                await _agendaRepository.UpdateAsync(agenda);
            }

            var data = _mapper.Map<List<AgendaListVm>>(Agendas).OrderBy(a => a.StartDate).ToList();

            for (int i = 0; i < data.Count(); i++)
            {
                data[i].Title = request.lang == "en"
                    ? data[i].EnglishTitle
                    : data[i].ArabicTitle;
            }
            var count = await _agendaRepository.GetCountAsync(a => !a.isDeleted && a.CycleId == Cycle.Id);
            Pagination pagination = new Pagination(request.page, request.perPage, count);

            return new BaseResponse<List<AgendaListVm>>("", true, 200, data, pagination);
        }
    }
}
