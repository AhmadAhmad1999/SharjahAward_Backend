using AutoMapper;
using MediatR;
using PdfSharpCore.Pdf;
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
            List<GroupInvitee> AllGroupInvitees;

            if (request.name != null)
            {
                 AllGroupInvitees = request.pageSize == -1 || request.page == 0
                   ? _groupInviteeRepository.WhereThenInclude(g => g.Name.ToLower().Contains(request.name.ToLower()), g => g.StudentNames!).ToList()
                   : _groupInviteeRepository
                   .WhereThenInclude(g => g.Name.ToLower()
                   .Contains(request.name!.ToLower()), g => g.StudentNames!)
                   .Skip((request.page - 1) * request.pageSize)
                   .Take(request.pageSize)
                   .ToList();
            }
            else
            {
                
                    AllGroupInvitees = request.pageSize == -1 || request.page == 0
                      ? _groupInviteeRepository.WhereThenInclude(g => true, g => g.StudentNames!).ToList()
                      : _groupInviteeRepository
                      .WhereThenInclude(g => true, g => g.StudentNames!)
                      .Skip((request.page - 1) * request.pageSize)
                      .Take(request.pageSize)
                      .ToList();
               
            }
            return _mapper.Map<List<GroupInviteeListVM>>(AllGroupInvitees);
        }
    }
}
