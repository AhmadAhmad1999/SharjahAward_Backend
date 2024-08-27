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
        private readonly IAsyncRepository<Student> _StudentRepository;
        private readonly IMapper _mapper;

        public ExportGroupToExcelQueryHandler(IAsyncRepository<GroupInvitee> groupInviteeRepository,
            IAsyncRepository<Student> StudentRepository,
            IMapper mapper)
        {
            _groupInviteeRepository = groupInviteeRepository;
            _StudentRepository = StudentRepository;
            _mapper = mapper;
        }

        public async Task<List<GroupExportVM>> Handle(ExportGroupToExcelQuery request, CancellationToken cancellationToken)
        {
            var groupList = await _groupInviteeRepository
                .Where(g => true)
                .ToListAsync();

            List<GroupExportVM> GroupExportVM = _mapper.Map<List<GroupExportVM>>(groupList);

            List<Student> AllStudentEntities = await _StudentRepository
                .Where(x => GroupExportVM.Select(y => y.Id).Contains(x.GroupInviteeId))
                .ToListAsync();

            foreach (var GroupExport in GroupExportVM)
            {
                GroupExport.StudentNames = AllStudentEntities
                    .Where(x => x.GroupInviteeId == GroupExport.Id)
                    .Select(x => x.StudentName)
                    .ToList();
            }
            
            return GroupExportVM;
        }
    }
}
