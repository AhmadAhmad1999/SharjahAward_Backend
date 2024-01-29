using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.Event.Queries.GetAllEvents;
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
            GetAllPersonalInviteeQuery,
            List<PersonalInviteeListVM>
            >
    {
        private readonly IAsyncRepository<PersonalInvitee> _PersonalInviteeRepository;
        private readonly IMapper _mapper;
        public GetAllPersonalInviteeQueryHandler(IAsyncRepository<PersonalInvitee> personalInviteeRepository, IMapper mapper)
        {
            _PersonalInviteeRepository = personalInviteeRepository;
            _mapper = mapper;
        }

        public async Task<List<PersonalInviteeListVM>> Handle(GetAllPersonalInviteeQuery request, CancellationToken cancellationToken)
        {
            var allPersonalInvitee = (await _PersonalInviteeRepository.ListAllAsync());//.OrderBy(x => x.CreatedDate);
            return _mapper.Map<List<PersonalInviteeListVM>>(allPersonalInvitee);
        }
    }
}
