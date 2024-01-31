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
    public class GetEventByIdQueryHandler : IRequestHandler<GetEventByIdQuery , EventDto>
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
                    EventDto @event = new EventDto()
                    {
                        Id = Event.Id,
                        Description = request.lang == "ar" ? Event.ArabicDescription : Event.EnglishDescription,
                        Name = request.lang == "ar" ? Event.ArabicName : Event.EnglishName,
                        SiteName = request.lang == "ar" ? Event.ArabicSiteName : Event.EnglishSiteName,
                        Location = request.lang == "ar" ? Event.ArabicLocation : Event.EnglishLocation,
                        StartDate = Event.StartDate,
                        EndDate = Event.EndDate,
                        ArabicName = Event.ArabicName,
                        ArabicDescription = Event.ArabicDescription,
                        ArabicLocation = Event.ArabicLocation,
                        ArabicSiteName = Event.ArabicSiteName,
                        EnglishName = Event.EnglishName,
                        EnglishDescription = Event.EnglishDescription,
                        EnglishLocation = Event.EnglishLocation,
                        EnglishSiteName = Event.EnglishSiteName
                    };
                    return _mapper.Map<EventDto>(@event);
            }
        }
    }
}
