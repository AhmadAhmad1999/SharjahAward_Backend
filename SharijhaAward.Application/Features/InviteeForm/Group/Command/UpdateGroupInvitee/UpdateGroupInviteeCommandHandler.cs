using AutoMapper;
using FluentValidation;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.InviteeForm.Personal.Command.UpdatePersonalInvitee;
using SharijhaAward.Domain.Entities.InvitationModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.InviteeForm.Group.Command.UpdateGroupInvitee
{
    public class UpdateGroupInviteeCommandHandler
        : IRequestHandler<UpdateGroupInviteeCommand, Unit>
    {
        private readonly IAsyncRepository<GroupInvitee> _GroupInviteeRepository;
        private readonly IMapper _Mapper;
        private readonly IAsyncRepository<Student> _StudentRepository;
        public UpdateGroupInviteeCommandHandler(IAsyncRepository<GroupInvitee> GroupInviteeRepository,
            IMapper Mapper,
            IAsyncRepository<Student> StudentRepository)
        {
            _GroupInviteeRepository = GroupInviteeRepository;
            _Mapper = Mapper;
            _StudentRepository = StudentRepository;
        }

        public async Task<Unit> Handle(UpdateGroupInviteeCommand Request, CancellationToken cancellationToken)
        {
            var validator = new UpdateGroupInviteeCommandValidator();
            var validationResult = await validator.ValidateAsync(Request, cancellationToken);

            if (validationResult.Errors.Count>0)
            {
                throw new ValidationException(validationResult.Errors);
            }
            var GroupInviteeToUpdate = await _GroupInviteeRepository.GetByIdAsync(Request.Id);
            if (GroupInviteeToUpdate == null)
            {
                throw new OpenQA.Selenium.NotFoundException();
            }

            if (Request.StudentNamesAsString != null)
            {
                List<Student> AlreadyExistStudents = _StudentRepository
                    .Where(x => x.GroupInviteeId == Request.Id).ToList();

                await _StudentRepository.DeleteListAsync(AlreadyExistStudents);

                List<Student> Students = Request.StudentNamesAsString.Select(StudentName =>
                    new Student
                    {
                        StudentName = StudentName,
                        GroupInviteeId = Request.Id
                    }).ToList();

                await _StudentRepository.AddRangeAsync(Students);
            }

            _Mapper.Map(Request, GroupInviteeToUpdate, typeof(UpdatePersonalInviteeCommand), typeof(PersonalInvitee));
            await _GroupInviteeRepository.UpdateAsync(GroupInviteeToUpdate);
            return Unit.Value;
        }
    }
}
