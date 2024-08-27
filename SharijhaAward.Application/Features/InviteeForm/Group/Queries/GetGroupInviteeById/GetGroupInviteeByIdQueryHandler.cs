using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Domain.Entities.InvitationModels;

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
            var GroupInvitee = await _groupInviteeRepository.FirstOrDefaultAsync(g => g.Id == request.Id);

            if (GroupInvitee == null)
            {
                throw new OpenQA.Selenium.NotFoundException();
            }

            GroupInviteeVM GroupInviteeVM = _mapper.Map<GroupInviteeVM>(GroupInvitee);

            GroupInviteeVM.StudentNamesAsString = await _studentRepository
                .Where(x => x.GroupInviteeId == request.Id)
                .Select(x => x.StudentName)
                .ToListAsync();

            return GroupInviteeVM;
        }
    }
}
