using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Event.Queries.GetEventById
{
    public class GetEventByIdQueryHandler : IRequestHandler<GetEventByIdQuery, EventDto>
    {
        private readonly IAsyncRepository<Domain.Entities.EventModel.Event> _eventRepository;
        private readonly IMapper _mapper;

        public GetEventByIdQueryHandler(IAsyncRepository<Domain.Entities.EventModel.Event > eventRepository, IMapper mapper)
        {
            _eventRepository = eventRepository;
            _mapper = mapper;
        }
        public async Task<EventDto> Handle(GetEventByIdQuery request, CancellationToken cancellationToken)
        {
            var Event = await _eventRepository.GetByIdAsync(request.Id);

            if (Event == null)
            {
                throw new OpenQA.Selenium.NotFoundException();
            }
            else
            {
               return _mapper.Map<EventDto>(Event);
               
            }
        }
    }
}
