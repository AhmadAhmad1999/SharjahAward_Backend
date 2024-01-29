using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Event.Queries.GetEventWithInvitees
{
    public class GetEventWithInviteesQueryHandler : IRequestHandler<GetEventWithInviteesQuery, EventInviteesVM>
    {
        private readonly IEventRepository _EventRepository;
        private readonly IMapper _mapper;

        public GetEventWithInviteesQueryHandler(IEventRepository eventRepository, IMapper mapper)
        {
            _EventRepository = eventRepository;
            _mapper = mapper;
        }

        public async Task<EventInviteesVM> Handle(GetEventWithInviteesQuery request, CancellationToken cancellationToken)
        {

            var Event = await _EventRepository.GetByIdAsync(request.Id);
            if (Event == null)
            {
                throw new OpenQA.Selenium.NotFoundException();
            }

            Event = await _EventRepository.GetEventWithInvitees(Event.Id);

            var xx = _mapper.Map<List<EventInvitessDto>>(Event.PersonalInvitees.ToList());

            var result = _mapper.Map<EventInviteesVM>(Event);

            return result;
               
        }
    }
}
