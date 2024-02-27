﻿using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.Event.Queries.GetAllEvents;
using SharijhaAward.Application.Features.InviteeForm.Personal.Queries.ExportToExcel;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.InvitationModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.InviteeForm.Personal.Queries.GetAllPersonalInvitee
{
    public class GetAllPersonalInviteeQueryHandler
        : IRequestHandler<
            GetAllPersonalInviteeQuery, BaseResponse<List<PersonalInviteeListVM>>
            >
    {
        private readonly IAsyncRepository<PersonalInvitee> _PersonalInviteeRepository;
        private readonly IMapper _mapper;
        public GetAllPersonalInviteeQueryHandler(IAsyncRepository<PersonalInvitee> personalInviteeRepository, IMapper mapper)
        {
            _PersonalInviteeRepository = personalInviteeRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<List<PersonalInviteeListVM>>> Handle(GetAllPersonalInviteeQuery request, CancellationToken cancellationToken)
        {
            List<PersonalInvitee> allPersonalInvitee;
            if (request.name != null)
            {
                allPersonalInvitee = request.pageSize == -1 || request.page == 0
                  ? _PersonalInviteeRepository.Where(g => g.Name.ToLower().Contains(request.name.ToLower())).OrderBy(g => g.CreatedAt).ToList()
                  : _PersonalInviteeRepository
                  .Where(g => g.Name.ToLower()
                  .Contains(request.name!.ToLower()))
                  .Skip((request.page - 1) * request.pageSize)
                  .Take(request.pageSize)
                  .OrderBy(g => g.CreatedAt)
                  .ToList();
            }
            else
            {
                allPersonalInvitee = (List<PersonalInvitee>)(request.pageSize == -1 || request.page == 0
                  ? await _PersonalInviteeRepository.ListAllAsync()
                  : await _PersonalInviteeRepository.GetPagedReponseAsync(request.page, request.pageSize));


            }
            
            
            var data = _mapper.Map<List<PersonalInviteeListVM>>(allPersonalInvitee);
            var Count = (await _PersonalInviteeRepository.ListAllAsync()).Count;
            return new BaseResponse<List<PersonalInviteeListVM>>("Retrive Succssfully", true, 200, data, Count);
        }
    }
}
