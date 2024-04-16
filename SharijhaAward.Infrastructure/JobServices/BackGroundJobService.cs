using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
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
    public class BackGroundJobService : BackgroundService
    {
        private readonly IAsyncRepository<Agenda> _agendaRepository;
        private readonly IAsyncRepository<Cycle> _cycleRepository;
        private readonly ILogger<BackGroundJobService> _logger;

   
        public BackGroundJobService(ILogger<BackGroundJobService> logger, IAsyncRepository<Agenda> agendaRepository, IAsyncRepository<Cycle> cycleRepository)
        {
            _agendaRepository = agendaRepository;
            _cycleRepository = cycleRepository;
            _logger = logger;
        }

        public async Task ChangeAgendaStateAsync()
        {
            var Cycle = await _cycleRepository.FirstOrDefaultAsync(c => c.Status == Domain.Constants.Common.Status.Active);
            if (Cycle == null)
            {
                return;
            }

            var Agendas = _agendaRepository.Where(a => a.CycleId == Cycle.Id).ToList();

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
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                var Cycle = await _cycleRepository.FirstOrDefaultAsync(c => c.Status == Domain.Constants.Common.Status.Active);
                if (Cycle == null)
                {
                    return;
                }

                var Agendas = _agendaRepository.Where(a => a.CycleId == Cycle.Id).ToList();

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

                // Delay for 1 minute
                await Task.Delay(TimeSpan.FromMinutes(1), stoppingToken);
            }
        }
    }
}
