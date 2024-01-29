using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Domain.Entities.InvitationModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.InviteeForm.Group.Queries.GetAllGroupInvitees
{
    public class GetAllGroupInviteeQueryHandler
        : IRequestHandler<GetAllGroupInviteeQuery, List<GroupInviteeListVM>>
    {
        private readonly IAsyncRepository<GroupInvitee> _groupInviteeRepository;
        private readonly IMapper _mapper;
        public GetAllGroupInviteeQueryHandler(IAsyncRepository<GroupInvitee> groupInviteeRepository, IMapper mapper)
        {
            _groupInviteeRepository = groupInviteeRepository;
            _mapper = mapper;
        }

        public async Task<List<GroupInviteeListVM>> Handle(GetAllGroupInviteeQuery request, CancellationToken cancellationToken)
        {
            var AllGroupInvitees = await _groupInviteeRepository.ListAllAsync();
            return _mapper.Map<List<GroupInviteeListVM>>(AllGroupInvitees);
        }
    }
}
