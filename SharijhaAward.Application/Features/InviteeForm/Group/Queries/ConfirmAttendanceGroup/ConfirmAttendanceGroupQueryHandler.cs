using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Domain.Entities.InvitationModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace SharijhaAward.Application.Features.InviteeForm.Group.Queries.ConfirmAttendanceGroup
{
    public class ConfirmAttendanceGroupQueryHandler
        : IRequestHandler<ConfirmAttendanceGroupQuery, Unit>
    {
        private readonly IGroupInviteeRepository _groupInviteeRepository;
        private readonly IAsyncRepository<Student> _studentRepository;
        public ConfirmAttendanceGroupQueryHandler(IGroupInviteeRepository groupInviteeRepository,IAsyncRepository<Student> studentRepository)
        {
            _groupInviteeRepository = groupInviteeRepository;
            _studentRepository = studentRepository;
        }

        public async Task<Unit> Handle(ConfirmAttendanceGroupQuery request, CancellationToken cancellationToken)
        {
            var group = await _groupInviteeRepository.GetByIdAsync(request.Id);
            if (group == null)
            {
               throw new OpenQA.Selenium.NotFoundException();
            }
            if (request.StudentNames != null)
            {
                var students = request.StudentNames.Select(StudentName =>
                new Student
                {
                    StudentName = StudentName,
                    GroupInviteeId = request.Id 
                }).ToList();

                await _studentRepository.AddRangeAsync(students);
            }
            await _groupInviteeRepository.ConfirmationofAttendance(group, request.NumberOfAttendees);
            return Unit.Value;
        }
    }
}
