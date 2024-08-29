using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.IdentityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.User.Queries.GetUserById
{
    public class GetUserByIdQueryHandler : IRequestHandler<GetUserByIdQuery , BaseResponse<UserDto>>
    {
        private readonly IUserRepository _userRepository;
        private readonly IAsyncRepository<Role> _roleRepository;
        private readonly IJwtProvider _jwtProvider;
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<UserRole> _UserRoleRepository;

        public GetUserByIdQueryHandler(
            IMapper mapper ,
            IJwtProvider jwtProvider ,
            IUserRepository userRepository,
            IAsyncRepository<Role> roleRepository,
            IAsyncRepository<UserRole> UserRoleRepository)
        {
            _mapper = mapper;
            _jwtProvider = jwtProvider;
            _userRepository = userRepository;
            _roleRepository = roleRepository;
            _UserRoleRepository = UserRoleRepository;
        }

        public async Task<BaseResponse<UserDto>> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
            var UserId = request.Id == null
                ? _jwtProvider.GetUserIdFromToken(request.token)
                : request.Id.ToString();

            var User = await _userRepository.GetByIdAsync(int.Parse(UserId));

            if(User == null)
            {
                return new BaseResponse<UserDto>("", false, 404);
            }

            List<string> UserRoles = await _UserRoleRepository.Where(x => x.UserId == User.Id)
                .Select(x => request.lang.ToLower() == "en"
                    ? x.Role!.EnglishName
                    : x.Role!.ArabicName)
                .ToListAsync();

            var data = _mapper.Map<UserDto>(User);

            data.UserRoles = UserRoles;

            return new BaseResponse<UserDto>("", true, 200, data);
        }
    }
}
