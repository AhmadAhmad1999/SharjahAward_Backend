using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.InviteeForm.Personal.Queries.GetPersonalByInviteeNumber
{
    public class GetPersonalByInviteeNumberQueryHandler
        : IRequestHandler<GetPersonalByInviteeNumberQuery , PersonalDto>
    {
        private readonly IPersonalInviteeRepository _personalInviteeRepository;
        private readonly IMapper _mapper;

        public GetPersonalByInviteeNumberQueryHandler(IPersonalInviteeRepository personalInviteeRepository, IMapper mapper)
        {
            _personalInviteeRepository = personalInviteeRepository;
            _mapper = mapper;
        }

        public async Task<PersonalDto> Handle(GetPersonalByInviteeNumberQuery request, CancellationToken cancellationToken)
        {
            var personal = await _personalInviteeRepository.GetByInviteeNumber(request.InviteeNumber);
            if (personal == null)
            {
                throw new OpenQA.Selenium.NotFoundException("There is no Personal Invitee");
            }
            return _mapper.Map<PersonalDto>(personal);
        }
    }
}
