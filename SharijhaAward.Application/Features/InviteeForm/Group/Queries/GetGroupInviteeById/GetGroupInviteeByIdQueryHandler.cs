using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Domain.Entities.InvitationModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.InviteeForm.Group.Queries.GetGroupInviteeById
{
    public class GetGroupInviteeByIdQueryHandler
        : IRequestHandler<GetGroupInviteeByIdQuery, GroupInviteeVM>
    {
        private readonly IAsyncRepository<GroupInvitee> _groupInviteeRepository;
        private readonly IMapper _mapper;
        public GetGroupInviteeByIdQueryHandler(IAsyncRepository<GroupInvitee> groupInviteeRepository, IMapper mapper)
        {
            _groupInviteeRepository = groupInviteeRepository;
            _mapper = mapper;
        }

        public async Task<GroupInviteeVM> Handle(GetGroupInviteeByIdQuery request, CancellationToken cancellationToken)
        {
            var GroupInvitee = await _groupInviteeRepository.GetByIdAsync(request.Id);
            if (GroupInvitee == null)
            {
                throw new OpenQA.Selenium.NotFoundException();
            }
            return _mapper.Map<GroupInviteeVM>(GroupInvitee);
        }
    }
}
