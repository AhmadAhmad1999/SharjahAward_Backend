using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Domain.Entities.EventModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Event.Queries.ExportToExcel
{
    public class ExportToExcelQueryHandler
        : IRequestHandler<ExportToExcelQuery, List<EventsExportVM>>
    {
        private readonly IAsyncRepository<Domain.Entities.EventModel.Event> _eventRepository;
        private readonly IMapper _mapper;

        public ExportToExcelQueryHandler(
            IAsyncRepository<Domain.Entities.EventModel.Event> eventRepository,
            IMapper mapper
            )
        {
            _eventRepository = eventRepository;
            _mapper = mapper;
        }

        public async Task<List<EventsExportVM>> Handle(ExportToExcelQuery request, CancellationToken cancellationToken)
        {
            var Events =await _eventRepository.ListAllAsync();
            return _mapper.Map<List<EventsExportVM>>(Events);
        }
    }
}
