using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CoordinatorModel;
using SharijhaAward.Domain.Entities.IdentityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Coordinators.Commands.CreateCoordinator
{
    public class CreateCoordinatorCommandHandler
         : IRequestHandler<CreateCoordinatorCommand, BaseResponse<Guid>>
    {
        private readonly IAsyncRepository<Coordinator> _coordinatorRepository;
        private readonly IRoleRepository _roleRepository;
        private readonly IUserRepository _userRepository;
        private readonly IFileService _fileService;
        private readonly IMapper _mapper;

        public CreateCoordinatorCommandHandler(IRoleRepository roleRepository, IAsyncRepository<Coordinator> coordinatorRepository, IFileService fileService, IUserRepository userRepository, IMapper mapper)
        {
            _roleRepository = roleRepository;
            _coordinatorRepository = coordinatorRepository;
            _userRepository = userRepository;
            _fileService = fileService;
            _mapper = mapper;
        }

        public async Task<BaseResponse<Guid>> Handle(CreateCoordinatorCommand request, CancellationToken cancellationToken)
        {
            var Coordinator = _mapper.Map<Coordinator>(request);
            Coordinator.PersonalPhoto = await _fileService.SaveFileAsync(request.PersonalPhoto);

            var data = await _coordinatorRepository.AddAsync(Coordinator);
            var User = new Domain.Entities.IdentityModels.User()
            {
                ArabicName = data.ArabicName,
                EnglishName = data.EnglishName,
                Email = data.Email,
                Id = data.Id,
                Password = "123456",
                Gender = 0
            };
            await _userRepository.AddAsync(User);

            var role = await _roleRepository.GetByName("Coordinator");
            if(role != null)
            {
                await _userRepository.AsignRole(User.Id, role.RoleId);
            }
            return new BaseResponse<Guid>("", true, 200, data.Id);
        }
    }
}
