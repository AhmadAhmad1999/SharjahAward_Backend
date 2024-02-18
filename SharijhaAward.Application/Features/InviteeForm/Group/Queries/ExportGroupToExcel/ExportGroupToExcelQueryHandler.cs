using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Domain.Entities.InvitationModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.InviteeForm.Group.Queries.ExportGroupToExcel
{
    public class ExportGroupToExcelQueryHandler
        : IRequestHandler<ExportGroupToExcelQuery , List<GroupExportVM>>
    {
        private readonly IAsyncRepository<GroupInvitee> _groupInviteeRepository;
        private readonly IMapper _mapper;

        public ExportGroupToExcelQueryHandler(IAsyncRepository<GroupInvitee> groupInviteeRepository, IMapper mapper)
        {
            _groupInviteeRepository = groupInviteeRepository;
            _mapper = mapper;
        }

        public async Task<List<GroupExportVM>> Handle(ExportGroupToExcelQuery request, CancellationToken cancellationToken)
        {
            var groupList = await _groupInviteeRepository.ListAllAsync();
            return _mapper.Map<List<GroupExportVM>>(groupList);
        }
    }
}
