﻿using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.InvitationModels;

namespace SharijhaAward.Application.Features.InviteeForm.Group.Queries.GetAllGroupInvitees
{
    public class GetAllGroupInviteeQueryHandler
        : IRequestHandler<GetAllGroupInviteeQuery, BaseResponse<List<GroupInviteeListVM>>>
    {
        private readonly IAsyncRepository<GroupInvitee> _groupInviteeRepository;
        private readonly IMapper _mapper;
        public GetAllGroupInviteeQueryHandler(IAsyncRepository<GroupInvitee> groupInviteeRepository, IMapper mapper)
        {
            _groupInviteeRepository = groupInviteeRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<List<GroupInviteeListVM>>> Handle(GetAllGroupInviteeQuery request, CancellationToken cancellationToken)
        {
            List<GroupInvitee> AllGroupInvitees;

            if (request.name != null)
            {
                var allDataWithoutPagenation = _groupInviteeRepository
                    .WhereThenInclude(g => g.Name.ToLower().Contains(request.name.ToLower()) && 
                        (request.EventId != null 
                            ? g.EventId == request.EventId.Value
                            : true), g => g.StudentNames!).ToList();
                AllGroupInvitees = request.pageSize == -1 || request.page == 0
                    ? allDataWithoutPagenation
                    : allDataWithoutPagenation
                      .Skip((request.page - 1) * request.pageSize)
                      .Take(request.pageSize)
                      .ToList();
            }
            else
            {
                AllGroupInvitees = request.pageSize == -1 || request.page == 0
                    ? _groupInviteeRepository.WhereThenInclude(g => request.EventId != null
                        ? g.EventId == request.EventId.Value
                        : true, g => g.StudentNames!).ToList()
                    : _groupInviteeRepository
                        .WhereThenInclude(g => request.EventId != null
                            ? g.EventId == request.EventId.Value
                            : true, g => g.StudentNames!)
                        .Skip((request.page - 1) * request.pageSize)
                        .Take(request.pageSize)
                        .ToList();
            }
            var data =  _mapper.Map<List<GroupInviteeListVM>>(AllGroupInvitees);
            var count =  _groupInviteeRepository.ListAllAsync().Result.Count();
            return new BaseResponse<List<GroupInviteeListVM>>("Retrive Succssfully",true,200,data,count);
        }
    }
}
