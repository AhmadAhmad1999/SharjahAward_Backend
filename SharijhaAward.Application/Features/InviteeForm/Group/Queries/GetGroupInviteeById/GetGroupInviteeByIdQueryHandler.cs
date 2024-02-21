using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
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
        private readonly IAsyncRepository<Student> _studentRepository;
        private readonly IMapper _mapper;
        public GetGroupInviteeByIdQueryHandler(
            IAsyncRepository<Student> studentRepository,
            IAsyncRepository<GroupInvitee> groupInviteeRepository,
            IMapper mapper)
        {
            _groupInviteeRepository = groupInviteeRepository;
            _studentRepository = studentRepository;
            _mapper = mapper;
        }

        public async Task<GroupInviteeVM> Handle(GetGroupInviteeByIdQuery request, CancellationToken cancellationToken)
        {
            var GroupInvitee = _groupInviteeRepository.IncludeThenFirstOrDefault(g => g.StudentNames!, g => g.Id == request.Id);
            // var GroupInvitee = await _groupInviteeRepository.GetByIdAsync(request.Id);
            
            if (GroupInvitee == null)
            {
                throw new OpenQA.Selenium.NotFoundException();
            }
            _mapper.Map<List<GroupInviteeStudentsDto>>(GroupInvitee.StudentNames!.ToList());

            return _mapper.Map<GroupInviteeVM>(GroupInvitee);
        }
    }
}
