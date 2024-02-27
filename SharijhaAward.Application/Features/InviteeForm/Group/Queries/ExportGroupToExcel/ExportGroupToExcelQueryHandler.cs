using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.InviteeForm.Group.Queries.GetGroupInviteeById;
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
            var groupList =  _groupInviteeRepository.WhereThenInclude(g => g.isDeleted != true,g => g.StudentNames!);

            
            return _mapper.Map<List<GroupExportVM>>(groupList);
        }
    }
}
