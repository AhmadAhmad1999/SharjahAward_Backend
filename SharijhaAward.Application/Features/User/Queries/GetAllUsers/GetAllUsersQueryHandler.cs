using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Domain.Entities.IdentityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.User.Queries.GetAllUsers
{
    public class GetAllUsersQueryHandler
        : IRequestHandler<GetAllUsersQuery , List<UserListVm>>
    {
        private readonly IAsyncRepository<Domain.Entities.IdentityModels.User> _userRepository;
        private readonly IAsyncRepository<Role> _roleRepository;
        private readonly IMapper _mapper;

        public GetAllUsersQueryHandler
            (
            IAsyncRepository<Domain.Entities.IdentityModels.User> userRepository ,
            IMapper mapper,
            IAsyncRepository<Role> roleRepository
            )
        {
            _userRepository = userRepository;
            _mapper = mapper;
            _roleRepository = roleRepository;
        }

        public async Task<List<UserListVm>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
        {
            var allUser = await _userRepository.ListAllAsync();
            if (allUser == null)
            {
                throw new OpenQA.Selenium.NotFoundException("There is No Users");
            }
            List<UserListVm> userList = new List<UserListVm>();

            for (int i = 0; i < allUser.Count; i++)
            {
                var role = allUser[i].RoleId.Equals("")
                    ? null
                    : await _roleRepository.GetByIdAsync((Guid)allUser[i].RoleId);

                UserListVm userListVm = new UserListVm()
                {
                    UserId = allUser[i].Id,
                    ArabicName = allUser[i].ArabicName,
                    EnglishName = allUser[i].EnglishName,
                    Email = allUser[i].Email,
                    Role = role == null ? "User Has No Role" : role.RoleName
                };
                userList.Add(userListVm);
            }

            return _mapper.Map<List<UserListVm>>(userList);
        }
    }
}
