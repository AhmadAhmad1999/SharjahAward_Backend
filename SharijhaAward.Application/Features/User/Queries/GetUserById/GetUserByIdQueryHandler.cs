using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Domain.Entities.IdentityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.User.Queries.GetUserById
{
    public class GetUserByIdQueryHandler : IRequestHandler<GetUserByIdQuery , UserDto>
    {
        private readonly IAsyncRepository<Domain.Entities.IdentityModels.User> _userRepository;
        private readonly IAsyncRepository<Role> _roleRepository;
        private readonly IMapper _mapper;

        public GetUserByIdQueryHandler(
            IMapper mapper ,
            IAsyncRepository<Domain.Entities.IdentityModels.User> userRepository,
            IAsyncRepository<Role> roleRepository)
        {
            _mapper = mapper;
            _userRepository = userRepository;
            _roleRepository = roleRepository;
        }

        public async Task<UserDto> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
           var user =await _userRepository.GetByIdAsync(request.Id);
            if (user == null)
            {
                throw new OpenQA.Selenium.NotFoundException("User Not Found");
            }
            else
            {
                
                var role = user.RoleId.Equals("") 
                    ? null
                    : await _roleRepository.GetByIdAsync((Guid)user.RoleId);
                UserDto userDto = new UserDto()
                {
                    UserId = request.Id,
                    ArabicName = user.ArabicName,
                    Email = user.Email,
                    EnglishName = user.EnglishName,
                    Role = role == null ? "User Has No Role" : role.RoleName
                };

                return _mapper.Map<UserDto>(userDto);
            }
        }
    }
}
