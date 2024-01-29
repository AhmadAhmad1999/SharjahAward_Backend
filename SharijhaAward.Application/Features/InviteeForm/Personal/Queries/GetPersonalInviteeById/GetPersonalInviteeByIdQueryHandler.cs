using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Domain.Entities.InvitationModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.InviteeForm.Personal.Queries.GetPersonalInviteeById
{
    public class GetPersonalInviteeByIdQueryHandler
        : IRequestHandler<GetPersonalInviteeByIdQuery, PersonalInviteeVM>
    {
        private readonly IAsyncRepository<PersonalInvitee> _PersonalInviteeRepository;
        private readonly IMapper _Mapper;

        public GetPersonalInviteeByIdQueryHandler(IAsyncRepository<PersonalInvitee> personalInviteeRepository, IMapper mapper)
        {
            _PersonalInviteeRepository = personalInviteeRepository;
            _Mapper = mapper;
        }

        public async Task<PersonalInviteeVM> Handle(GetPersonalInviteeByIdQuery request, CancellationToken cancellationToken)
        {
            PersonalInvitee? Personal = await _PersonalInviteeRepository
                .GetByIdAsync(request.Id);

            if (Personal is null)
                throw new OpenQA.Selenium.NotFoundException();

            return _Mapper.Map<PersonalInviteeVM>(Personal);
        }
    }
}
