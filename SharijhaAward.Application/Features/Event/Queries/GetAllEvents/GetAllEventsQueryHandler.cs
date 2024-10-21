using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Event.Queries.GetAllEvents
{
    public class GetAllEventsQueryHandler : IRequestHandler<GetAllEventsQuery, BaseResponse<List<EventListVM>>>
    {
        private readonly IAsyncRepository<Domain.Entities.EventModel.Event> _eventRepository;
        private readonly IMapper _mapper;

        public GetAllEventsQueryHandler(IAsyncRepository<Domain.Entities.EventModel.Event> eventRepository, IMapper mapper)
        {
            _eventRepository = eventRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<List<EventListVM>>> Handle(GetAllEventsQuery request, CancellationToken cancellationToken)
        {
            FilterObject filterObject = new FilterObject() { Filters = request.filters };

            var allEvents = request.perPage == -1 || request.page==0
                ? await _eventRepository.OrderByDescending(filterObject, x => x.CreatedAt, 0, -1).ToListAsync()
                : await _eventRepository.OrderByDescending(filterObject, x => x.CreatedAt, request.page,request.perPage).ToListAsync();
           
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
                vm.EventDate = allEvents[i].EventDate;
                vm.EnglishName = allEvents[i].EnglishName;
                vm.EnglishDescription = allEvents[i].EnglishDescription;
                vm.EnglishLocation = allEvents[i].EnglishLocation;
                vm.EnglishSiteName = allEvents[i].EnglishSiteName;
                vm.ArabicName = allEvents[i].ArabicName;
                vm.ArabicDescription = allEvents[i].ArabicDescription;
                vm.ArabicLocation = allEvents[i].ArabicLocation;
                vm.ArabicSiteName = allEvents[i].ArabicSiteName;
                vm.CreatedAt= allEvents[i].CreatedAt;
                allEventsVM.Add(vm);
            }
            
            var data = _mapper.Map<List<EventListVM>>(allEventsVM);

            var count =  _eventRepository.WhereThenFilter(a => true, filterObject).Count();

            Pagination pagination = new Pagination(request.page, request.perPage, count);

            return new BaseResponse<List<EventListVM>>(string.Empty, true, 200, data, pagination);
        }
    }
}
