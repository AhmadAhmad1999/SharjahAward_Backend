using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Event.Queries.GetAllEvents
{
    public class GetAllEventsQueryHandler : IRequestHandler<GetAllEventsQuery, List<EventListVM>>
    {
        private readonly IAsyncRepository<Domain.Entities.EventModel.Event> _eventRepository;
        private readonly IMapper _mapper;

        public GetAllEventsQueryHandler(IAsyncRepository<Domain.Entities.EventModel.Event> eventRepository, IMapper mapper)
        {
            _eventRepository = eventRepository;
            _mapper = mapper;
        }

        public async Task<List<EventListVM>> Handle(GetAllEventsQuery request, CancellationToken cancellationToken)
        {
            var allEvents = await _eventRepository.ListAllAsync();
            List<EventListVM> allEventsVM = new List<EventListVM>();
         
            for (int i=0 ; i < allEvents.Count ; i++)
            {
                EventListVM vm = new EventListVM();
                vm.Id= allEvents[i].Id;
                vm.Description = request.lang == "ar"? allEvents[i].ArabicDescription : allEvents[i].EnglishDescription;
                vm.Name = request.lang == "ar" ? allEvents[i].ArabicName : allEvents[i].EnglishName;
                vm.SiteName = request.lang == "ar" ? allEvents[i].ArabicSiteName : allEvents[i].EnglishSiteName;
                vm.Location = request.lang == "ar" ? allEvents[i].ArabicLocation : allEvents[i].EnglishLocation;
                vm.StartDate = allEvents[i].StartDate;
                vm.EndDate= allEvents[i].EndDate;
                vm.EnglishName = allEvents[i].EnglishName;
                vm.EnglishDescription = allEvents[i].EnglishDescription;
                vm.EnglishLocation = allEvents[i].EnglishLocation;
                vm.EnglishSiteName = allEvents[i].EnglishSiteName;
                vm.ArabicName = allEvents[i].ArabicName;
                vm.ArabicDescription = allEvents[i].ArabicDescription;
                vm.ArabicLocation = allEvents[i].ArabicLocation;
                vm.ArabicSiteName = allEvents[i].ArabicSiteName;
                allEventsVM.Add(vm);
            }
            
            return _mapper.Map<List<EventListVM>>(allEventsVM);
        }
    }
}
