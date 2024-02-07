using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.InviteeForm.Group.Queries.GetGroupByInviteeNumber
{
    public class GetGroupByInviteeNumberQueryHandler
        : IRequestHandler<GetGroupByInviteeNumberQuery , GroupDto>
    {
        private readonly IGroupInviteeRepository _groupInviteeRepository;
        private readonly IMapper _mapper;

        public GetGroupByInviteeNumberQueryHandler(IGroupInviteeRepository groupInviteeRepository, IMapper mapper)
        {
            _groupInviteeRepository = groupInviteeRepository;
            _mapper = mapper;
        }

        public async Task<GroupDto> Handle(GetGroupByInviteeNumberQuery request, CancellationToken cancellationToken)
        {
            var group = await _groupInviteeRepository.GetByInviteeNumber(request.InviteeNumber);
            if (group == null)
            {
                throw new OpenQA.Selenium.NotFoundException("There is No Group Invitee");
            }

            return _mapper.Map<GroupDto>(group);

        }
    }
}
