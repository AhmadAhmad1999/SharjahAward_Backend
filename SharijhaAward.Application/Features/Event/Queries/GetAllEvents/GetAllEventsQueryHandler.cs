﻿using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
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
            var allEvents = request.pageSize == -1 || request.page==0
                ? await _eventRepository.ListAllAsync()
                : await _eventRepository.GetPagedReponseAsync(request.page,request.pageSize);
           
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
            var count =  _eventRepository.ListAllAsync().Result.Count();
            return new BaseResponse<List<EventListVM>>("تم إسترجاع الفعاليات بنجاح", true, 200, data, count);
        }
    }
}
