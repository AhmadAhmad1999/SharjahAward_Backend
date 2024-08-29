using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.Responsibilities.Queries.GetAllResponsibilities;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities;
using SharijhaAward.Domain.Entities.IdentityModels;
using SharijhaAward.Domain.Entities.ResponsibilityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Responsibilities.Queries.GetAllResponsibilitiesByUserId
{
    public class GetAllResponsibilitiesByUserIdQueryHandler
        : IRequestHandler<GetAllResponsibilitiesByUserIdQuery, BaseResponse<List<ResponsibilityListVM>>>
    {
        
        private readonly IAsyncRepository<Responsibility> _responsibilityRepository;
        private readonly IAsyncRepository<Role> _roleRepository;
        private readonly IAsyncRepository<ResponsibilityUser> _responsibilityUserRepository;
        private readonly IAsyncRepository<UserRole> _userRoleRepository;
        private readonly IUserRepository _userRepository;
        private readonly IJwtProvider _jwtProvider;
        private readonly IMapper _mapper;

        public GetAllResponsibilitiesByUserIdQueryHandler(IAsyncRepository<ResponsibilityUser> responsibilityUserRepository, IAsyncRepository<UserRole> userRoleRepository, IAsyncRepository<Responsibility> responsibilityRepository, IAsyncRepository<Role> roleRepository, IUserRepository userRepository, IJwtProvider jwtProvider, IMapper mapper)
        {
            _responsibilityRepository = responsibilityRepository;
            _roleRepository = roleRepository;
            _userRoleRepository = userRoleRepository;
            _responsibilityUserRepository = responsibilityUserRepository;
            _userRepository = userRepository;
            _jwtProvider = jwtProvider;
            _mapper = mapper;
        }

        public async Task<BaseResponse<List<ResponsibilityListVM>>> Handle(GetAllResponsibilitiesByUserIdQuery request, CancellationToken cancellationToken)
        {

            var UserId = request.UserId != null
                ? request.UserId
                : int.Parse(_jwtProvider.GetUserIdFromToken(request.UserToken!));

            if (UserId == null && request.UserId == null)
            {
                return new BaseResponse<List<ResponsibilityListVM>>("", false, 400);
            }
            else if(UserId == null && request.UserToken == null)
            {
                return new BaseResponse<List<ResponsibilityListVM>>("Un Auth", false, 401);
            }
            var User = await _userRepository.GetByIdAsync(UserId);

            if(User == null)
            {
                return new BaseResponse<List<ResponsibilityListVM>>("", false, 404);
            }

            var Responsibilities = new List<Responsibility>();
           
            var UserResponsibility = await _responsibilityUserRepository
            .Where(r => r.UserId == UserId)
            .ToListAsync();

            var RoleIds = _userRoleRepository
                 .Where(u => u.UserId == User.Id)
                 .Select(u => u.RoleId)
                 .ToList();

            foreach (var responsibility in UserResponsibility)
            {
                Responsibilities.Add(responsibility.Responsibility);
            }

            var data = _mapper.Map<List<ResponsibilityListVM>>(Responsibilities);

            var AllResponsibilityUserEntitties = await _responsibilityUserRepository
                .Where(x => Responsibilities.Select(y => y.Id).Contains(x.ResponsibilityId))
                .ToListAsync();

            for (int i=0; i < data.Count(); i++)
            {
                data[i].ResponsibilityUsers = _mapper.Map<List<ResponsibilityUserDto>>(AllResponsibilityUserEntitties
                    .Where(x => x.ResponsibilityId == data[i].Id)
                    .ToList());

                data[i].RoleName = Responsibilities[i].Role!.ArabicName;
            }

            return new BaseResponse<List<ResponsibilityListVM>>("", true, 200, data);

        }
    } 
}
