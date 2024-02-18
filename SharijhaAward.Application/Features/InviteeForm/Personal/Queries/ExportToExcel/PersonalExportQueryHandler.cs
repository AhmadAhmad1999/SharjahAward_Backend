using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Domain.Entities.InvitationModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.InviteeForm.Personal.Queries.ExportToExcel
{
    public class PersonalExportQueryHandler
        : IRequestHandler<PersonalExportQuery , List<PersonalExportVM>>
    {
        private readonly IAsyncRepository<PersonalInvitee> _personalInviteeRepository;
        private readonly IMapper _mapper;

        public PersonalExportQueryHandler(IAsyncRepository<PersonalInvitee> personalInviteeRepository, IMapper mapper)
        {
            _personalInviteeRepository = personalInviteeRepository;
            _mapper = mapper;
        }

        public async Task<List<PersonalExportVM>> Handle(PersonalExportQuery request, CancellationToken cancellationToken)
        {
            var PersonalList = await _personalInviteeRepository.ListAllAsync();
            return _mapper.Map<List<PersonalExportVM>>(PersonalList);
        }
    }
}
