using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Domain.Entities.InvitationModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

            for(int i=0; i<PersonalList.Count; i++)
            {
                if(PersonalList[i].TypeOfInvitee.ToLower() == "winner".ToLower())
                {
                    PersonalList[i].TypeOfInvitee = "فائز";
                }
                else if(PersonalList[i].TypeOfInvitee.ToLower() == "winnerCompanion".ToLower())
                {
                    PersonalList[i].TypeOfInvitee = "مرافق فائز";
                } 
                else if(PersonalList[i].TypeOfInvitee.ToLower() == "other".ToLower())
                {
                    PersonalList[i].TypeOfInvitee = "آخر";
                }
                                
            }
            return _mapper.Map<List<PersonalExportVM>>(PersonalList);
        }
    }
}
