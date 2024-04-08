using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Domain.Entities.AgendaModel;
using SharijhaAward.Domain.Entities.CycleModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Infrastructure.JobServices
{
    public class BackGroundJobService : IBackGroundJobService
    {
        private readonly IAsyncRepository<Agenda> _agendaRepository;
        private readonly IAsyncRepository<Cycle> _cycleRepository;

        public BackGroundJobService(IAsyncRepository<Agenda> agendaRepository, IAsyncRepository<Cycle> cycleRepository)
        {
            _agendaRepository = agendaRepository;
            _cycleRepository = cycleRepository;
        }

        public async Task ChangeAgendaStateAsync()
        {
            var Cycle = await _cycleRepository.FirstOrDefaultAsync(c => c.Status == Domain.Constants.Common.Status.Active);
            if(Cycle == null)
            {
                return;
            }

            var Agendas = _agendaRepository.Where(a => a.CycleId == Cycle.Id).ToList();

            foreach(var agenda in Agendas)
            {
                if(DateTime.Now >= agenda.StartDate && DateTime.Now <= agenda.EndDate)
                {
                    agenda.Status = Domain.Constants.AgendaConstants.AgendaStatus.Active;
                }
                else if(DateTime.Now > agenda.StartDate && DateTime.Now > agenda.EndDate)
                {
                    agenda.Status = Domain.Constants.AgendaConstants.AgendaStatus.Later;
                }
                else if(DateTime.Now < agenda.StartDate && DateTime.Now < agenda.EndDate)
                {
                    agenda.Status = Domain.Constants.AgendaConstants.AgendaStatus.Previous;
                }
                await _agendaRepository.UpdateAsync(agenda);
            }
        }

    }
}
